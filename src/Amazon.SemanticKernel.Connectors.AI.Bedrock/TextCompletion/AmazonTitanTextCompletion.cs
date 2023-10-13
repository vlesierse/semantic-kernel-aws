using Amazon.BedrockRuntime;
using Amazon.SemanticKernel.Connectors.AI.Bedrock.BedrockSdk;
using Microsoft.SemanticKernel.AI.TextCompletion;

namespace Amazon.SemanticKernel.Connectors.AI.Bedrock.TextCompletion;

public class AmazonTitanTextCompletion : AmazonBedrockClientBase<AmazonTitanTextCompletionRequest, AmazonTitanTextCompletionResponse>, ITextCompletion
{

    public AmazonTitanTextCompletion(string modelId)
        : base("amazon." + modelId, new AmazonBedrockRuntimeClient())
    { }
    
    public AmazonTitanTextCompletion(string modelId, IAmazonBedrockRuntime bedrockApi)
        : base("amazon." + modelId, bedrockApi)
    { }
    
    public Task<IReadOnlyList<ITextResult>> GetCompletionsAsync(string text, CompleteRequestSettings requestSettings,
        CancellationToken cancellationToken = default)
    {
        return InternalGetTextResultsAsync(text, requestSettings, cancellationToken);
    }

    public IAsyncEnumerable<ITextStreamingResult> GetStreamingCompletionsAsync(string text, CompleteRequestSettings requestSettings,
        CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    protected override AmazonTitanTextCompletionRequest CreateTextCompletionRequest(string text, CompleteRequestSettings settings)
    {
        return new AmazonTitanTextCompletionRequest
        {
            InputText = text,
            TextGenerationConfig = new AmazonTitanTextGenerationConfig
            {
                TopP = settings.TopP == 0 ? null : settings.TopP,
                Temperature = settings.Temperature,
                MaxTokenCount = settings.MaxTokens,
                StopSequences = settings.StopSequences
            }
        };
    }
}