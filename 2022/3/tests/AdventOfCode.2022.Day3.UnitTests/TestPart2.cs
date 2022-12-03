using System.Collections.Generic;
using System.IO;
using FluentAssertions;
using Xunit;

namespace AdventOfCode._2022.Day3;

[Collection("tests")]
public class TestPart2
{
    [Fact]
    public void GivenGroupWithAllContainingLowerCaseR_ReturnsItCorrectly()
    {
        var ruckSack1 = new Rucksack(InputToCompartmentsHelper.InputToCompartments("vJrwpWtwJgWrhcsFMMfFFhFp"));
        var ruckSack2 = new Rucksack(InputToCompartmentsHelper.InputToCompartments("jqHRNqRjqzjGDLGLrsFMfFZSrLrFZsSL"));
        var ruckSack3 = new Rucksack(InputToCompartmentsHelper.InputToCompartments("PmmdzqPrVvPwwTWBwg"));

        var group = new ElfGroup(
            new List<Rucksack>()
            {
                ruckSack1,
                ruckSack2,
                ruckSack3
            });

        group.BadgeNumber.Should().Be(CharToPriorityHelper.GetPriorityFromChar('r'));
    }
    
    [Fact]
    public void GivenGroupWithAllContainingUpperCaseZ_ReturnsItCorrectly()
    {
        var ruckSack1 = new Rucksack(InputToCompartmentsHelper.InputToCompartments("wMqvLMZHhHMvwLHjbvcjnnSBnvTQFn"));
        var ruckSack2 = new Rucksack(InputToCompartmentsHelper.InputToCompartments("ttgJtRGJQctTZtZT"));
        var ruckSack3 = new Rucksack(InputToCompartmentsHelper.InputToCompartments("CrZsJsPPZsGzwwsLwLmpwMDw"));

        var group = new ElfGroup(
            new List<Rucksack>()
            {
                ruckSack1,
                ruckSack2,
                ruckSack3
            });

        group.BadgeNumber.Should().Be(CharToPriorityHelper.GetPriorityFromChar('Z'));
    }
}
