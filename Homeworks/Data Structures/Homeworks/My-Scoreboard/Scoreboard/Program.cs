using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Wintellect.PowerCollections;

public class Program
{
    private static Scoreboard scoreData;

    static void Main()
    {
        scoreData = new Scoreboard();

        string currentLine = Console.ReadLine();
        while (currentLine != "End")
        {
            if (currentLine == string.Empty)
            {
                currentLine = Console.ReadLine();
                continue;
            }

            string[] commandParams = currentLine.Split();
            string comandName = commandParams[0];
            switch (comandName)
            {
                case "RegisterUser":
                    ExecuteRegisterUserCommand(commandParams);
                    break;
                case "RegisterGame":
                    ExecuteRegisterGameCommand(commandParams);
                    break;
                case "AddScore":
                    ExecuteAddScoreCommand(commandParams);
                    break;
                case "ShowScoreboard":
                    ExecuteShowScoreboardCommand(commandParams);
                    break;
                case "ListGamesByPrefix":
                    ExecuteGamesByPrefixCommand(commandParams);
                    break;
                case "DeleteGame":
                    ExecuteDeleteGameCommand(commandParams);
                    break;
            }

            currentLine = Console.ReadLine();
        }
    }

    private static void ExecuteRegisterUserCommand(string[] commandParams)
    {
        string username = commandParams[1];
        string password = commandParams[2];

        bool userRegistered = scoreData.RegisterUser(username, password);
        Console.WriteLine(userRegistered ? "User registered" : "Duplicated user");
    }

    private static void ExecuteRegisterGameCommand(string[] commandParams)
    {
        string name = commandParams[1];
        string password = commandParams[2];

        bool gameRegistered = scoreData.RegisterGame(name, password);
        Console.WriteLine(gameRegistered ? "Game registered" : "Duplicated game");
    }

    private static void ExecuteAddScoreCommand(string[] commandParams)
    {
        string username = commandParams[1];
        string userPassword = commandParams[2];
        string gameName = commandParams[3];
        string gamePassword = commandParams[4];
        int score = int.Parse(commandParams[5]);

        bool scoreAdded = scoreData.AddScore(
            username,
            userPassword,
            gameName,
            gamePassword,
            score);

        Console.WriteLine(scoreAdded ? "Score added" : "Cannot add score");
    }

    private static void ExecuteShowScoreboardCommand(string[] commandParams)
    {
        string gameName = commandParams[1];

        var result = scoreData.GetScoreBoard(gameName);
        Console.Write(result);
    }

    private static void ExecuteGamesByPrefixCommand(string[] commandParams)
    {
        string gameNamePrefix = commandParams[1];

        string result = scoreData.GetFirst10GamesByPrefix(gameNamePrefix);

        Console.WriteLine(result);
    }

    private static void ExecuteDeleteGameCommand(string[] commandParams)
    {
        string gameName = commandParams[1];
        string password = commandParams[2];

        bool gameDeleted = scoreData.DeleteGame(gameName, password);
        Console.WriteLine(gameDeleted ? "Game deleted" : "Cannot delete game");
    }
}

class Scoreboard
{
    private OrderedBag<string> gamesNames; 
    private SortedDictionary<string, Game> games;
    private Dictionary<string, string> players;

    public Scoreboard()
    {
        this.gamesNames = new OrderedBag<string>();
        this.games = new SortedDictionary<string, Game>();
        this.players = new Dictionary<string, string>();
    }

    public bool RegisterUser(string username, string password)
    {
        if (this.players.ContainsKey(username))
        {
            return false;
        }

        this.players.Add(username, password);

        return true;
    }

    public bool RegisterGame(string name, string password)
    {
        if (this.games.ContainsKey(name))
        {
            return false;
        }

        var gameToAdd = new Game(name, password);
        this.games.Add(name, gameToAdd);
        this.gamesNames.Add(name);

        return true;
    }

    public bool AddScore(
        string username,
        string userPassword,
        string gameName,
        string gamePassword,
        int score)
    {
        bool userIsValid = this.ValidateUser(username, userPassword);
        if (!userIsValid)
        {
            return false;
        }

        bool gameIsValid = this.ValidateGame(gameName, gamePassword);
        if (!gameIsValid)
        {
            return false;
        }

        this.games[gameName].AddScore(score, username);

        return true;
    }


