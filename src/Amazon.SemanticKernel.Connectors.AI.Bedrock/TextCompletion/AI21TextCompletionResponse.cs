using System.Text.Json.Serialization;
using Amazon.SemanticKernel.Connectors.AI.Bedrock.BedrockSdk;
using Microsoft.SemanticKernel.AI.TextCompletion;

namespace Amazon.SemanticKernel.Connectors.AI.Bedrock.TextCompletion;

public class AI21TextCompletionResponse : ITextResponse
{
    [JsonPropertyName("completions")]
    public required IReadOnlyList<AI21TextCompletionResult> Completions { get; set; }

    public IReadOnlyList<ITextResult> GetResults() => Completions;
}