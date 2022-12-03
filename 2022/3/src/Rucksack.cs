using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode._2022.Day3;

public class Rucksack
{
    public int SumOfPrioritiesInBothCompartments { get; }
    
    public ICollection<char> ItemsInBothCompartments { get; }

    public Rucksack(ICollection<char[]> compartments)
    {
        if (compartments.Count != 2)
        {
            throw new ArgumentException();
        }

        var priorities = compartments.First().Select(CharToPriorityHelper.GetPriorityFromChar).ToList();
        var inBoth = new List<int>();

        foreach (var c in compartments.Last())
        {
            var priority = CharToPriorityHelper.GetPriorityFromChar(c);
            if (priorities.Contains(priority))
            {
                inBoth.Add(priority);
            }
        }

        ItemsInBothCompartments = compartments.SelectMany(e => e.Select(x => x)).ToArray();
        SumOfPrioritiesInBothCompartments = inBoth.Distinct().Sum();
    }
}
