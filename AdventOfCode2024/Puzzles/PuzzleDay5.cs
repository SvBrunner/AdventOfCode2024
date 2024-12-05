namespace AdventOfCode2024.Puzzles;

using System;
using System.Collections.Generic;
using System.Linq;

public class PuzzleDay5 : IPuzzle
{
    private List<PuzzleConstraint> _constraints = [];
    private List<List<int>> _books = [];

    private void ParseInput(IPuzzleInput input)
    {
        var lines = input.Lines;
        _constraints = [];
        _books = [];

        var parsingConstraints = true;
        foreach (var line in lines)
        {
            if (string.IsNullOrWhiteSpace(line))
            {
                parsingConstraints = false;
                continue;
            }

            if (parsingConstraints)
            {
                var parts = line.Split("|").Select(s => s.Trim()).ToArray();
                _constraints.Add(new PuzzleConstraint(int.Parse(parts[0]),int.Parse(parts[1])));
            }
            else
            {
                var parts = line.Split(",");
                _books.Add(parts.Select(int.Parse).ToList());
            }
        }
    }

    public long PuzzleOne(IPuzzleInput input)
    {
        ParseInput(input);

        long p1 = 0;

        foreach (var book in _books)
        {
            ResetConstraints();

            foreach (var page in book)
            {
                PrintPage(page);
            }

            if (_constraints.All(c => c.Happy))
            {
                p1 += book[book.Count / 2];
            }
        }

        return p1;
    }

    public long PuzzleTwo(IPuzzleInput input)
    {
        ParseInput(input);

        var failedBooks = _books.Where(book =>
        {
            ResetConstraints();

            foreach (var page in book)
            {
                PrintPage(page);
            }

            return !_constraints.All(c => c.Happy);
        }).ToList();

        var comparator = new Comparison<int>((i1, i2) =>
        {
            return _constraints.Select(constraint => constraint.Compare(i1, i2)).FirstOrDefault(result => result != 0);
        });

        long p2 = 0;

        foreach (var book in failedBooks)
        {
            book.Sort(comparator);
            p2 += book[book.Count / 2];
        }

        return p2;
    }

    private void ResetConstraints()
    {
        foreach (var constraint in _constraints)
        {
            constraint.Reset();
        }
    }

    private void PrintPage(int page)
    {
        foreach (var constraint in _constraints)
        {
            constraint.Print(page);
        }
    }

    private class PuzzleConstraint
    {
        private readonly int _one;
        private readonly int _two;
        private bool _onePrinted;
        private bool _twoPrinted;
        public bool Happy { get; private set; }

        public PuzzleConstraint(int one, int two)
        {
            this._one = one;
            this._two = two;
            Reset();
        }

        public void Print(int page)
        {
            if (page == _one)
            {
                _onePrinted = true;
                if (_twoPrinted)
                {
                    Happy = false;
                }
            }
            else if (page == _two)
            {
                _twoPrinted = true;
            }
        }

        public void Reset()
        {
            _onePrinted = false;
            _twoPrinted = false;
            Happy = true;
        }

        public int Compare(int i1, int i2)
        {
            if (i1 == _one && i2 == _two) return -1;
            if (i1 == _two && i2 == _one) return 1;
            return 0;
        }
    }
}