using Microsoft.AspNetCore.Http;

namespace WordCountAPI.Models;

public class WordCountRequest
{
    public IFormFile File { get; set; }
}
