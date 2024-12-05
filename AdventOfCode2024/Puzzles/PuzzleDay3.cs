using System.Text.RegularExpressions;

namespace AdventOfCode2024.Puzzles;

public class PuzzleDay3 : IPuzzle
{
    public long PuzzleOne(IPuzzleInput input)
    {
        var regex = new Regex(@"mul\((\d+),(\d+)\)");
        return input.Lines.SelectMany(line => regex.Matches(line)).Sum(match => long.Parse(match.Groups[1].Value) * long.Parse(match.Groups[2].Value));
    }

    public long PuzzleTwo(IPuzzleInput input)
    {
        var line = input.Lines.Aggregate((a, b) => a + b);
        var regex = new Regex(@"mul\((\d+),(\d+)\)");
        var dontRegex = new Regex(@"don't\(\)");
        var doRegex = new Regex(@"do\(\)");
        
        var matches = regex.Matches(line).ToList();
        var dontMatches = dontRegex.Matches(line).ToList();
        var doMatches = doRegex.Matches(line).ToList();
        long sum = 0;
        foreach (var match in matches)
        {
           var recentDont = dontMatches.LastOrDefault(d => d.Index < match.Index)?.Index ?? 0;
            var recentDo = doMatches.LastOrDefault(d => d.Index < match.Index)?.Index ?? 0;
            if (recentDo >= recentDont)
            {
                sum += long.Parse(match.Groups[1].Value) * long.Parse(match.Groups[2].Value);
            }
        }

        return sum;
    }
}