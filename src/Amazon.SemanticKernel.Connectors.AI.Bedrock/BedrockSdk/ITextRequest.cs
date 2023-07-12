using Microsoft.SemanticKernel.AI.TextCompletion;

namespace Amazon.SemanticKernel.Connectors.AI.Bedrock.BedrockSdk;

public interface ITextRequest
{
    string InputText { get; }
    
    double? TopP { get; }
    
    double? Temperature { get; }
    
    int? MaxTokens { get; }
    
    IList<string>? StopSequences { get; }
}