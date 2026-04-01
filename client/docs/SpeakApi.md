# Cloudmersive.APIClient.NETCore.Speech.Api.SpeakApi

All URIs are relative to *https://testapi.cloudmersive.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SpeechSpeakTextVoiceBasicAudioPost**](SpeakApi.md#speechspeaktextvoicebasicaudiopost) | **POST** /speech/speak/text/voice/basic/audio | Generate audio from text using Advanced AI


<a name="speechspeaktextvoicebasicaudiopost"></a>
# **SpeechSpeakTextVoiceBasicAudioPost**
> byte[] SpeechSpeakTextVoiceBasicAudioPost (TextToSpeechRequest body = null)

Generate audio from text using Advanced AI

Converts text to speech using advanced AI. Supports English, Spanish, French, Hindi, Italian, Japanese, Portuguese, and Chinese. Specify language with LanguageCode (ISO 639-3, default: eng) and gender with Gender (Male or Female, default: Female). Output format is controlled by the Format field (mp3 or wav, default: mp3). Consumes 1 API call per second of generated audio.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NETCore.Speech.Api;
using Cloudmersive.APIClient.NETCore.Speech.Client;
using Cloudmersive.APIClient.NETCore.Speech.Model;

namespace Example
{
    public class SpeechSpeakTextVoiceBasicAudioPostExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new SpeakApi();
            var body = new TextToSpeechRequest(); // TextToSpeechRequest | String input request (optional) 

            try
            {
                // Generate audio from text using Advanced AI
                byte[] result = apiInstance.SpeechSpeakTextVoiceBasicAudioPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeakApi.SpeechSpeakTextVoiceBasicAudioPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TextToSpeechRequest**](TextToSpeechRequest.md)| String input request | [optional] 

### Return type

**byte[]**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

