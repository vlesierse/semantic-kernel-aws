using Amazon.Bedrock;
using Amazon.SemanticKernel.Connectors.AI.Bedrock.BedrockSdk;
using Microsoft.SemanticKernel.AI.TextCompletion;

namespace Amazon.SemanticKernel.Connectors.AI.Bedrock.TextCompletion;

public class AnthropicTextCompletion : AmazonBedrockClientBase<AnthropicTextCompletionRequest, AnthropicTextCompletionResponse>, ITextCompletion
{

    public AnthropicTextCompletion(string modelId)
        : base("anthropic." + modelId, new AmazonBedrockClient())
    { }
    
    public AnthropicTextCompletion(string modelId, IAmazonBedrock bedrockApi)
        : base("anthropic." + modelId, bedrockApi)
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

    protected override AnthropicTextCompletionRequest CreateTextCompletionRequest(string text, CompleteRequestSettings settings)
    {
        return new AnthropicTextCompletionRequest
        {
            Prompt = text,
            MaxTokens = settings.MaxTokens,
            TopP = settings.TopP,
            Temperature = settings.Temperature,
            StopSequences = settings.StopSequences
        };
    }
}