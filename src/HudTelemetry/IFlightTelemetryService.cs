using System;
using System.Threading;
using System.Threading.Tasks;

namespace HudTelemetry;

/// <summary>
/// Provides flight telemetry data updates.
/// </summary>
public interface IFlightTelemetryService
{
    /// <summary>Starts the telemetry service.</summary>
    Task StartAsync(CancellationToken cancellationToken = default);

    /// <summary>Stops the telemetry service.</summary>
    Task StopAsync(CancellationToken cancellationToken = default);

    /// <summary>Raised when new telemetry data is received.</summary>
    event EventHandler<TelemetrySample>? TelemetryUpdated;
}
