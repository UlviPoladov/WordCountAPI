using WordCountAPI.Models;
using WordCountAPI.Utilities;

namespace WordCountAPI.Services;

public class WordCountService : IWordCountService
{
    public async Task<List<WordCountResult>> ProcessFileAsync(IFormFile file)
    {
        if (file == null || file.Length == 0)
            throw new ArgumentException("File is empty or null");

        var wordCounts = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

        using (var reader = new StreamReader(file.OpenReadStream()))
        {
            string content = await reader.ReadToEndAsync();
            var words = WordParser.ParseWords(content);

            foreach (var word in words)
            {
                if (wordCounts.ContainsKey(word))
                    wordCounts[word]++;
                else
                    wordCounts[word] = 1;
            }
        }

        return wordCounts
            .OrderByDescending(x => x.Value)
            .Select(x => new WordCountResult { Word = x.Key, Count = x.Value })
            .ToList();
    }
}
