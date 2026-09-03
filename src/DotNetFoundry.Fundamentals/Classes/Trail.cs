public sealed class Trail
{
    public Guid Id { get; }
    public string Name { get; }
    public TrailDifficulty Difficulty { get; }
    public double DistanceKm { get; }
    public int ElevationGainMeters { get; }
    public Coordinate StartCoordinate { get; }

    public Trail(
        string name,
        TrailDifficulty difficulty,
        double distanceKm,
        int elevationGainMeters,
        Coordinate startCoordinate)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException(
                "Trail name is required.",
                nameof(name)
            );
        }

        if (distanceKm <= 0)
        {
            throw new ArgumentOutOfRangeException(
                nameof(distanceKm),
                "Distance must be greater than zero."
            );
        }

        if (!startCoordinate.IsValid)
        {
            throw new ArgumentException(
                "Start coordinate is invalid.",
                nameof(startCoordinate)
            );
        }

        Id = Guid.NewGuid();
        Name = name;
        Difficulty = difficulty;
        DistanceKm = distanceKm;
        ElevationGainMeters = elevationGainMeters;
        StartCoordinate = startCoordinate;
    }
}
