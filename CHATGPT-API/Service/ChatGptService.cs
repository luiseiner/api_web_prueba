using OpenAI_API;
using OpenAI_API.Completions;
using System.Threading.Tasks;

namespace api_form.Services
{
    public class ChatGPTService
    {
        private readonly OpenAIAPI _api;

        public ChatGPTService(string apiKey)
        {
            _api = new OpenAIAPI(apiKey);
        }

        public async Task<string> AskChatGPT(string question)
        {
            var result = await _api.Completions.CreateCompletionAsync(new CompletionRequest
            {
                Prompt = question,
                MaxTokens = 1025
            });

            return result.ToString(); // Ajusta esto según el tipo de resultado correcto
        }
    }
}
