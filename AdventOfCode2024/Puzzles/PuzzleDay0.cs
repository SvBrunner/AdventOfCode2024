namespace AdventOfCode2024.Puzzles;

public class PuzzleDay0 : IPuzzle
{
    public long PuzzleOne(IPuzzleInput input)
    {
        return input.Lines.Select(int.Parse).Sum();
    }

    public long PuzzleTwo(IPuzzleInput input)
    {
        return input.Lines.Select(int.Parse).Aggregate((a, b) => a * b);
    }
}