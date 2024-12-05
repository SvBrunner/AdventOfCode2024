using AdventOfCode2024.Puzzles;

namespace AdventOfCode2024;

public static class PuzzleMysterySolver
{
    public static void Solve(IPuzzle puzzle, string fileName)
    {
        var input = new PuzzleInput(fileName);
        Console.WriteLine($"Input file : {fileName}");
        Console.WriteLine($"Puzzle One: {puzzle.PuzzleOne(input)}");
        Console.WriteLine($"Puzzle Two: {puzzle.PuzzleTwo(input)}");
    }
}