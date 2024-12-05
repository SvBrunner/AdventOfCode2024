namespace AdventOfCode2024.Puzzles;

public class PuzzleDay1 : IPuzzle
{

    public long PuzzleOne(IPuzzleInput input)
    {
        
        var (left, right) = SplitLines(input.Lines);
        left.Sort();
        right.Sort();
        return left.Zip(right).Select(pair => Math.Abs(pair.First - pair.Second)).Sum();
    }

    public long PuzzleTwo(IPuzzleInput input)
    {
        var (left, right) = SplitLines(input.Lines);
        long simScore = 0;
        foreach (var leftVal in left)
        {
            var occurences = right.Count(r => r == leftVal);
            simScore += leftVal * occurences;
        }

        return simScore;
    }
    
    private (List<int>, List<int>) SplitLines(ICollection<string> lines)
    {
        List<int> left = [];
        List<int> right = [];
        foreach (var line in lines)
        {
            var parts = line.Split("   ");
            left.Add(int.Parse(parts[0]));
            right.Add(int.Parse(parts[1])); 
        }
        return (left, right);
    }
}