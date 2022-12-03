using System.Collections.Generic;

namespace AdventOfCode._2022.Day3;

public class InputToCompartmentsHelper
{
    public static ICollection<char[]> InputToCompartments(string input)
    {
        var half = (input.Length / 2);

        var first = input.Substring(0, half).ToCharArray();
        var second = input.Substring(half, half).ToCharArray();

        return new[] { first, second };
    }
}
