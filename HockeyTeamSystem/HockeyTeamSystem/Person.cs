using System.Text.RegularExpressions; // for Regex class

namespace HockeyTeamSystem
{
    public class Person
    {
        // Define an auto-implemented property with a private set for the FullName
        // A private set property cannot be assigned a value
        // in the constructor or an instance method
        public string FullName { get; private set; }

        // Define a greedy constructor that takes a fullName as parameter
        // Constructors are used to createe instance of an object
        // and to assign meaningful values to the fields/prooperties of the class
        public Person(string fullName)
        {
            // Validatep: not null, empty, or has whitespace
            if (string.IsNullOrWhiteSpace(fullName))
            {
                throw new ArgumentNullException("Person Fullname is required.");
            }

            // Validate: only a-z and 1 or more space character
                // @""is literal string where there is no meaning to any of character
                // ^ start of input and $ end of input
                // [] range of characters
                // {3,} at least 3 characters
                // {,2} up to 2 spaces
            var fullNameCheck = new Regex(@"^[a-zA-Z ]{3,}$");
            if (fullNameCheck.IsMatch(fullName) == false)
            {
                throw new ArgumentException("Person FullName must contain at least 3 characters.");
            }


            this.FullName = fullName.Trim();
        }
    }
}
