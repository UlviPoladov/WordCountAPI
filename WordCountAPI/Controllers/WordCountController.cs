using Microsoft.AspNetCore.Mvc;
using WordCountAPI.Services;
using WordCountAPI.Models;

namespace WordCountAPI.Controllers;

[ApiController]
[Route("api/")]
public class WordCountController : ControllerBase
{
    private readonly IWordCountService _wordCountService;

    public WordCountController(IWordCountService wordCountService)
    {
        _wordCountService = wordCountService;
    }

    [HttpPost]
    [Route("wordcount")]
    public async Task<IActionResult> WordCount([FromForm] WordCountRequest request)
    {
        if (request.File == null || request.File.Length == 0)
            return BadRequest("No file uploaded or file is empty.");

        // file extension check
        if (!Path.GetExtension(request.File.FileName).Equals(".txt", StringComparison.OrdinalIgnoreCase))
            return BadRequest("Only .txt files are allowed.");


        try
        {
            var result = await _wordCountService.ProcessFileAsync(request.File);
            return Ok(result);
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ex.Message);
        }
        catch (Exception)
        {
            return StatusCode(500, "An unexpected error occurred.");
        }
    }
}
