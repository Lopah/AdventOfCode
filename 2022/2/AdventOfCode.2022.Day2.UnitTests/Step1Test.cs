using System.IO;
using FluentAssertions;
using Xunit;

namespace AdventOfCode._2022.Day2.UnitTests;

[Collection("test")]
public class Step1Test
{
    [Fact]
    public void Test1()
    {
        using var fs = new FileStream(Path.Combine(Directory.GetCurrentDirectory(), "sample.txt"), FileMode.Open);
        using var sr = new StreamReader(fs);

        var decider = new Decider(sr);
        var score = decider.DecideScore();

        score.Should().Be(15);
    }
}
