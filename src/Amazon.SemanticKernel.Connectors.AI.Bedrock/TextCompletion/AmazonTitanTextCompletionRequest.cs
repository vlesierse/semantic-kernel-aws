using System.Text.Json.Serialization;
using Amazon.SemanticKernel.Connectors.AI.Bedrock.BedrockSdk;
using Microsoft.SemanticKernel.AI.TextCompletion;

namespace Amazon.SemanticKernel.Connectors.AI.Bedrock.TextCompletion;

[Serializable]
public class AmazonTitanTextCompletionRequest : ITextRequest
{
    [JsonPropertyName("inputText")]
    public required string InputText { get; set; }

    [JsonPropertyName("textGenerationConfig")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public AmazonTitanTextGenerationConfig? TextGenerationConfig { get; set; }
    
    int? ITextRequest.MaxTokens => TextGenerationConfig?.MaxTokenCount;
    
    double? ITextRequest.TopP => TextGenerationConfig?.TopP;

    double? ITextRequest.Temperature => TextGenerationConfig?.Temperature;

    IList<string>? ITextRequest.StopSequences => TextGenerationConfig?.StopSequences;
}