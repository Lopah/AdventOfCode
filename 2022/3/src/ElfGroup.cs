using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode._2022.Day3;

public class ElfGroup
{
    public int BadgeNumber { get; }
    public ElfGroup(ICollection<Rucksack> rucksacks)
    {
        if (rucksacks.Count != 3)
        {
            throw new ArgumentException();
        }

        var items = rucksacks.Select(e => e.ItemsInBothCompartments).ToList();

        var common = items[0].Intersect(items[1]).Intersect(items[2]).ToList();

        var foundBadgeNumber = common.Any();

        if (!foundBadgeNumber)
        {
            BadgeNumber = 0;
            return;
        }

        BadgeNumber = CharToPriorityHelper.GetPriorityFromChar(common.First());

    }
}
