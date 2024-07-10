using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;


namespace WebService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatGptController : ControllerBase
    {
        private readonly ChatGptService _chatGptService;

        public ChatGptController(ChatGptService chatGptService)
        {
            _chatGptService = chatGptService;
        }

        [HttpPost("ask")]
        public async Task<IActionResult> Ask([FromBody] string prompt)
        {
            if (string.IsNullOrEmpty(prompt))
            {
                return BadRequest("Prompt is required.");
            }

            var response = await _chatGptService.GetChatGptResponse(prompt);
            return Ok(response);
        }
    }
}
