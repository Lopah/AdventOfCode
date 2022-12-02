namespace AdventOfCode._2022.Day2;

public class MyOutcome
{
    public const string Loss = "X";
    public const string Draw = "Y";
    public const string Win = "Z";
    
    public static Strategy DetermineStrategy(string value) => value switch
    {
        Loss => Strategy.Loss,
        Draw => Strategy.Draw,
        Win => Strategy.Win,
        _ => throw new ArgumentOutOfRangeException(nameof(value), value, null)
    };
}
