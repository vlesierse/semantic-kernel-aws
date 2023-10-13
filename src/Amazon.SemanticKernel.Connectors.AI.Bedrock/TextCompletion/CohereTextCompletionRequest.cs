using System.Text.Json.Serialization;
using Amazon.SemanticKernel.Connectors.AI.Bedrock.BedrockSdk;

namespace Amazon.SemanticKernel.Connectors.AI.Bedrock.TextCompletion;

public class CohereTextCompletionRequest : ITextRequest
{
    [JsonPropertyName("prompt")]
    public required string Prompt { get; set; }
    
    [JsonPropertyName("max_tokens")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? MaxTokens { get; set; }

    [JsonPropertyName("p")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public double? TopP { get; set; }
    
    [JsonPropertyName("k")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? TopK { get; set; }
    
    [JsonPropertyName("temperature")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public double? Temperature { get; set; }
    
    [JsonPropertyName("stop_sequences")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public IList<string>? StopSequences { get; set; }
    
    [JsonPropertyName("return_likelihoods")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? ReturnLikelihoods { get; set; }
    
    string ITextRequest.InputText => Prompt;
}