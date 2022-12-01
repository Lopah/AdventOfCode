using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode._2022.Day1;

public struct Elf
{
    public ICollection<Item> Items { get; }

    public Elf()
    {
        Items = new List<Item>();
    }


    public void AddItem(Item item)
    {
        Items.Add(item);
    }

    public decimal TotalCalories => Items.Sum(e => e.Calories);
}
