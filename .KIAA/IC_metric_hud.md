```csharp
namespace HudTelemetry;
public interface IFlightTelemetryService
{
    Task StartAsync(CancellationToken cancellationToken = default);
    Task StopAsync(CancellationToken cancellationToken = default);
    event EventHandler<TelemetrySample>? TelemetryUpdated;
}

public readonly record struct TelemetrySample(
    double AltitudeFeet,
    double AltitudeMeters,
    double SpeedKnots,
    double SpeedKilometersPerHour);
```

- **Threading:** callbacks occur on thread pool; UI should marshal to the main thread.
- **Errors:** connection failures should throw or surface via logging; retries left to caller.
- **Versioning:** additive changes to `TelemetrySample` fields require new record version.
