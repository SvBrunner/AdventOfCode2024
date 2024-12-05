using AdventOfCode2024.Puzzles;
using FluentAssertions;
using Moq;

namespace AdventOfCode2024.Test;

public class PuzzleDay4Test : PuzzleTestbase
{
    private string input = """
                           MMMSXXMASM
                           MSAMXMSMSA
                           AMXSXMAAMM
                           MSAMASMSMX
                           XMASAMXAMM
                           XXAMMXXAMA
                           SMSMSASXSS
                           SAXAMASAAA
                           MAMMMXMMMM
                           MXMXAXMASX
                           """;
    [SetUp]
    public void SetUp()
    {
        FakeInput = new FakePuzzleInput(input.Split(Environment.NewLine));
        Testee = new PuzzleDay4();
    }
    
    [Test]
    public void PuzzleOne_ShouldReturn18()
    {
        Testee.PuzzleOne(FakeInput).Should().Be(18);
    }
    
    [Test]
    public void PuzzleTwo_ShouldReturn9()
    {
        

        Testee.PuzzleTwo(FakeInput).Should().Be(9);
    }
}