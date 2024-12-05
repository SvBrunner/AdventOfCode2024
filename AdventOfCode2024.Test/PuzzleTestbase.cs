using AdventOfCode2024.Puzzles;
using Moq;

namespace AdventOfCode2024.Test;

public class PuzzleTestbase
{
    protected Mock<Input> _mockInput;
    protected IPuzzle _testee;
}