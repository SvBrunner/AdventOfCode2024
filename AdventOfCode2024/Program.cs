using AdventOfCode2024;
using AdventOfCode2024.Puzzles;

Dictionary<IPuzzle, string> puzzles = new()
{
    {new PuzzleDay0(), "TestDay.input"},
    {new PuzzleDay1(), "DayOne.input"}
};

foreach (var puzzle in puzzles)
{
    MysterySolver.Solve(puzzle.Key, puzzle.Value);
}