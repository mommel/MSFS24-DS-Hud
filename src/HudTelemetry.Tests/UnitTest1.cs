using Xunit;

namespace HudTelemetry.Tests;

public class UnitConverterTests
{
    [Theory]
    [InlineData(0, 0)]
    [InlineData(1000, 304.8)]
    public void FeetToMeters_ReturnsExpected(double feet, double expectedMeters)
    {
        var actual = UnitConverter.FeetToMeters(feet);
        Assert.Equal(expectedMeters, actual, 3);
    }

    [Theory]
    [InlineData(0, 0)]
    [InlineData(100, 185.2)]
    public void KnotsToKilometersPerHour_ReturnsExpected(double knots, double expectedKmh)
    {
        var actual = UnitConverter.KnotsToKilometersPerHour(knots);
        Assert.Equal(expectedKmh, actual, 3);
    }
}
