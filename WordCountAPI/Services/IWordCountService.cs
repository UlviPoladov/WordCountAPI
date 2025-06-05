using WordCountAPI.Models;

namespace WordCountAPI.Services;

public interface IWordCountService
{
    Task<List<WordCountResult>> ProcessFileAsync(IFormFile file);
}
