using System;
using System.Collections.Generic;
using System.IO;

namespace AdventOfCode._2022.Day3;

public class Program
{
    public static int Main()
    {
        using var fs = new FileStream(Path.Combine(Directory.GetCurrentDirectory(), "Input.txt"), FileMode.Open);
        using var sr = new StreamReader(fs);

        var totalSum = 0;
        var rucksacks = new List<Rucksack>();

        while (!sr.EndOfStream)
        {
            var input = sr.ReadLine();

            var compartments = InputToCompartmentsHelper.InputToCompartments(input);

            var ruckSack = new Rucksack(compartments);

            totalSum += ruckSack.SumOfPrioritiesInBothCompartments;
            
            rucksacks.Add(ruckSack);
        }

        var position = 0;
        var sumOfBadges = 0;

        while (true)
        {
            if (position + 3 > rucksacks.Count)
            {
                break;
            }
            var grouping = rucksacks.GetRange(position, 3);
            position += 3;
            var elfGroup = new ElfGroup(grouping);
            sumOfBadges += elfGroup.BadgeNumber;
        }
        
        Console.WriteLine(totalSum);
        Console.WriteLine(sumOfBadges);

        return 0;
    }
}