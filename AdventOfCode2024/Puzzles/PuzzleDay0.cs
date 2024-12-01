namespace AdventOfCode2024.Puzzles;

public class PuzzleDay0 : IPuzzle
{
    public long PuzzleOne(Input input)
    {
        return input.Lines.Select(int.Parse).Sum();
    }

    public long PuzzleTwo(Input input)
    {
        return input.Lines.Select(int.Parse).Aggregate((a, b) => a * b);
    }
}