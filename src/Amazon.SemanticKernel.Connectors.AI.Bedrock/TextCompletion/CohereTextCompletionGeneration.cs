using System.Text.Json.Serialization;
using Microsoft.SemanticKernel.AI.TextCompletion;
using Microsoft.SemanticKernel.Orchestration;

namespace Amazon.SemanticKernel.Connectors.AI.Bedrock.TextCompletion;

public class CohereTextCompletionGeneration : ITextResult
{
    [JsonPropertyName("id")]
    public Guid Id { get; set; }
    
    [JsonPropertyName("text")]
    public required string Text { get; set; }

    ModelResult ITextResult.ModelResult => new(Text);
    
    Task<string> ITextResult.GetCompletionAsync(CancellationToken cancellationToken)
    {
        return Task.FromResult(Text);
    }
}