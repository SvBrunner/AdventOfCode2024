using AdventOfCode2024.Puzzles;
using FluentAssertions;
using Moq;

namespace AdventOfCode2024.Test;

public class PuzzleDay0Test : PuzzleTestbase
{
    [SetUp]
    public void SetUp()
    {
        FakeInput = new FakePuzzleInput(["1", "2", "3", "4"]);
        Testee = new PuzzleDay0();
    }

    [Test]
    public void PuzzleOne_ShouldReturn10()
    {
        Testee.PuzzleOne(FakeInput).Should().Be(10);
    }

    [Test]
    public void PuzzleTwo_ShouldReturn24()
    {
        Testee.PuzzleTwo(FakeInput).Should().Be(24);
    }
}