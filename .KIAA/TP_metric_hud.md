# Test Plan — Metric HUD Telemetry

## Unit Tests
- `UnitConverterTests.FeetToMeters_ReturnsExpected`
- `UnitConverterTests.KnotsToKilometersPerHour_ReturnsExpected`

## Integration Tests
- SimConnect connection and data retrieval (pending MSFS environment).

## Performance
- Conversion methods are pure and constant time; no dedicated performance tests required initially.

## Acceptance Mapping
- Unit conversions verified through tests above ensuring metric outputs.
