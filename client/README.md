# Cloudmersive.APIClient.NETCore.Speech - the C# library for the speechapi

Speech APIs enable you to recognize speech and convert it to text using advanced machine learning, and also to convert text to speech.

This C# SDK is for the [Cloudmersive Voice Recognition API](https://cloudmersive.com/voice-recognition-and-speech-api):

- API version: v1
- SDK version: 2.0.2
- Build package: io.swagger.codegen.languages.CSharpClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET Core >=1.0
- .NET Framework >=4.6
- Mono/Xamarin >=vNext
- UWP >=10.0

<a name="dependencies"></a>
## Dependencies
- FubarCoder.RestSharp.Portable.Core >=4.0.7
- FubarCoder.RestSharp.Portable.HttpClient >=4.0.7
- Newtonsoft.Json >=10.0.3

<a name="installation"></a>
## Installation
Generate the DLL using your preferred tool

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using Cloudmersive.APIClient.NETCore.Speech.Api;
using Cloudmersive.APIClient.NETCore.Speech.Client;
using Cloudmersive.APIClient.NETCore.Speech.Model;
```
<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NETCore.Speech.Api;
using Cloudmersive.APIClient.NETCore.Speech.Client;
using Cloudmersive.APIClient.NETCore.Speech.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {

            // Configure API key authorization: Apikey
            Configuration.Default.ApiKey.Add("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Apikey", "Bearer");

            var apiInstance = new RecognizeApi();
            var speechFile = new System.IO.Stream(); // System.IO.Stream | Speech file to perform the operation on.  Common file formats such as WAV, MP3 are supported.

            try
            {
                // Recognize audio input as text using machine learning
                SpeechRecognitionResult result = apiInstance.RecognizeFile(speechFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecognizeApi.RecognizeFile: " + e.Message );
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api.cloudmersive.com*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*RecognizeApi* | [**RecognizeFile**](docs/RecognizeApi.md#recognizefile) | **POST** /speech/recognize/file | Recognize audio input as text using machine learning
*SpeakApi* | [**SpeakPost**](docs/SpeakApi.md#speakpost) | **POST** /speech/speak/text/basicVoice/{format} | Perform text-to-speech on a string
*SpeakApi* | [**SpeakTextToSpeech**](docs/SpeakApi.md#speaktexttospeech) | **POST** /speech/speak/text/voice/basic/audio | Perform text-to-speech on a string


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.SpeechRecognitionResult](docs/SpeechRecognitionResult.md)
 - [Model.TextToSpeechRequest](docs/TextToSpeechRequest.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="Apikey"></a>
### Apikey

- **Type**: API key
- **API key parameter name**: Apikey
- **Location**: HTTP header

