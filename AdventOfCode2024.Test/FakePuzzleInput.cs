namespace AdventOfCode2024.Test;

public class FakePuzzleInput(ICollection<string> lines) : IPuzzleInput
{
    public ICollection<string> Lines { get; set; } = lines;
}