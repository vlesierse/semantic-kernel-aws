using System.Text.Json.Serialization;
using Amazon.SemanticKernel.Connectors.AI.Bedrock.BedrockSdk;
using Microsoft.SemanticKernel.AI.TextCompletion;
using Microsoft.SemanticKernel.Orchestration;

namespace Amazon.SemanticKernel.Connectors.AI.Bedrock.TextCompletion;

public class AnthropicTextCompletionResponse : ITextResponse, ITextResult
{
    [JsonPropertyName("completion")]
    public required string Completion { get; set; }

    public Task<string> GetCompletionAsync(CancellationToken cancellationToken = new CancellationToken())
    {
        return Task.FromResult(Completion);
    }

    public ModelResult ModelResult => new(Completion);
    
    public IReadOnlyList<ITextResult> GetResults() => new []{ this };
}