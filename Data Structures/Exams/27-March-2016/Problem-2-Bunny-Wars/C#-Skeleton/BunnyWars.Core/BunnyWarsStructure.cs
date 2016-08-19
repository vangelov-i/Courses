namespace BunnyWars.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Wintellect.PowerCollections;

    public class BunnyWarsStructure : IBunnyWarsStructure
    {
        private readonly OrderedSet<int> roomsById;
        private readonly Dictionary<string, Bunny> bunniesByName;
        private readonly OrderedDictionary<string, Bunny> bunniesOrderedReversedNames;

        private readonly OrderedDictionary<int, Dictionary<int, HashSet<Bunny>>> bunniesInTeamsByRoom;
        private readonly Dictionary<int, OrderedSet<Bunny>> teamsBunnies;

        public BunnyWarsStructure()
        {
            this.bunniesInTeamsByRoom = new OrderedDictionary<int, Dictionary<int, HashSet<Bunny>>>();
            this.roomsById = new OrderedSet<int>();
            this.bunniesByName = new Dictionary<string, Bunny>();
            this.teamsBunnies = new Dictionary<int, OrderedSet<Bunny>>();

            this.bunniesOrderedReversedNames = new OrderedDictionary<string, Bunny>(StringComparer.Ordinal);
        }

        public int BunnyCount => this.bunniesByName.Count;

        public int RoomCount => this.bunniesInTeamsByRoom.Count;

        public void AddRoom(int roomId)
        {
            if (this.bunniesInTeamsByRoom.ContainsKey(roomId))
            {
                throw new ArgumentException("Room already exists");
            }

            this.bunniesInTeamsByRoom[roomId] = new Dictionary<int, HashSet<Bunny>>();
            this.roomsById.Add(roomId);
        }

        public void AddBunny(string name, int team, int roomId)
        {
            if (this.bunniesByName.ContainsKey(name))
            {
                throw new ArgumentException("Bunny with the given name already exists.");
            }

            if (!this.bunniesInTeamsByRoom.ContainsKey(roomId))
            {
                throw new ArgumentException("Room with the given id does not exist.");
            }

            var bunny = new Bunny(name, team, roomId);

            if (!this.bunniesInTeamsByRoom[roomId].ContainsKey(team))
            {
                this.bunniesInTeamsByRoom[roomId][team] = new HashSet<Bunny>();
            }

            this.bunniesInTeamsByRoom[roomId][team].Add(bunny);
            this.bunniesByName[name] = bunny;

            if (!this.teamsBunnies.ContainsKey(team))
            {
                this.teamsBunnies[team] = new OrderedSet<Bunny>();
            }

            this.teamsBunnies[team].Add(bunny);

            string reversedName = new string(name.Reverse().ToArray());
            this.bunniesOrderedReversedNames.Add(reversedName, bunny);
        }

        public void Remove(int roomId)
        {
            if (!this.bunniesInTeamsByRoom.ContainsKey(roomId))
            {
                throw new ArgumentException("Room with the given Id does not exist.");
            }

            var bunniesToRemove = this.bunniesInTeamsByRoom[roomId];
            foreach (var roomBunnies in bunniesToRemove)
            {
                foreach (var bunny in roomBunnies.Value)
                {
                    string name = bunny.Name;
                    string reversedName = new string(name.Reverse().ToArray());
                    int team = bunny.Team;

                    this.bunniesByName.Remove(name);
                    this.teamsBunnies[team].Remove(bunny);
                    this.bunniesOrderedReversedNames.Remove(reversedName);
                }
            }

            this.bunniesInTeamsByRoom.Remove(roomId);
        }

        public void Next(string bunnyName)
        {
            this.ValidateBunny(bunnyName);

            var bunny = this.bunniesByName[bunnyName];
            int currentRoom = bunny.RoomId;
            int roomIndex = this.roomsById.IndexOf(currentRoom);

            roomIndex = (roomIndex + 1) % this.roomsById.Count;
            int nextRoom = this.roomsById[roomIndex];

            bunny.RoomId = nextRoom;
        }

        public void Previous(string bunnyName)
        {
            this.ValidateBunny(bunnyName);

            var bunny = this.bunniesByName[bunnyName];
            int currentRoom = bunny.RoomId;
            int roomIndex = this.roomsById.IndexOf(currentRoom);

            roomIndex--;
            if (roomIndex < 0)
            {
                roomIndex = this.roomsById.Count - 1;
            }

            int previousRoom = this.roomsById[roomIndex];
            bunny.RoomId = previousRoom;
        }

        public void Detonate(string bunnyName)
        {
            this.ValidateBunny(bunnyName);

            var detonatingBunny = this.bunniesByName[bunnyName];
            int detonateTeam = detonatingBunny.Team;
            int room = detonatingBunny.RoomId;

            var enemies = this.bunniesInTeamsByRoom[room]
                .Where(teamBunniesPair => teamBunniesPair.Key != detonateTeam);
            var bunniesToRemove = new List<Bunny>();
            foreach (var bunny in enemies.SelectMany(teamBunnies => teamBunnies.Value))
            {
                bunny.Health -= 30;
                if (bunny.isAlive)
                {
                    continue;
                }

                detonatingBunny.Score++;
                bunniesToRemove.Add(bunny);
            }

            this.Remove(bunniesToRemove);
        }

        public IEnumerable<Bunny> ListBunniesByTeam(int team)
        {
            if (team < 0 || team >= 5 || !this.teamsBunnies.ContainsKey(team))
            {
                throw new IndexOutOfRangeException("Invalid team.");
            }

            return this.teamsBunnies[team];
        }

        public IEnumerable<Bunny> ListBunniesBySuffix(string suffix)
        {
            var reversedSuffixArr = suffix.Reverse().ToArray();
            string reversedSuffix = new string(reversedSuffixArr);
            var end = reversedSuffix + char.MaxValue;
            var result = this.bunniesOrderedReversedNames.Range(reversedSuffix, true, end, false).Values;

            return result;
        }

        private void ValidateBunny(string bunnyName)
        {
            if (!this.bunniesByName.ContainsKey(bunnyName))
            {
                throw new ArgumentException("Bunny with the given name does not exist.");
            }
        }

        private void Remove(IEnumerable<Bunny> bunnies)
        {
            foreach (var bunny in bunnies)
            {
                string name = bunny.Name;
                string reversedName = new string(name.Reverse().ToArray());
                int team = bunny.Team;
                int room = bunny.RoomId;

                this.bunniesInTeamsByRoom[room][team].Remove(bunny);
                this.bunniesByName.Remove(name);
                this.teamsBunnies[team].Remove(bunny);
                this.bunniesOrderedReversedNames.Remove(reversedName);
            }
        }
    }
}