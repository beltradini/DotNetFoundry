string trailName = "Chipinque";
string? description = null;
TrailDifficulty difficulty = TrailDifficulty.Moderate;
double distanceKm = 8.7;
int elevationMeters = 630;
bool hasGps = true;
double temperatureCelsius = 22.5;
var estimatedDurationHours = 2.5;
Guid trailId = Guid.NewGuid();

double averageSpeed = CalculateAverageSpeed(distanceKm, estimatedDurationHours);

Console.WriteLine($"Trail: {trailName}");
Console.WriteLine($"ID: {trailId}");
Console.WriteLine($"Distance: {distanceKm} km");
Console.WriteLine($"Difficulty: {difficulty}");
Console.WriteLine($"Elevation: {elevationMeters} m");
Console.WriteLine($"GPS available: {hasGps}");
Console.WriteLine($"Temperature: {temperatureCelsius} °C");
Console.WriteLine($"Estimated Duration: {estimatedDurationHours} hours");
Console.WriteLine($"Average Speed: {averageSpeed} km/h");
Console.WriteLine(
$"Description: {(description ?? "No description available.")}"
);
Console.WriteLine($"Trail Type: {TrailType.Loop}");

enum TrailDifficulty
{
    Easy,
    Moderate,
    Hard,
    Expert
}

enum TrailType
{
    Loop,
    OutAndBack,
    PointToPoint
}
