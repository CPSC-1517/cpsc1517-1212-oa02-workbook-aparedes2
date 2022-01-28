using System.Text.RegularExpressions;   // for Regex class

namespace HockeyTeamSystem
{
    public  class Person
    {
        // Define an auto-implement property with a private set
        // for the FullName
        // A provate set property cannot be assigned a value
        // in the constructor or an instance method
        public string FullName { get; private set; }

        // Define a greedy constructor that takes a fullName as parameter
        // Constructors are used to create instance of an object
        // and to assign meaningful values to the fields/ properties of the class.
        public Person(string fullName)
        {
            // Validate that the fullName parameter is not null, whitespaces,
            // or an empty string.
            if (string.IsNullOrWhiteSpace(fullName))
            {
                throw new ArgumentNullException("Person fullName is required");
            }

            // Validate that the fullName parameter constains only letters a-z 
            // and one or more soace characters

            // @"" is literal string where there is no meaning to any of the characters
            // ^ start of the input
            // $ end of input
            // [] range of character
            // {3,} at least 3
            // {,2} up to 2
            var fullNameCheck = new Regex(@"^[a-zA-Z]{3,}$");
            if (fullNameCheck.IsMatch(fullName) == false)
            {
                throw new ArgumentException("Person FullName must contain at least 3 characters")
            }

            // The "this" keyword refers to the current object and it is 
            // used to to access a field of property of the current object
            this.FullName = fullName.Trim();

        }

    }
}
