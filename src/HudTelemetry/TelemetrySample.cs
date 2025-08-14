namespace HudTelemetry;

/// <summary>
/// Represents a snapshot of flight telemetry values.
/// </summary>
public readonly record struct TelemetrySample(
    double AltitudeFeet,
    double AltitudeMeters,
    double SpeedKnots,
    double SpeedKilometersPerHour);
