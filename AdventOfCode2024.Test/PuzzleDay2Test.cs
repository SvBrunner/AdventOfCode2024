using AdventOfCode2024.Puzzles;
using FluentAssertions;
using Moq;

namespace AdventOfCode2024.Test;

public class PuzzleDay2Test : PuzzleTestbase
{ 
    [SetUp]
    public void SetUp()
    {
        _fakeInput = new FakePuzzleInput(["7 6 4 2 1", "1 2 7 8 9", "9 7 6 2 1", "1 3 2 4 5", "8 6 4 4 1", "1 3 6 7 9"]);
        _testee = new PuzzleDay2();
    }
    
    [Test]
    public void PuzzleOne_ShouldReturn2()
    {
        _testee.PuzzleOne(_fakeInput).Should().Be(2);
    }
    
    [Test]
    public void PuzzleTwo_ShouldReturn4()
    {
        _testee.PuzzleTwo(_fakeInput).Should().Be(4);
    }
    
}