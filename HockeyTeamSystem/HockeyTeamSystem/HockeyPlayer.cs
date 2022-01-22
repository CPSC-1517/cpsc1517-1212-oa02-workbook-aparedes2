using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HockeyTeamSystem
{
    public class HockeyPlayer
    {
        private string _fullName;
        private int _primaryNumber;
        public PlayerPosition Position { get; private set; } // called autoimplimented property
        public int PrimaryNumber
        {
            get { return _primaryNumber; }
            private set
            {
                // Validate PrimaryNumber is  between 1 and 99
                if (value < 1 || value > 99)
                {
                    throw new ArgumentException("HockeyPlayer PrimaryNumber must be between 1 and 99.");
                }
                _primaryNumber = value;
            }
        }

        // Define a fully-implemented property for FullName
        // with readonly information.
        // Validate FullName is not null, empty, and not a whitespace.
        // Validate FullName Contains a minimum of 3 characters
        public string FullName
        {
            get { return _fullName; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("HockeyPayer FullName must not be null, empty, and not a whitespace.");
                }
                if (value.Trim().Length <= 2)
                {
                    throw new ArgumentException("HockeyPlayer FullName must be morethan 3 characters.");
                }
                _fullName = value.Trim();
            }
        }

        // Define a greedy constructor
        public HockeyPlayer(string fullName, int primaryNumber, PlayerPosition position)
        {
            FullName = fullName;
            PrimaryNumber = primaryNumber;
            Position = position;
        }
        // Override the ToStirch() method to return a csv
        public override string ToString()
        {
            return $"{FullName}, {PrimaryNumber}, {Position}";
        }
    }
}
