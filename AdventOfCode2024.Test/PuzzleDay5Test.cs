﻿using AdventOfCode2024.Puzzles;
using FluentAssertions;
using Moq;

namespace AdventOfCode2024.Test;

public class PuzzleDay5Test : PuzzleTestbase
{
    private string input = """
                           47|53
                           97|13
                           97|61
                           97|47
                           75|29
                           61|13
                           75|53
                           29|13
                           97|29
                           53|29
                           61|53
                           97|53
                           61|29
                           47|13
                           75|47
                           97|75
                           47|61
                           75|61
                           47|29
                           75|13
                           53|13

                           75,47,61,53,29
                           97,61,53,29,13
                           75,29,13
                           75,97,47,61,53
                           61,13,29
                           97,13,75,29,47
                           """;
    
    [SetUp]
    public void SetUp()
    {
        _mockInput = new Mock<Input>("DayFive.input");
        _mockInput.SetupGet(m => m.Lines).Returns(input.Split("\r\n"));
        _testee = new PuzzleDay5();
    }
    
    [Test]
    public void PuzzleOne_ShouldReturn143()
    {
        _testee.PuzzleOne(_mockInput.Object).Should().Be(143);
    }
    
    [Test]
    public void PuzzleTwo_ShouldReturn123()
    {
        _testee.PuzzleTwo(_mockInput.Object).Should().Be(123);
    }

}