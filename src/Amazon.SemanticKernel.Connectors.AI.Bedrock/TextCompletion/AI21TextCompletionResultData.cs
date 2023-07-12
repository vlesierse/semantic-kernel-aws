using System.Text.Json.Serialization;

namespace Amazon.SemanticKernel.Connectors.AI.Bedrock.TextCompletion;

public class AI21TextCompletionResultData
{
    [JsonPropertyName("text")]
    public string Text { get; set; }
}