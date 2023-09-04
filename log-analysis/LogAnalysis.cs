using System;

public static class LogAnalysis 
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` type
    public static string SubstringAfter(this string s, string delimiter)
    {
        int delimiterIndex = s.IndexOf(delimiter);

        // Check if the delimiter is found.
        if (delimiterIndex >= 0)
        {
            // Use Substring to extract the substring after the delimiter.
            return s.Substring(delimiterIndex + delimiter.Length);
        }

        // Return an empty string if the delimiter is not found.
        return string.Empty;
    }

    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    public static string SubstringBetween(this string s, string start, string end)
    {
        int startIndex = s.IndexOf(start);
        int endIndex = s.IndexOf(end);

        // Check if both start and end delimiters are found and in the correct order.
        if (startIndex >= 0 && endIndex > startIndex)
        {
            // Calculate the length of the substring between the delimiters.
            int length = endIndex - (startIndex + start.Length);

            // Use Substring to extract the substring between the delimiters.
            return s.Substring(startIndex + start.Length, length);
        }

        // Return an empty string if the delimiters are not found or in the wrong order.
        return string.Empty;
    }

    
    // TODO: define the 'Message()' extension method on the `string` type
    public static string Message(this string s)
    {
        // Use SubstringAfter to extract the message.
        return s.SubstringAfter(": ");
    }

    // TODO: define the 'LogLevel()' extension method on the `string` type
    public static string LogLevel(this string s)
    {
        // Use SubstringBetween to extract the log level.
        return s.SubstringBetween("[", "]:");
    }
}