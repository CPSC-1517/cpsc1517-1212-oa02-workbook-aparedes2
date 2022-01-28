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
        // sum the Points for each HockeyPlayer in the team
        public int TotalPoints
        {
            get
            {
                int sum = 0;
                foreach (var currentPlayer in HockeyPlayers)
                {
                    sum += currentPlayer.Points;
                }
                return sum;
            }
        }

        // Define a fully-implemented property with a backing fields for the team name
        private string _teamName;   // Define a private backing field for property
        public string TeamName      // Define a readonly property for TeamName with a private set
        {
            get { return _teamName; }
            private set
            {
                // Validate the new team name is not null, empty, or a whitespace
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("HockeyTeam TeamName is required.");
                }
                // Validate the new team name contains 5 or more characters
                if (value.Trim().Length < 5)
                {
                    throw new ArgumentException("HockeyTeam TeamName must contain 5 or more characters.");
                }
                _teamName = value;
            }
        }

        // Define a auto-implemented property with a private set for Division
        public TeamDivision Division { get; private set; }

        // Define a auto-implemented readonly property for the HockeyPlayers
        public List<HockeyPlayer> HockeyPlayers { get; } = new List<HockeyPlayer>();

        // Define a read-only property for PlayerCount
        public int PlayerCount
        {
            get { return HockeyPlayers.Count; }
        }

        // Define a readonly property with a provate set for teh Coach
        // The Coach property is known as  Aggregation/Composition
        // when the field/property is an object
        public HockeyCoach Coach { get; private set; }

        // Define a gredy constructor that has a parameter for the
        // team name, team division, and coach
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
            // validate that the player is not null
            if (player == null)
            {
                throw new ArgumentNullException("HockeyTeam add HockeyPlayer is required.");
            }
            // Validate that the number of players is less than 23

            // Validates that player (by primary number) is not already on the team

            HockeyPlayers.Add(player);
        }

    }
}
