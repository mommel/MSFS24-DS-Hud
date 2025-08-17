namespace HudTelemetry;

/// <summary>
/// Provides utility methods for unit conversion.
/// </summary>
public static class UnitConverter
{
    private const double FeetToMetersFactor = 0.3048;
    private const double KnotsToKilometersPerHourFactor = 1.852;

    /// <summary>Converts feet to meters.</summary>
    public static double FeetToMeters(double feet) => feet * FeetToMetersFactor;

    /// <summary>Converts knots to kilometers per hour.</summary>
    public static double KnotsToKilometersPerHour(double knots) => knots * KnotsToKilometersPerHourFactor;
}
