using System.Collections.Generic;
using System.IO;
using System.Linq;
using FluentAssertions;
using Xunit;

namespace AdventOfCode._2022.Day3;

[Collection("tests")]
public class UnitTest1
{
    [Fact]
    public void GivenInputWithLowerPInBothCompartments_ResultsIn16()
    {
        var compartments = InputToCompartmentsHelper.InputToCompartments("vJrwpWtwJgWrhcsFMMfFFhFp");
        var ruckSack = new Rucksack(compartments);

        ruckSack.SumOfPrioritiesInBothCompartments.Should().Be(16);
    }
    
    [Fact]
    public void GivenInputWithUpperLInBothCompartments_ResultsIn38()
    {
        var compartments = InputToCompartmentsHelper.InputToCompartments("jqHRNqRjqzjGDLGLrsFMfFZSrLrFZsSL");
        var ruckSack = new Rucksack(compartments);

        var firstCompartment = "jqHRNqRjqzjGDLGL".ToCharArray();
        var secondCompartment = "rsFMfFZSrLrFZsSL".ToCharArray();

        compartments.First().Should().BeEquivalentTo(firstCompartment);
        compartments.Last().ToArray().Should().BeEquivalentTo(secondCompartment);

        ruckSack.SumOfPrioritiesInBothCompartments.Should().Be(38);
    }

    [Fact]
    public void GivenTestSampleInput_CorrectlyCalculates157()
    {
        using var fs = new FileStream(Path.Combine(Directory.GetCurrentDirectory(), "sample.txt"), FileMode.Open);
        using var sr = new StreamReader(fs);

        var totalSum = 0;

        while (!sr.EndOfStream)
        {
            var input = sr.ReadLine();
            var compartments = InputToCompartmentsHelper.InputToCompartments(input!);
            var ruckSack = new Rucksack(compartments);

            totalSum += ruckSack.SumOfPrioritiesInBothCompartments;
        }

        totalSum.Should().Be(157);
    }
}
