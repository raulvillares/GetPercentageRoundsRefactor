using Xunit;

namespace PercentageRoundsRefactor;

public static class PercentageRoundsGenerator
{
    public static string Generate(double percentage)
    {
        if (percentage == 0)
            return "⚪⚪⚪⚪⚪⚪⚪⚪⚪⚪";
        if (percentage > 0.0 && percentage <= 0.1)
            return "🔵⚪⚪⚪⚪⚪⚪⚪⚪⚪";
        if (percentage > 0.1 && percentage <= 0.2)
            return "🔵🔵⚪⚪⚪⚪⚪⚪⚪⚪";
        if (percentage > 0.2 && percentage <= 0.3)
            return "🔵🔵🔵⚪⚪⚪⚪⚪⚪⚪";
        if (percentage > 0.3 && percentage <= 0.4)
            return "🔵🔵🔵🔵⚪⚪⚪⚪⚪⚪";
        if (percentage > 0.4 && percentage <= 0.5)
            return "🔵🔵🔵🔵🔵⚪⚪⚪⚪⚪";
        if (percentage > 0.5 && percentage <= 0.6)
            return "🔵🔵🔵🔵🔵🔵⚪⚪⚪⚪";
        if (percentage > 0.5 && percentage <= 0.7)
            return "🔵🔵🔵🔵🔵🔵🔵⚪⚪⚪";
        if (percentage > 0.6 && percentage <= 0.8)
            return "🔵🔵🔵🔵🔵🔵🔵🔵⚪⚪";
        if (percentage > 0.7 && percentage <= 0.9)
            return "🔵🔵🔵🔵🔵🔵🔵🔵🔵⚪";
        return "🔵🔵🔵🔵🔵🔵🔵🔵🔵🔵";
    }
}

public class PercentageRoundsGeneratorShould

{
    [Theory]
    [InlineData(0, "⚪⚪⚪⚪⚪⚪⚪⚪⚪⚪")]
    [InlineData(0.05, "🔵⚪⚪⚪⚪⚪⚪⚪⚪⚪")]
    [InlineData(0.1, "🔵⚪⚪⚪⚪⚪⚪⚪⚪⚪")]
    [InlineData(0.2, "🔵🔵⚪⚪⚪⚪⚪⚪⚪⚪")]
    [InlineData(0.25, "🔵🔵🔵⚪⚪⚪⚪⚪⚪⚪")]
    [InlineData(0.3, "🔵🔵🔵⚪⚪⚪⚪⚪⚪⚪")]
    [InlineData(0.35, "🔵🔵🔵🔵⚪⚪⚪⚪⚪⚪")]
    [InlineData(0.4, "🔵🔵🔵🔵⚪⚪⚪⚪⚪⚪")]
    [InlineData(0.45, "🔵🔵🔵🔵🔵⚪⚪⚪⚪⚪")]
    [InlineData(0.5, "🔵🔵🔵🔵🔵⚪⚪⚪⚪⚪")]
    [InlineData(0.55, "🔵🔵🔵🔵🔵🔵⚪⚪⚪⚪")]
    [InlineData(0.6, "🔵🔵🔵🔵🔵🔵⚪⚪⚪⚪")]
    [InlineData(0.65, "🔵🔵🔵🔵🔵🔵🔵⚪⚪⚪")]
    [InlineData(0.7, "🔵🔵🔵🔵🔵🔵🔵⚪⚪⚪")]
    [InlineData(0.75, "🔵🔵🔵🔵🔵🔵🔵🔵⚪⚪")]
    [InlineData(0.8, "🔵🔵🔵🔵🔵🔵🔵🔵⚪⚪")]
    [InlineData(0.85, "🔵🔵🔵🔵🔵🔵🔵🔵🔵⚪")]
    [InlineData(0.9, "🔵🔵🔵🔵🔵🔵🔵🔵🔵⚪")]
    [InlineData(0.95, "🔵🔵🔵🔵🔵🔵🔵🔵🔵🔵")]
    [InlineData(1, "🔵🔵🔵🔵🔵🔵🔵🔵🔵🔵")]
    [InlineData(50, "🔵🔵🔵🔵🔵🔵🔵🔵🔵🔵")]
    public void GenerateProperRepresentation(double percentage, string expectedRepresentation)
    {
        var result = PercentageRoundsGenerator.Generate(percentage);
        Assert.Equal(result, expectedRepresentation);
    }

}