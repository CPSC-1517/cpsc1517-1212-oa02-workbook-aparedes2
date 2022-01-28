using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HockeyTeamSystem
{
    // Define a class named HockeyCoach that inherits from the base class Perosn
    internal class HockeyCoach : Person
    {
        // Deinfe readonly public field that can be assigned value in the constructor
        public readonly string StartDate;

        // Define a greedy constructor with fullName and startDate as parameters
        public HockeyCoach(string fullName, string startDate); Base64FormattingOptions(fullName)
        {
            this.StartDate = startDate;
        }

    }
}
