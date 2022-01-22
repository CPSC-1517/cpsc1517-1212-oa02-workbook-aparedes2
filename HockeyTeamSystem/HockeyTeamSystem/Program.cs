// See https://aka.ms/new-console-template for more information
using HockeyTeamSystem;

// Test with a valid FullName, PrimaryNumber
HockeyPlayer player2 = new("Connor McDavid", 97, PlayerPosition.Center);
Console.WriteLine(player2); // The HockeyPlayer.ToString() wil be invoked indirectly
try
{
    HockeyPlayer player = new("Connor McDavid", 0, PlayerPosition.Center);
    Console.WriteLine("Test case has failed");
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}
try
{
    HockeyPlayer player = new("Connor McDavid", 100, PlayerPosition.Center);
    Console.WriteLine("Test case has failed");
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}
// Test with empty string for FullName
try
{
    HockeyPlayer player = new("", 0, PlayerPosition.Center);
    Console.WriteLine("Test case has failed");
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}
// Test with null FullName
try
{
    HockeyPlayer player = new(null, 0, PlayerPosition.Center);
    Console.WriteLine("Test case has failed");
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}
// Test with whitespace for FullName
try
{
    HockeyPlayer player = new(" ", 0, PlayerPosition.Center);
    Console.WriteLine("Test case has failed");
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}