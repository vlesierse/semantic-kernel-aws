using Amazon.BedrockRuntime;
using Amazon.SemanticKernel.Connectors.AI.Bedrock.BedrockSdk;
using Microsoft.SemanticKernel.AI.TextCompletion;

namespace Amazon.SemanticKernel.Connectors.AI.Bedrock.TextCompletion;

public class CohereTextCompletion : AmazonBedrockClientBase<CohereTextCompletionRequest, CohereTextCompletionResponse>, ITextCompletion
{

    public CohereTextCompletion(string modelId)
        : base("cohere." + modelId, new AmazonBedrockRuntimeClient())
    { }
    
    public CohereTextCompletion(string modelId, IAmazonBedrockRuntime bedrockApi)
        : base("cohere." + modelId, bedrockApi)
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

    protected override CohereTextCompletionRequest CreateTextCompletionRequest(string text, CompleteRequestSettings settings)
    {
        return new CohereTextCompletionRequest
        {
            Prompt = text,
            MaxTokens = settings.MaxTokens,
            TopP = settings.TopP,
            Temperature = settings.Temperature,
            StopSequences = settings.StopSequences
        };
    }
}