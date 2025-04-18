# Deleting a Trained Model Synchronously in Azure AI Language

This sample demonstrates how to delete a trained model synchronously using the `Azure.AI.Language.Text.Authoring` SDK.

## Create an `AuthoringClient`

To create an `AuthoringClient`, you will need the service endpoint and credentials of your Language resource. You can specify the service version by providing an `AuthoringClientOptions` instance.

```C# Snippet:CreateTextAuthoringClientForSpecificApiVersion
Uri endpoint = new Uri("https://myaccount.cognitiveservices.azure.com");
AzureKeyCredential credential = new("your apikey");
TextAnalysisAuthoringClientOptions options = new TextAnalysisAuthoringClientOptions(TextAnalysisAuthoringClientOptions.ServiceVersion.V2024_11_15_Preview);
TextAnalysisAuthoringClient client = new TextAnalysisAuthoringClient(endpoint, credential, options);
```

## Delete a Trained Model Synchronously

To delete a trained model, call DeleteTrainedModel on the TextAnalysisAuthoring client.

```C# Snippet:Sample9_TextAuthoring_DeleteTrainedModel
string projectName = "LoanAgreements";
string trainedModelLabel = "ModelLabel"; // Replace with the actual model label.
TextAuthoringTrainedModel trainedModelClient = client.GetTrainedModel(projectName, trainedModelLabel);

Response response = trainedModelClient.DeleteTrainedModel();

Console.WriteLine($"Trained model deleted. Response status: {response.Status}");
```

To delete a trained model, the DeleteTrainedModel method sends a request with the project name and the model label. The method returns a Response object indicating the deletion status.
