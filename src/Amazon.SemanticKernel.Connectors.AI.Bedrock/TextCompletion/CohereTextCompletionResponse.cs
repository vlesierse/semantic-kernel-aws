using System.Text.Json.Serialization;
using Amazon.SemanticKernel.Connectors.AI.Bedrock.BedrockSdk;
using Microsoft.SemanticKernel.AI.TextCompletion;
using Microsoft.SemanticKernel.Orchestration;

namespace Amazon.SemanticKernel.Connectors.AI.Bedrock.TextCompletion;

public class CohereTextCompletionResponse : ITextResponse
{
    [JsonPropertyName("id")]
    public Guid Id { get; set; }
    
    [JsonPropertyName("prompt")]
    public required string Prompt { get; set; }
    
    [JsonPropertyName("generations")]
    public required IReadOnlyList<CohereTextCompletionGeneration> Generations { get; set; }
    
    public IReadOnlyList<ITextResult> GetResults() => Generations;
}