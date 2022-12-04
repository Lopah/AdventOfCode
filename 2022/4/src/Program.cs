using System;
using System.IO;
using System.Linq;

namespace AdventOfCode._2022.Day4;

public class Program
{
    public static int Main()
    {
        using var fs = new FileStream(Path.Combine(Directory.GetCurrentDirectory(), "Input.txt"), FileMode.Open);
        using var sr = new StreamReader(fs);

        var completeIntersect = 0;
        var partialIntersect = 0;

        while (!sr.EndOfStream)
        {
            var input = sr.ReadLine()!.Split(',');

            var firstDuty = new ElfDuty(input[0]);
            var secondDuty = new ElfDuty(input[1]);

            if (firstDuty.Floors.Intersect(secondDuty.Floors).Count() == firstDuty.Floors.Count
                || secondDuty.Floors.Intersect(firstDuty.Floors).Count() == secondDuty.Floors.Count)
            {
                completeIntersect++;
            }

            if (firstDuty.Floors.Intersect(secondDuty.Floors).Count() != 0)
            {
                partialIntersect++;
            }
        }
        
        Console.WriteLine(completeIntersect);
        Console.WriteLine(partialIntersect);
        return 0;
    }
}