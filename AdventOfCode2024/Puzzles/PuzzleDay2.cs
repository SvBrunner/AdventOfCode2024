namespace AdventOfCode2024.Puzzles;

public class PuzzleDay2 : IPuzzle
{
    public long PuzzleOne(IPuzzleInput input)
    {
        var reports = input.Lines.Select(l => l.Split(" ").Select(int.Parse).ToList()).ToList();

        return reports.Sum(report => (IsValidReport(report)) ? 1 : 0);
    }

    public long PuzzleTwo(IPuzzleInput input)
    {
        var reports = input.Lines.Select(l => l.Split(" ").Select(int.Parse).ToList()).ToList();
        var sum = 0;
        foreach (var report in reports)
        {
            if (IsValidReport(report))
            {
                sum++;
            }
            else
            {
                var isValid = false;
                for(var i = 0; i < report.Count; i++)
                {
                    List<int> newReport = [..report];
                    newReport.RemoveAt(i);
                    if (!IsValidReport(newReport)) continue;
                    isValid = true;
                    break;
                }

                if (isValid)
                    sum++;
            }
                
        }

        return sum;    
    }

    private bool IsValidReport(List<int> report)
    {
        if(report.First() > report.Last())
            report.Reverse();
        for (var i = 0; i < report.Count - 1; i++)
        {
            var first = report[i];
            var second = report[i + 1];
            if (IsValidPair(first, second)) continue;
            return false;
        }
        return true;
    }

    private static bool IsValidPair(int first, int second)
    {
        return first < second && Math.Abs(first - second) <= 3;
    }
}