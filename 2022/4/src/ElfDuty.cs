using System.Collections.Generic;

namespace AdventOfCode._2022.Day4;

public class ElfDuty
{
    public ICollection<int> Floors { get; }

    public ElfDuty(string input)
    {
        Floors = new List<int>();
        var floorsMinMax =input.Split('-');

        var floorsMin = int.Parse(floorsMinMax[0]);
        var floorsMax = int.Parse(floorsMinMax[1]);

        for (var floor = floorsMin; floor <= floorsMax; floor++)
        {
            Floors.Add(floor);
        }

    }
}
