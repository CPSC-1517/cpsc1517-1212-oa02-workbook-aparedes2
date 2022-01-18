// See https://aka.ms/new-console-template for more information

using StructDemo01;

Resolution hdResolution = new(1920, 1080);
var cinemaSolution = hdResolution;
cinemaSolution.Width = 1048;
Console.WriteLine($"HD resolution is {hdResolution.Width} pixels to {hdResolution.Height} pixels height");
Console.WriteLine($"Cinema resolution is {cinemaSolution.Width} pixels to {cinemaSolution.Height} pixels height");



//VideoMode someVideoMode = new();