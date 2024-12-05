using AdventOfCode2024.Puzzles;
using FluentAssertions;
using Moq;

namespace AdventOfCode2024.Test;

public class PuzzleDay1Test : PuzzleTestbase
{
    [SetUp]
    public void SetUp()
    {
        FakeInput = new FakePuzzleInput(["3   4","4   3", "2   5", "1   3","3   9", "3   3"]);
        Testee = new PuzzleDay1();
    }
    
    [Test]
    public void PuzzleOne_ShouldReturn11()
    {
        Testee.PuzzleOne(FakeInput).Should().Be(11);
    }
    
    [Test]
    public void PuzzleTwo_ShouldReturn31()
    {
        Testee.PuzzleTwo(FakeInput).Should().Be(31);
    }
}