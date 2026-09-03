public sealed class Hike
{
    private readonly List<Waypoint> _waypoints = [];
    
    public Guid Id  { get; } = Guid.NewGuid();
    public Trail Trail { get; }
    public DateTimeOffset StartedAt { get; }
    public DateTimeOffset? EndedAt { get; private set; }
    
    public IReadOnlyList<Waypoint> Waypoints  => _waypoints;

    public bool IsActive => EndedAt is null;

    public Hike(Trail trail)
    {
        Trail = trail ?? throw new ArgumentNullException(nameof(trail));
        StartedAt = DateTimeOffset.UtcNow;
    }

    public void AddWaypoint(Waypoint waypoint)
    {
        if (!IsActive)
        {
            throw new InvalidOperationException(
                "Cannot add waypoint to a completed hike."
            );
        }
        
        _waypoints.Add(waypoint);
    }
    
    public void Finish()
    {
        if (!IsActive)
        {
            throw new InvalidOperationException(
                "Cannot finish a hike."
            );
        }
        
        EndedAt = DateTimeOffset.UtcNow;
    }
}
