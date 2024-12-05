using AdventOfCode2024.Puzzles;
using FluentAssertions;
using Moq;

namespace AdventOfCode2024.Test;

public class PuzzleDay1Test : PuzzleTestbase
{
    [SetUp]
    public void SetUp()
    {
        _mockInput = new Mock<Input>("TestDay.input");
        _mockInput.SetupGet(m => m.Lines).Returns(new[] {"3   4","4   3", "2   5", "1   3","3   9", "3   3"  });
        _testee = new PuzzleDay1();
    }
    
    [Test]
    public void PuzzleOne_ShouldReturn11()
    {
        _testee.PuzzleOne(_mockInput.Object).Should().Be(11);
    }
    
    [Test]
    public void PuzzleTwo_ShouldReturn31()
    {
        _testee.PuzzleTwo(_mockInput.Object).Should().Be(31);
    }
}