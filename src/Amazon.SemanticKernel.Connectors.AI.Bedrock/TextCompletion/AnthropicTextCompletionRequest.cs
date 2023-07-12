using System.Text.Json.Serialization;
using Amazon.SemanticKernel.Connectors.AI.Bedrock.BedrockSdk;

namespace Amazon.SemanticKernel.Connectors.AI.Bedrock.TextCompletion;

public class AnthropicTextCompletionRequest : ITextRequest
{
    [JsonPropertyName("prompt")]
    public required string Prompt { get; set; }
    
    [JsonPropertyName("top_k")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? TopK { get; set; }
    
    [JsonPropertyName("top_p")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public double? TopP { get; set; }

    [JsonPropertyName("temperature")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public double? Temperature{ get; set; }

    [JsonPropertyName("max_tokens_to_sample")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? MaxTokens { get; set; }
    
    [JsonPropertyName("stop_sequences")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public IList<string>? StopSequences { get; set; }
    
    string ITextRequest.InputText => Prompt;
}