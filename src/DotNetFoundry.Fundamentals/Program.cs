string trailName = "Chipinque";
string? description = null;
TrailDifficulty difficulty = TrailDifficulty.Moderate;
double distanceKm = 8.7;
int elevationMeters = 630;
bool hasGps = true;
double temperatureCelsius = 22.5;
var estimatedDurationHours = 2.5;
Guid trailId = Guid.NewGuid();
var averageSpeed = CalculateAverageSpeed(distanceKm, estimatedDurationHours); // CalculateAverageSpeed is a static method

Coordinate chipinqueEntrance = new(25.1234, -100.5678);

Trail chipinque = new(
    name: "Chipinque Circuit",
    difficulty: TrailDifficulty.Moderate,
    distanceKm: 8.7,
    elevationGainMeters: 630,
    startCoordinate: chipinqueEntrance
);

Hike currentHike = new(chipinque);

Waypoint viewpoint = new Waypoint(
    "Mirador Principal",
    new Coordinate(25.5942, - 100.3498)
);

currentHike.AddWaypoint(viewpoint);

Console.WriteLine($"Active hike: {currentHike.IsActive}");
Console.WriteLine($"Waypoints: {currentHike.Waypoints.Count}");

currentHike.Finish();

Console.WriteLine($"Hike finished: {!currentHike.IsActive}");
Console.WriteLine($"Finished at: {currentHike.EndedAt}");

Console.WriteLine($"{chipinque.Name}: {chipinque.DistanceKm} km");

Console.WriteLine($"Trail Entrance Coordinates: Latitude {chipinqueEntrance.Latitude}, Longitude {chipinqueEntrance.Longitude}");
bool isCoordinateValid = chipinqueEntrance.IsValid;
Console.WriteLine($"Is the coordinate valid? {isCoordinateValid}");

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

static double CalculateAverageSpeed(double distanceKm, double durationHours)
{
    if (durationHours <= 0)
    {
        return 0;
    }

    return distanceKm / durationHours;
}

public enum TrailDifficulty
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
