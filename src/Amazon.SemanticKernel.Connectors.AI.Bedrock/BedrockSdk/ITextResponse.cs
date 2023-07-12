using Microsoft.SemanticKernel.AI.TextCompletion;

namespace Amazon.SemanticKernel.Connectors.AI.Bedrock.BedrockSdk;

public interface ITextResponse
{
    IReadOnlyList<ITextResult> GetResults();
}