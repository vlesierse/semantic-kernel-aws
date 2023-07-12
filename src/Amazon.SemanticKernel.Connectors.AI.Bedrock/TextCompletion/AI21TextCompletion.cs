using Amazon.Bedrock;
using Amazon.SemanticKernel.Connectors.AI.Bedrock.BedrockSdk;
using Microsoft.SemanticKernel.AI.TextCompletion;

namespace Amazon.SemanticKernel.Connectors.AI.Bedrock.TextCompletion;

public class AI21TextCompletion : AmazonBedrockClientBase<AI21TextCompletionRequest, AI21TextCompletionResponse>, ITextCompletion
{

    public AI21TextCompletion(string modelId)
        : base("ai21." + modelId, new AmazonBedrockClient())
    { }
    
    public AI21TextCompletion(string modelId, IAmazonBedrock bedrockApi)
        : base("ai21." + modelId, bedrockApi)
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

    protected override AI21TextCompletionRequest CreateTextCompletionRequest(string text, CompleteRequestSettings settings)
    {
        return new AI21TextCompletionRequest
        {
            Prompt = text,
            MaxTokens = settings.MaxTokens,
            TopP = settings.TopP,
            Temperature = settings.Temperature,
            StopSequences = settings.StopSequences
        };
    }
}