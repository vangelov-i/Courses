namespace BunnyWars.Core
{
    using System;

    public class Bunny : IComparable<Bunny>
    {
        private int team;
        
        public Bunny(string name, int team, int roomId)
        {
            this.Name = name;
            this.Team = team;
            this.RoomId = roomId;
            this.Health = 100;
        }

        public int RoomId { get; set; }

        public string Name { get; private set; }

        public int Health { get; set; }

        public int Score { get; set; }

        public int Team
        {
            get
            {
                return this.team;
            }

            private set
            {
                if (value < 0 || value >= 5)
                {
                    throw new IndexOutOfRangeException("Invalid room id.");
                }

                this.team = value;
            }
        }


        public bool isAlive => this.Health > 0;

        public int CompareTo(Bunny other)
        {
            return -this.Name.CompareTo(other.Name);
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
