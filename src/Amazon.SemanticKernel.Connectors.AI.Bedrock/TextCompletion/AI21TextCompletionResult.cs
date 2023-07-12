using System.Text.Json.Serialization;
using Microsoft.SemanticKernel.AI.TextCompletion;
using Microsoft.SemanticKernel.Orchestration;

namespace Amazon.SemanticKernel.Connectors.AI.Bedrock.TextCompletion;

public class AI21TextCompletionResult : ITextResult
{
    [JsonPropertyName("data")]
    public required AI21TextCompletionResultData Data { get; set; }
    
    public ModelResult ModelResult => new(Data.Text);
    
    public Task<string> GetCompletionAsync(CancellationToken cancellationToken = default)
    {
        return Task.FromResult(Data.Text);
    }
}