# Cloudmersive.APIClient.NETCore.Speech - the C# library for the speechapi

Speech APIs enable you to recognize speech and convert it to text using advanced machine learning, and also to convert text to speech.

This C# SDK is for the [Cloudmersive Voice Recognition API](https://cloudmersive.com/voice-recognition-and-speech-api):

- API version: v1
- SDK version: 2.1.1
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
            var languageCode = languageCode_example;  // string | ISO 639-3 three-letter language code (e.g. eng, spa, fra). Empty for auto-detect. (optional) 
            var recognitionMode = recognitionMode_example;  // string | Recognition mode: Fast, Normal (default), or Advanced. Advanced is only available on Private Cloud and Managed Instance deployments. (optional)  (default to Normal)
            var speechFile = new System.IO.Stream(); // System.IO.Stream |  (optional) 

            try
            {
                // Recognize audio input as text using Advanced AI
                SpeechRecognitionResult result = apiInstance.SpeechRecognizeFilePost(languageCode, recognitionMode, speechFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecognizeApi.SpeechRecognizeFilePost: " + e.Message );
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://testapi.cloudmersive.com*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*RecognizeApi* | [**SpeechRecognizeFilePost**](docs/RecognizeApi.md#speechrecognizefilepost) | **POST** /speech/recognize/file | Recognize audio input as text using Advanced AI
*SpeakApi* | [**SpeechSpeakTextVoiceBasicAudioPost**](docs/SpeakApi.md#speechspeaktextvoicebasicaudiopost) | **POST** /speech/speak/text/voice/basic/audio | Generate audio from text using Advanced AI


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.SpeechRecognitionResult](docs/SpeechRecognitionResult.md)
 - [Model.TextToSpeechRequest](docs/TextToSpeechRequest.md)
 - [Model.TokenTimestamp](docs/TokenTimestamp.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="Apikey"></a>
### Apikey

- **Type**: API key
- **API key parameter name**: Apikey
- **Location**: HTTP header

