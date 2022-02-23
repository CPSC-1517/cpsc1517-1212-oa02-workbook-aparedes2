// See https://aka.ms/new-console-template for more information
using HockeyTeamSystem;
using static System.Console;

// Define a constant for the location of players CSV data file
const string HockeyPlayerCsvFile = "../../../HockeyPlayers.csv";
// Create a new HockeyCoach instance for the team
HockeyCoach coach = new HockeyCoach("Dave Tippet", "May 28, 2019");
// Create players for the team
HockeyPlayer player1 = new HockeyPlayer("Leon Draisaitl", 29, PlayerPosition.Center, 29, 30);
HockeyPlayer player2 = new HockeyPlayer("Connor McDavid", 97, PlayerPosition.Center, 20, 37);
HockeyPlayer player3 = new HockeyPlayer("Ryan Nugent-Hopkins", 93, PlayerPosition.Center, 3, 24);
HockeyPlayer player4 = new HockeyPlayer("Jesse Puljujarvi", 13, PlayerPosition.RightWing, 10, 15);
// Create a hockey team
HockeyTeam team1 = new HockeyTeam("Edmonton Oilers", TeamDivision.Pacific, coach);
// Add players to the hockey team
team1.AddPlayer(player1);
team1.AddPlayer(player2);
team1.AddPlayer(player3);
team1.AddPlayer(player4);
WriteLine(team1);





//Person person1 = new Person("S Wu");

//// Test with valid FullName, PrimaryNumber, Position
//HockeyPlayer player1 = new("Connor McDavid", 97, PlayerPosition.Center);
//Console.WriteLine(player1); // The HockeyPlayer.ToString() will be invoked indirectly
//// Test with invalid PrimaryNumber
//try
//{
//    HockeyPlayer player = new("Connor McDavid", 0, PlayerPosition.Center);
//    Console.WriteLine("Test Case has failed");
//}
//catch (ArgumentException ex)
//{
//    Console.WriteLine(ex.Message);
//}
//try
//{
//    HockeyPlayer player = new("Connor McDavid", 100, PlayerPosition.Center);
//    Console.WriteLine("Test Case has failed");
//}
//catch (ArgumentException ex)
//{
//    Console.WriteLine(ex.Message);
//}
//// Test with null FullName
//try
//{
//    HockeyPlayer player = new(null, 97, PlayerPosition.Center);
//    Console.WriteLine("Test Case has failed");
//}
//catch (ArgumentException ex)
//{
//    Console.WriteLine(ex.Message);
//}
//// Test with empty string FullName
//try
//{
//    HockeyPlayer player = new("", 97, PlayerPosition.Center);
//    Console.WriteLine("Test Case has failed");
//}
//catch (ArgumentException ex)
//{
//    Console.WriteLine(ex.Message);
//}
//// Test with whitespace FullName
//try
//{
//    HockeyPlayer player = new("        ", 97, PlayerPosition.Center);
//    Console.WriteLine("Test Case has failed");
//}
//catch (ArgumentException ex)
//{
//    Console.WriteLine(ex.Message);
//}