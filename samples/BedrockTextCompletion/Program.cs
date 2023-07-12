// See https://aka.ms/new-console-template for more information

using Amazon;
using Amazon.Bedrock;
using Microsoft.SemanticKernel;

var kernel = new KernelBuilder()
    .WithAnthropicTextCompletionService("claude-v1", new AmazonBedrockClient(RegionEndpoint.USEast1))
    .Build();
    
const string functionDefinition = "Question: {{$input}}; Answer:";
var questionAnswerFunction = kernel.CreateSemanticFunction(functionDefinition);

const string question = "What is New York?";
Console.WriteLine($"Question: {question}");

var result = await questionAnswerFunction.InvokeAsync(question);
Console.WriteLine($"Answer: {result}");