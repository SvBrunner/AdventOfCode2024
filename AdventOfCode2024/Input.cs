﻿using System.Reflection;

namespace AdventOfCode2024;

public class Input
{
    public virtual ICollection<string> Lines { get; set; }
    public Input(string fileName)
    {
        using var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream($"AdventOfCode2024.Data.{fileName}");
        if (stream == null)
        {
            throw new FileNotFoundException($"The file {fileName} was not found as an embedded resource.");
        }
        using var reader = new StreamReader(stream);
        Lines = reader.ReadToEnd().Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
    }
}