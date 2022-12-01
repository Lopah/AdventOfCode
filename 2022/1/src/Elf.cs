using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode._2022.Day1;

public struct Elf
{
    public int TotalCalories { get; private set; }
    
    public void AddItem(int calories)
    {
        TotalCalories += calories;
    }
}
