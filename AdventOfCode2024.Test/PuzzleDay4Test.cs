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
        _fakeInput = new FakePuzzleInput(input.Split("\r\n"));
        _testee = new PuzzleDay4();
    }
    
    [Test]
    public void PuzzleOne_ShouldReturn18()
    {
        _testee.PuzzleOne(_fakeInput).Should().Be(18);
    }
    
    [Test]
    public void PuzzleTwo_ShouldReturn9()
    {
        

        _testee.PuzzleTwo(_fakeInput).Should().Be(9);
    }
}