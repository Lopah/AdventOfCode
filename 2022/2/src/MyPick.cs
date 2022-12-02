namespace AdventOfCode._2022.Day2;

public static class MyPick
{
    public const string Rock = "X";
    public const string Paper = "Y";
    public const string Scissors = "Z";
    
    public static Pick DeterminePick(string value) => value switch
    {
        Rock => Pick.Rock,
        Paper => Pick.Paper,
        Scissors => Pick.Scissors,
        _ => throw new ArgumentOutOfRangeException(nameof(value), value, null)
    };
}
