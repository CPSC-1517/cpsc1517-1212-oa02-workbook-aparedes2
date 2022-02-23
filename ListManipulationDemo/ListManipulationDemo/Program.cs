// See https://aka.ms/new-console-template for more information
using ListManipulationDemo;

Console.WriteLine("Hello, World!");

// Create a new custom class named HockeyPlayer with
// auto-implemented properties for:
//  1) player name
//  2) games played
//  3) goals
//  4) assists
// a derived property to compute the 
//  5) points (goals + assists)


// Create a new custom class named HockeyName with
// auto-implemented properties for:
//  1) team name
// a read only property for a list of hockey player
//  2) players
// In the constructor add 8 players to the team

// Create a new HockeyTeam instance
HockeyTeam hockeyTeam = new HockeyTeam("Edmonton Oilers");

foreach (var players in hockeyTeam.Players)
{
    Console.WriteLine(players);
}
Console.WriteLine("\nPlayers Remaining:");
var splitTeam = hockeyTeam.RemovePlayersAt(5);
foreach (var players in hockeyTeam.Players)
{
    Console.WriteLine(players);
}
Console.WriteLine("\nPlayers Removed:");
foreach (var players in splitTeam)
{
    Console.WriteLine(players);
}

HockeyTeam naitHockeyTeam = new HockeyTeam("NAIT OOKS");
// Remove players from the team after the player name
var demotedPlayers = naitHockeyTeam.RemovePlayersByName("Zach Hyman");
// There should only be 3 players left in the team
Console.WriteLine("\nPlayers left in the team after Zach Hyman");
foreach (var player in naitHockeyTeam.Players)
{
    Console.WriteLine(player);
}
// There should be 5 players demoted to Nait OOKs
Console.WriteLine("\nPlayers demoted in the team after Zach Hyman");
foreach (var player in demotedPlayers)
{
    Console.WriteLine(player);
}

// Serialize (Write) all the Hockey players left after removing players at index to a CSV file
// Serialize (Write) all the hockey players removed started at index 5 to a JSON file
// Deserialize (Read) all the hockey players read from the CSV file
// Deserialize (Read) all the hockey players removed from the JSON file

// Serialize the hockeyteam and deserialize the hockey team to a JSON file
