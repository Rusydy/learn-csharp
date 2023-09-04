using System;

static class LogLine
{
    public static string Message(string logLine)
    {
        int colonIndex = logLine.IndexOf(": ");

        if (colonIndex != -1)
        {
            return logLine.Substring(colonIndex + 2).Trim();
        }

        return "";
    }

    public static string LogLevel(string logLine)
    {
        int closeBracketIndex = logLine.IndexOf("]:");

        if (closeBracketIndex != -1)
        {
            return logLine.Substring(1, closeBracketIndex -1).ToLower();
        }

        return "";
    }

    public static string Reformat(string logLine)
    {
        string message = Message(logLine);
        string level = LogLevel(logLine);

        return $"{message} ({level})";
    }
}
