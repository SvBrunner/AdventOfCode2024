﻿using System.Text.RegularExpressions;

namespace AdventOfCode2024.Puzzles;

public class PuzzleDay4 : IPuzzle
{
    private const string Keyword = "XMAS";

    public long PuzzleOne(IPuzzleInput input)
    {
        var lines = input.Lines.ToList();
        var startingPoints = new List<(int, int)>();
        var startingPoint = new Regex("[xX]");

        for (var i = 0; i < lines.Count; i++)
        {
            startingPoints.AddRange(startingPoint.Matches(lines[i]).Select(m => ( m.Index, i)));
        }

        var searchResults = new List<bool>();
        foreach (var point in startingPoints)
        {
            searchResults.Add(FindXmas(lines, point.Item1, point.Item2, 1, DirectionY.North, DirectionX.East));
            searchResults.Add(FindXmas(lines, point.Item1, point.Item2, 1, DirectionY.North, DirectionX.West));
            searchResults.Add(FindXmas(lines, point.Item1, point.Item2, 1, DirectionY.North, DirectionX.Local));
            searchResults.Add(FindXmas(lines, point.Item1, point.Item2, 1, DirectionY.South, DirectionX.East));
            searchResults.Add(FindXmas(lines, point.Item1, point.Item2, 1, DirectionY.South, DirectionX.West));
            searchResults.Add(FindXmas(lines, point.Item1, point.Item2, 1, DirectionY.South, DirectionX.Local));
            searchResults.Add(FindXmas(lines, point.Item1, point.Item2, 1, DirectionY.Local, DirectionX.East));
            searchResults.Add(FindXmas(lines, point.Item1, point.Item2, 1, DirectionY.Local, DirectionX.West));
        }
        return searchResults.Count(s => s);
    }

    private static bool FindXmas(List<string> lines, int x, int y, int index, DirectionY dirY, DirectionX dirX)
    {
        var newY = dirY switch
        {
            DirectionY.North => y - 1,
            DirectionY.South => y + 1,
            _ => y
        };
        var newX = dirX switch
        {
            DirectionX.East => x + 1,
            DirectionX.West => x - 1,
            _ => x
        };

        if(newX < 0  || newY < 0 || newY >= lines.Count|| newX >= lines[newY].Length) return false;
        if (lines[newY][newX] != Keyword[index]) return false;
        return index == Keyword.Length - 1 || FindXmas(lines, newX, newY, index + 1, dirY, dirX);
    }

    private static bool FindMas(List<string> coll,int x, int y)
    {
        if (x == 0 || y == 0 || y == coll.Count - 1 || x == coll[y].Length - 1) return false;
        var topLeft = coll[y-1][x-1];
        var topRight = coll[y-1][x+1];
        var bottomLeft = coll[y+1][x-1];
        var bottomRight = coll[y+1][x+1];

        if (topLeft == topRight && bottomLeft == bottomRight)
        {
            return topLeft != bottomLeft && topLeft is 'M' or 'S' && bottomLeft is 'M' or 'S';
        }

        if(topLeft == bottomLeft && topRight == bottomRight)
        {
            return topLeft != topRight && topLeft is 'M' or 'S' && topRight is 'M' or 'S';
        }
        return false;
    }

    public long PuzzleTwo(IPuzzleInput input)
    {
        var lines = input.Lines.ToList();
        var regex = new Regex("[Aa]");
        var startingPoints = new List<(int, int)>();
        
        for (var i = 0; i < lines.Count; i++)
        {
            startingPoints.AddRange(regex.Matches(lines[i]).Select(m => ( m.Index, i)));
        }
        return startingPoints.Count(s => FindMas(lines, s.Item1, s.Item2));
        
    }
    
}

enum DirectionX
{
    East,
    West,
    Local
}
enum DirectionY
{
    North,
    South,
    Local
}
