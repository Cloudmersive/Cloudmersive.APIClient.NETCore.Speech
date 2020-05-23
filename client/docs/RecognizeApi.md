# Cloudmersive.APIClient.NETCore.Speech.Api.RecognizeApi

All URIs are relative to *https://api.cloudmersive.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**RecognizeFile**](RecognizeApi.md#recognizefile) | **POST** /speech/recognize/file | Recognize audio input as text using machine learning


<a name="recognizefile"></a>
# **RecognizeFile**
> SpeechRecognitionResult RecognizeFile (System.IO.Stream speechFile)

Recognize audio input as text using machine learning

Uses advanced machine learning to convert input audio, which can be mp3 or wav, into text.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NETCore.Speech.Api;
using Cloudmersive.APIClient.NETCore.Speech.Client;
using Cloudmersive.APIClient.NETCore.Speech.Model;

namespace Example
{
    public class RecognizeFileExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

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

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **speechFile** | **System.IO.Stream**| Speech file to perform the operation on.  Common file formats such as WAV, MP3 are supported. | 

### Return type

[**SpeechRecognitionResult**](SpeechRecognitionResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

