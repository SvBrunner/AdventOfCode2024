using AdventOfCode2024.Puzzles;
using FluentAssertions;
using Moq;

namespace AdventOfCode2024.Test;

public class PuzzleDay1Test : PuzzleTestbase
{
    [SetUp]
    public void SetUp()
    {
        _fakeInput = new FakePuzzleInput(["3   4","4   3", "2   5", "1   3","3   9", "3   3"]);
        _testee = new PuzzleDay1();
    }
    
    [Test]
    public void PuzzleOne_ShouldReturn11()
    {
        _testee.PuzzleOne(_fakeInput).Should().Be(11);
    }
    
    [Test]
    public void PuzzleTwo_ShouldReturn31()
    {
        _testee.PuzzleTwo(_fakeInput).Should().Be(31);
    }
}