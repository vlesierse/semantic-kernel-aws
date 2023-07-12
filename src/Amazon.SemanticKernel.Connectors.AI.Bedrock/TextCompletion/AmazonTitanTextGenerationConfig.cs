using System.Text.Json.Serialization;

namespace Amazon.SemanticKernel.Connectors.AI.Bedrock.TextCompletion;

public class AmazonTitanTextGenerationConfig
{
    /// <summary>
    /// Top P controls token choices, based on the probability of the potential choices. The range is 0 to 1. The default is 1.
    /// </summary>
    [JsonPropertyName("topP")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public double? TopP { get; set; }
    
    /// <summary>
    /// The Temperature value ranges from 0 to 1, with 0 being the most deterministic and 1 being the most creative.
    /// </summary>
    [JsonPropertyName("temperature")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public double? Temperature { get; set; }
    
    /// <summary>
    /// Configures the maximum number of tokens in the generated response. The range is 0 to 4096. The default is 512.
    /// </summary>
    [JsonPropertyName("maxTokenCount")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? MaxTokenCount { get; set; }

    /// <summary>
    /// Use | (pipe) characters (maximum 20 characters).
    /// </summary>
    [JsonPropertyName("stopSequences")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public IList<string>? StopSequences { get; set; } = new List<string>();
}