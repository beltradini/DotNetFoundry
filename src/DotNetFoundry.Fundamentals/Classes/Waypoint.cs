public sealed class Waypoint
{
    public Guid Id { get; } = Guid.NewGuid();
    public string Name { get; }
    public Coordinate Coordinate { get; }
    public DateTimeOffset CreatedAt { get; } = DateTimeOffset.UtcNow;

    public Waypoint(string name, Coordinate coordinate)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException(
                "Waypoint name is required.",
                nameof(name)
            );
        }

        if (!coordinate.IsValid)
        {
            throw new ArgumentException(
                "Coordinate is invalid.",
                nameof(coordinate)
            );
        }

        Name = name;
        Coordinate = coordinate;
    }
}
