using System.Text.Json.Serialization;
using Microsoft.SemanticKernel.AI.TextCompletion;
using Microsoft.SemanticKernel.Orchestration;

namespace Amazon.SemanticKernel.Connectors.AI.Bedrock.TextCompletion;

public class AmazonTitanTextCompletionResult : ITextResult
{
    [JsonPropertyName("tokenCount")]
    public int TokenCount { get; set; }
    
    [JsonPropertyName("outputText")]
    public required string OutputText { get; set; }
    
    [JsonPropertyName("completionReason")]
    public  string? CompletionReason { get; set; }

    ModelResult ITextResult.ModelResult => new(OutputText);
    
    Task<string> ITextResult.GetCompletionAsync(CancellationToken cancellationToken)
    {
        return Task.FromResult(OutputText);
    }
}