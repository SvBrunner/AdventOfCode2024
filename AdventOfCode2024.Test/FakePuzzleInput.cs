namespace AdventOfCode2024.Test;

public class FakePuzzleInput : IPuzzleInput
{
    public FakePuzzleInput(ICollection<string> lines)
    {
        Lines = lines;
    }

    public ICollection<string> Lines { get; set; }
}