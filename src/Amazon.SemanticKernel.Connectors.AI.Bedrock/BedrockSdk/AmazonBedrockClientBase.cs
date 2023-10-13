using System.Text.Json;
using Amazon.BedrockRuntime;
using Amazon.BedrockRuntime.Model;
using Microsoft.SemanticKernel.AI.TextCompletion;

namespace Amazon.SemanticKernel.Connectors.AI.Bedrock.BedrockSdk;

public abstract class AmazonBedrockClientBase<TRequest, TResponse>
    where TRequest : ITextRequest
    where TResponse : ITextResponse
{
    private readonly string _modelId;
    private readonly IAmazonBedrockRuntime _bedrockApi;
    
    protected AmazonBedrockClientBase(string modelId, IAmazonBedrockRuntime bedrockApi)
    {
        _modelId = modelId;
        _bedrockApi = bedrockApi;
    }

    /// <summary>
    /// Creates completions for the prompt and settings.
    /// </summary>
    /// <param name="text">The prompt to complete.</param>
    /// <param name="requestSettings">Request settings for the completion API</param>
    /// <param name="cancellationToken">The <see cref="CancellationToken"/> to monitor for cancellation requests. The default is <see cref="CancellationToken.None"/>.</param>
    /// <returns>Completions generated by the remote model</returns>
    private protected async Task<IReadOnlyList<ITextResult>> InternalGetTextResultsAsync(
        string text,
        CompleteRequestSettings requestSettings,
        CancellationToken cancellationToken = default)
    {
        var requestBody = CreateTextCompletionRequest(text, requestSettings);
        var request = new InvokeModelRequest
        {
            ModelId = _modelId,
            Accept = "*/*",
            ContentType = "application/json",
            Body = new MemoryStream(JsonSerializer.SerializeToUtf8Bytes(requestBody))
        };
        var response = await _bedrockApi.InvokeModelAsync(request, cancellationToken);
        var responseBody = JsonSerializer.Deserialize<TResponse>(response.Body);
        return responseBody?.GetResults() ?? new List<ITextResult>();
    }

    protected abstract TRequest CreateTextCompletionRequest(string text, CompleteRequestSettings settings);
}