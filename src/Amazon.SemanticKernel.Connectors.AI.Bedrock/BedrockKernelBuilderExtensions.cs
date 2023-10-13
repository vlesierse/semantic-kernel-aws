using Amazon.BedrockRuntime;
using Amazon.SemanticKernel.Connectors.AI.Bedrock.TextCompletion;
using Microsoft.SemanticKernel.AI.TextCompletion;

// ReSharper disable once CheckNamespace
namespace Microsoft.SemanticKernel;

public static class BedrockKernelBuilderExtensions
{
    /// <summary>
    /// Registers an Amazon SageMaker text completion service with the specified configuration.
    /// </summary>
    /// <param name="builder">The <see cref="KernelBuilder"/> instance.</param>
    /// <param name="modelId">The name of the SageMaker endpoint.</param>
    /// <param name="serviceId">A local identifier for the given AI service.</param>
    /// <param name="setAsDefault">Indicates whether the service should be the default for its type.</param>
    /// <returns>The modified <see cref="KernelBuilder"/> instance.</returns>
    public static KernelBuilder WithAmazonTitanTextCompletionService(this KernelBuilder builder,
        string modelId,
        string? serviceId = null,
        bool setAsDefault = false
    ) =>
        builder.WithAIService<ITextCompletion>(serviceId, (parameters) => new AmazonTitanTextCompletion(modelId), setAsDefault);

    /// <summary>
    /// Registers an Amazon SageMaker text completion service with the specified configuration.
    /// </summary>
    /// <param name="builder">The <see cref="KernelBuilder"/> instance.</param>
    /// <param name="modelId">The name of the SageMaker endpoint.</param>
    /// <param name="bedrockApi"></param>
    /// <param name="serviceId">A local identifier for the given AI service.</param>
    /// <param name="setAsDefault">Indicates whether the service should be the default for its type.</param>
    /// <returns>The modified <see cref="KernelBuilder"/> instance.</returns>
    public static KernelBuilder WithAmazonTitanTextCompletionService(this KernelBuilder builder,
        string modelId,
        IAmazonBedrockRuntime bedrockApi,
        string? serviceId = null,
        bool setAsDefault = false
    ) =>
        builder.WithAIService<ITextCompletion>(serviceId, (parameters) => new AmazonTitanTextCompletion(modelId, bedrockApi), setAsDefault);
    
    /// <summary>
    /// Registers an Amazon SageMaker text completion service with the specified configuration.
    /// </summary>
    /// <param name="builder">The <see cref="KernelBuilder"/> instance.</param>
    /// <param name="modelId">The name of the SageMaker endpoint.</param>
    /// <param name="serviceId">A local identifier for the given AI service.</param>
    /// <param name="setAsDefault">Indicates whether the service should be the default for its type.</param>
    /// <returns>The modified <see cref="KernelBuilder"/> instance.</returns>
    public static KernelBuilder WithAI21TextCompletionService(this KernelBuilder builder,
        string modelId,
        string? serviceId = null,
        bool setAsDefault = false
    ) =>
        builder.WithAIService<ITextCompletion>(serviceId, (parameters) => new AI21TextCompletion(modelId), setAsDefault);

    /// <summary>
    /// Registers an Amazon SageMaker text completion service with the specified configuration.
    /// </summary>
    /// <param name="builder">The <see cref="KernelBuilder"/> instance.</param>
    /// <param name="modelId">The name of the SageMaker endpoint.</param>
    /// <param name="bedrockApi"></param>
    /// <param name="serviceId">A local identifier for the given AI service.</param>
    /// <param name="setAsDefault">Indicates whether the service should be the default for its type.</param>
    /// <returns>The modified <see cref="KernelBuilder"/> instance.</returns>
    public static KernelBuilder WithAI21TextCompletionService(this KernelBuilder builder,
        string modelId,
        IAmazonBedrockRuntime bedrockApi,
        string? serviceId = null,
        bool setAsDefault = false
    ) =>
        builder.WithAIService<ITextCompletion>(serviceId, (parameters) => new AI21TextCompletion(modelId, bedrockApi), setAsDefault);

    /// <summary>
    /// Registers an Amazon SageMaker text completion service with the specified configuration.
    /// </summary>
    /// <param name="builder">The <see cref="KernelBuilder"/> instance.</param>
    /// <param name="modelId">The name of the SageMaker endpoint.</param>
    /// <param name="serviceId">A local identifier for the given AI service.</param>
    /// <param name="setAsDefault">Indicates whether the service should be the default for its type.</param>
    /// <returns>The modified <see cref="KernelBuilder"/> instance.</returns>
    public static KernelBuilder WithAnthropicTextCompletionService(this KernelBuilder builder,
        string modelId,
        string? serviceId = null,
        bool setAsDefault = false
    ) =>
        builder.WithAIService<ITextCompletion>(serviceId, (parameters) => new AnthropicTextCompletion(modelId), setAsDefault);

    /// <summary>
    /// Registers an Amazon SageMaker text completion service with the specified configuration.
    /// </summary>
    /// <param name="builder">The <see cref="KernelBuilder"/> instance.</param>
    /// <param name="modelId">The name of the SageMaker endpoint.</param>
    /// <param name="bedrockApi"></param>
    /// <param name="serviceId">A local identifier for the given AI service.</param>
    /// <param name="setAsDefault">Indicates whether the service should be the default for its type.</param>
    /// <returns>The modified <see cref="KernelBuilder"/> instance.</returns>
    public static KernelBuilder WithAnthropicTextCompletionService(this KernelBuilder builder,
        string modelId,
        IAmazonBedrockRuntime bedrockApi,
        string? serviceId = null,
        bool setAsDefault = false
    ) =>
        builder.WithAIService<ITextCompletion>(serviceId, (parameters) => new AnthropicTextCompletion(modelId, bedrockApi), setAsDefault);
    
    /// <summary>
    /// Registers an Amazon SageMaker text completion service with the specified configuration.
    /// </summary>
    /// <param name="builder">The <see cref="KernelBuilder"/> instance.</param>
    /// <param name="modelId">The name of the SageMaker endpoint.</param>
    /// <param name="serviceId">A local identifier for the given AI service.</param>
    /// <param name="setAsDefault">Indicates whether the service should be the default for its type.</param>
    /// <returns>The modified <see cref="KernelBuilder"/> instance.</returns>
    public static KernelBuilder WithCohereTextCompletionService(this KernelBuilder builder,
        string modelId,
        string? serviceId = null,
        bool setAsDefault = false
    ) =>
        builder.WithAIService<ITextCompletion>(serviceId, (parameters) => new CohereTextCompletion(modelId), setAsDefault);
    
    /// <summary>
    /// Registers an Amazon SageMaker text completion service with the specified configuration.
    /// </summary>
    /// <param name="builder">The <see cref="KernelBuilder"/> instance.</param>
    /// <param name="modelId">The name of the SageMaker endpoint.</param>
    /// <param name="bedrockApi"></param>
    /// <param name="serviceId">A local identifier for the given AI service.</param>
    /// <param name="setAsDefault">Indicates whether the service should be the default for its type.</param>
    /// <returns>The modified <see cref="KernelBuilder"/> instance.</returns>
    public static KernelBuilder WithCohereTextCompletionService(this KernelBuilder builder,
        string modelId,
        IAmazonBedrockRuntime bedrockApi,
        string? serviceId = null,
        bool setAsDefault = false
    ) =>
        builder.WithAIService<ITextCompletion>(serviceId, (parameters) => new CohereTextCompletion(modelId, bedrockApi), setAsDefault);

}

