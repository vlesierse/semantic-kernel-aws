using System.Text.Json.Serialization;
using Amazon.SemanticKernel.Connectors.AI.Bedrock.BedrockSdk;
using Microsoft.SemanticKernel.AI.TextCompletion;

namespace Amazon.SemanticKernel.Connectors.AI.Bedrock.TextCompletion;

[Serializable]
public class AmazonTitanTextCompletionResponse : ITextResponse
{
    [JsonPropertyName("inputTextTokenCount")]
    public int InputTextTokenCount { get; set; }

    [JsonPropertyName("results")]
    public required IReadOnlyList<AmazonTitanTextCompletionResult> Results { get; set; }
    
    public IReadOnlyList<ITextResult> GetResults()
    {
        return Results;
    }
}