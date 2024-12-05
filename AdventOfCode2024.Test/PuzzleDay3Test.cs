using AdventOfCode2024.Puzzles;
using FluentAssertions;
using Moq;

namespace AdventOfCode2024.Test;

public class PuzzleDay3Test : PuzzleTestbase
{
    [SetUp]
    public void SetUp()
    {
        FakeInput = new FakePuzzleInput(["xmul(2,4)%&mul[3,7]!@^do_not_mul(5,5)+mul(32,64]then(mul(11,8)mul(8,5))"]);
        Testee = new PuzzleDay3();
    }
    
    [Test]
    public void PuzzleOne_ShouldReturn2()
    {
        Testee.PuzzleOne(FakeInput).Should().Be(161);
    }
    
    [Test]
    public void PuzzleTwo_ShouldReturn48()
    {
        
        FakeInput.Lines = ["xmul(2,4)&mul[3,7]!^don't()_mul(5,5)+mul(32,64](mul(11,8)undo()?mul(8,5))"];

        Testee.PuzzleTwo(FakeInput).Should().Be(48);
    }
}