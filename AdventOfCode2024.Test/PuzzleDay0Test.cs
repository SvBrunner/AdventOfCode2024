using AdventOfCode2024.Puzzles;
using FluentAssertions;
using Moq;

namespace AdventOfCode2024.Test;

public class PuzzleDay0Test : PuzzleTestbase
{
    [SetUp]
    public void SetUp()
    {
        _fakeInput = new FakePuzzleInput(["1", "2", "3", "4"]);
        _testee = new PuzzleDay0();
    }

    [Test]
    public void PuzzleOne_ShouldReturn10()
    {
        _testee.PuzzleOne(_fakeInput).Should().Be(10);
    }

    [Test]
    public void PuzzleTwo_ShouldReturn24()
    {
        _testee.PuzzleTwo(_fakeInput).Should().Be(24);
    }
}