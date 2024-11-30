namespace AdventOfCode2024.Puzzles;

public class PuzzleDay0 : IPuzzle
{
    public int PuzzleOne(Input input)
    {
        return input.Lines.Select(int.Parse).Sum();
    }

    public int PuzzleTwo(Input input)
    {
        return input.Lines.Select(int.Parse).Aggregate((a, b) => a * b);
    }
}