using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using AdventOfCode._2022.Day1;

using var fs = new FileStream(Path.Combine(Directory.GetCurrentDirectory(), "Input.txt"), FileMode.Open);
using var sr = new StreamReader(fs);

var elves = new List<Elf>();
var currentElf = new Elf();

while (!sr.EndOfStream)
{
    var item = sr.ReadLine();
    if (string.IsNullOrEmpty(item))
    {
        elves.Add(currentElf);
        currentElf = new Elf();
        continue;
    }
    currentElf.AddItem(new Item(int.Parse(item)));
}

var sortedElves = elves.OrderByDescending(e => e.TotalCalories).ToList();

Console.WriteLine(sortedElves.First().TotalCalories);

Console.WriteLine(sortedElves.Take(3).Sum(e => e.TotalCalories));