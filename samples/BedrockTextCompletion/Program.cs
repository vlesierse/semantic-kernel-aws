// See https://aka.ms/new-console-template for more information
using Microsoft.SemanticKernel;

var kernel = new KernelBuilder()
    .WithCohereTextCompletionService("command-text-v14")
    .Build();
    
const string functionDefinition = "Question: {{$input}}; Answer:";
var questionAnswerFunction = kernel.CreateSemanticFunction(functionDefinition);

const string question = "Who are you?";
Console.WriteLine($"Question: {question}");

var result = await questionAnswerFunction.InvokeAsync(question);
Console.WriteLine($"Answer: {result}");