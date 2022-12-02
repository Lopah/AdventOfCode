using System.Reflection;
using AdventOfCode._2022.Day2;

public class Program
{
    public static int Main(string[] args)
    {
        var fs = new FileStream(Path.Combine(Directory.GetCurrentDirectory(), "Input.txt"), FileMode.Open);
        var sr = new StreamReader(fs);
        var decider = new Decider(sr);
        Console.WriteLine(decider.DecideScore());
        decider.Dispose();

        fs = new FileStream(Path.Combine(Directory.GetCurrentDirectory(), "Input.txt"), FileMode.Open);
        sr = new StreamReader(fs);
        decider = new Decider(sr);

        Console.WriteLine(decider.DecideScoreStrategy());

        return 0;
    }
}