    public string GetScoreBoard(string gameName)
    {
        string result = string.Empty;

        if (!this.games.ContainsKey(gameName))
        {
            result = string.Format("Game not found{0}", Environment.NewLine);
            return result;
        }

        result = this.games[gameName].GetTop10Highscore();

        return result;
    }

    //public string GetFirst10GamesByPrefix(string namePrefix)
    //{
    //    var matchedGames = this.gamesNames.RangeFrom(namePrefix, true);
    //    int maxR
    //    foreach (var game in matchedGames)
    //    {
    //        string gameName = game.Key;
    //        if (maxResults > 0 && gameName.StartsWith(gameNamePrefix))
    //        {
    //            maxResults--;
    //            yield return gameName;
    //        }
    //        else
    //        {
    //            yield break;
    //        }
    //    }

    //    var result = new List<string>();
    //    foreach (var game in this.games.Keys)
    //    {
    //        if (game.StartsWith(namePrefix))
    //        {
    //            result.Add(game);
    //            if (result.Count == 10)
    //            {
    //                break;
    //            }
    //        }
    //    }

    //    if (result.Count == 0)
    //    {
    //        return "No matches";
    //    }

    //    return string.Join(", ", result);
    //}

    public bool DeleteGame(string name, string password)
    {
        bool gameIsValid = this.ValidateGame(name, password);
        if (!gameIsValid)
        {
            return false;
        }

        this.games.Remove(name);
        this.gamesNames.Remove(name);

        return true;
    }

    private bool ValidateUser(string username, string password)
    {
        bool result = this.players.ContainsKey(username) &&
            this.players[username] == password;

        return result;
    }

    private bool ValidateGame(string name, string password)
    {
        bool result = this.games.ContainsKey(name) && this.games[name].Password == password;

        return result;
    }
}

class Score : IComparable<Score>
{
    public Score(int value)
    {
        this.Value = value;
    }

    public int Value { get; set; }

    public int CompareTo(Score other)
    {
        return other.Value.CompareTo(this.Value);
    }

    public override bool Equals(object obj)
    {
        Score other = obj as Score;

        return this.Value == other.Value;
    }
}

class Player
{
    public Player(string username, string password)
    {
        this.Username = username;
        this.Password = password;
    }

    public string Username { get; set; }

    public string Password { get; set; }

    public override bool Equals(object obj)
    {
        Player other = obj as Player;
        if (other == null)
        {
            return false;
        }

        return this.Username == other.Username;
    }
}

class Game : IComparable<Game>
{
    private SortedDictionary<Score, SortedDictionary<string, int>> highscore;

    public Game(string name, string password)
    {
        this.Name = name;
        this.Password = password;
        this.highscore = new SortedDictionary<Score, SortedDictionary<string, int>>();
    }

    public string Name { get; set; }

    public string Password { get; set; }

    public void AddScore(int score, string username)
    {
        var scoreToAdd = new Score(score);
        if (!this.highscore.ContainsKey(scoreToAdd))
        {
            this.highscore[scoreToAdd] = new SortedDictionary<string, int>();
        }

        if (!this.highscore[scoreToAdd].ContainsKey(username))
        {
            this.highscore[scoreToAdd][username] = 0;
        }

        this.highscore[scoreToAdd][username]++;
    }

    public string GetTop10Highscore()
    {
        var result = new StringBuilder();

        if (this.highscore.Count == 0)
        {
            result.AppendLine("No score");
            return result.ToString();
        }

        int position = 1;
        foreach (var scorePlayersPair in this.highscore)
        {
            int currentScore = scorePlayersPair.Key.Value;

            foreach (var player in scorePlayersPair.Value)
            {
                for (int i = 0; i < player.Value; i++)
                {
                    result.AppendFormat(
                        "#{0} {1} {2}{3}",
                        position,
                        player.Key,
                        currentScore,
                        Environment.NewLine);

                    position++;
                    if (position >= 11)
                    {
                        return result.ToString();
                    }
                }
            }
        }

        return result.ToString();
    }

    public int CompareTo(Game other)
    {
        return this.Name.CompareTo(other.Name);
    }

    public override bool Equals(object obj)
    {
        Game other = obj as Game;
        if (other == null)
        {
            return false;
        }

        return this.Name == other.Name;
    }
}