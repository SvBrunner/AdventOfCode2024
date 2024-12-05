using AdventOfCode2024;
using AdventOfCode2024.Puzzles;

Dictionary<IPuzzle, string> puzzles = new()
{
    {new PuzzleDay1(), "DayOne.input"},
    {new PuzzleDay2(), "DayTwo.input"},
    {new PuzzleDay3(), "DayThree.input"},
    {new PuzzleDay4(), "DayFour.input"},
    {new PuzzleDay5(), "DayFive.input"}
};

foreach (var puzzle in puzzles)
{
    MysterySolver.Solve(puzzle.Key, puzzle.Value);
}