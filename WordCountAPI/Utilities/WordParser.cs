using System.Text.RegularExpressions;

namespace WordCountAPI.Utilities;

public static class WordParser
{
    public static List<string> ParseWords(string input)
    {
        var matches = Regex.Matches(input.ToLower(), @"\b[\w]+\b");
        return matches.Select(m => m.Value).ToList();
    }
}
