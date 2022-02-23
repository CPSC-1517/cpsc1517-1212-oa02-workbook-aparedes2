using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HockeyTeamSystem
{
    public class HockeyTeam
    {
        // Define a computed (readonly) property to TotalPoints that
        // sums the Points for each HockeyPlayers in the team
        public int TotalPoints
        {
            get
            {
                int sum = 0;
                foreach(var currentPlayer in HockeyPlayers)
                {
                    sum += currentPlayer.Points;
                }
                return sum;
            }
        }



        // Define a fully-implemented property with a backing field for the team name
        private string _teamName;   // Define a private backing filed for the property
        public string TeamName      // Define a readonly property for TeamName with a private set
        {
            get { return _teamName; }
            private set
            {
                // Validate: not null, empty string, or only whitespaces
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("HockeyTeam TeamName is required.");
                }
                // Validate: contains 5 or more characters
                if(value.Trim().Length < 5)
                {
                    throw new ArgumentException("HockeyTeam TeamName must contain 5 or more characters.");
                }
                _teamName = value;
            }
        }

        // Define an auto-inmplemented property with a private set for the team division
        public TeamDivision Division { get; private set; }

        // Define an auto-implemented readonly property for the HockeyPlayers
        public List<HockeyPlayer> HockeyPlayers { get; } = new List<HockeyPlayer>();

        // Define a readonly property for PlayerCount
        public int PlayerCount
        {
            get { return HockeyPlayers.Count; }
        }

        // Define a readonly property with a private set for the coach
        // The Coach property is knkown as Aggregation/Composition when the field/property
        // is an object
        public HockeyCoach Coach { get; private set; }

        // Define a greedy constructor that has a parameter fot the
        // TeamName, TeamDivision, and coach
#pragma warning disable 
        public HockeyTeam(string teamName, TeamDivision division, HockeyCoach coach)
        {
            TeamName = teamName;
            Division = division;
            Coach = coach;
        }

        // Define a method to add a player to the team
        public void AddPlayer(HockeyPlayer player)
        {
            // Validate: not null
            if(player == null)
            {
                throw new ArgumentException("HockeyTeam add HockeyPlayer is required.");
            }
            // Validate: number of players must be less than 23

            // Validate: player (by primary number) is not already on the team

            HockeyPlayers.Add(player);
        }
    }
}
