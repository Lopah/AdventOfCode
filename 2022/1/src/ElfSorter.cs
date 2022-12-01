using System.Collections.Generic;

namespace AdventOfCode._2022.Day1;

public class ElfSorter : IComparer<KeyValuePair<int, Elf>>
{
    public void Insert(List<KeyValuePair<int, Elf>> sortedList, KeyValuePair<int, Elf> newItem)
    {
        var newIndex = sortedList.BinarySearch(newItem, this);
        if (newIndex < 0)
        {
            sortedList.Insert(~newIndex, newItem);
            return;
        }

        while (newIndex < sortedList.Count && (sortedList[newIndex].Key == newItem.Key))
        {
            newIndex++;
        }

        sortedList.Insert(newIndex, newItem);
    }

    /// <summary>Compares two objects and returns a value indicating whether one is less than, equal to, or greater than the other.</summary>
    /// <param name="x">The first object to compare.</param>
    /// <param name="y">The second object to compare.</param>
    /// <returns>A signed integer that indicates the relative values of <paramref name="x" /> and <paramref name="y" />, as shown in the following table.
    /// <list type="table"><listheader><term> Value</term><description> Meaning</description></listheader><item><term> Less than zero</term><description><paramref name="x" /> is less than <paramref name="y" />.</description></item><item><term> Zero</term><description><paramref name="x" /> equals <paramref name="y" />.</description></item><item><term> Greater than zero</term><description><paramref name="x" /> is greater than <paramref name="y" />.</description></item></list></returns>
    public int Compare(KeyValuePair<int, Elf> x, KeyValuePair<int, Elf> y)
    {
        return x.Key > y.Key ? -1 : x.Key == y.Key ? 0 : 1;
    }
}
