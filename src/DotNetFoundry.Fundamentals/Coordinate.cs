public readonly record struct Coordinate(double Latitude, double Longitude)
{
    public bool IsValid =>
        Latitude is >= -90 and <= 90 &&
        Longitude is >= -180 and <= 180;
}
