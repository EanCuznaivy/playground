namespace DotISP;

public class InvalidSyntaxException : Exception
{
    public InvalidSyntaxException(string? line) : base($"Invalid syntax error: {line}")
    {
    }
}