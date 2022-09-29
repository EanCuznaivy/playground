using DotISP;
using DotISP.Parsers;

Parsec<double, char> parser = new NumberParser();

while (true)
{
    Console.Write(DotISPConstants.Prompt);
    var line = Console.ReadLine();
    if (line == null)
    {
        continue;
    }

    if (parser.TryParse(line.ToCharArray(), out var result))
    {
        Console.WriteLine(result);
    }
    else
    {
        throw new InvalidSyntaxException(line);
    }
}