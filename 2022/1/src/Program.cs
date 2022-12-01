using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using AdventOfCode._2022.Day1;

using var fs = new FileStream(Path.Combine(Directory.GetCurrentDirectory(), "Input.txt"), FileMode.Open);
using var sr = new StreamReader(fs);

var elves = new List<KeyValuePair<int, Elf>>();
var sorter = new ElfSorter();
var currentElf = new Elf();

while (!sr.EndOfStream)
{
    var item = sr.ReadLine();
    if (string.IsNullOrEmpty(item))
    {
        sorter.Insert(elves, new KeyValuePair<int, Elf>(currentElf.TotalCalories, currentElf));
        currentElf = new Elf();
        continue;
    }

    currentElf.AddItem(int.Parse(item));
}

Console.WriteLine(elves.First().Value.TotalCalories);

Console.WriteLine(elves.Take(3).Sum(e => e.Key));
