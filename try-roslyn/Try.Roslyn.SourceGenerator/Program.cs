using System;

namespace Try.Roslyn.SourceGenerator;

public static partial class Program
{
    static void Main(string[] args)
    {
        HelloFrom("me");
    }

    static partial void HelloFrom(string name);
}