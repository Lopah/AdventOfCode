namespace AdventOfCode._2022.Day2;

public static class OpponentPick
{
    public const string Rock = "A";
    public const string Paper = "B";
    public const string Scissors = "C";

    public static Pick DeterminePick(string value) => value switch
    {
        Rock => Pick.Rock,
        Paper => Pick.Paper,
        Scissors => Pick.Scissors,
        _ => throw new ArgumentOutOfRangeException(nameof(value), value, null)
    };
}
