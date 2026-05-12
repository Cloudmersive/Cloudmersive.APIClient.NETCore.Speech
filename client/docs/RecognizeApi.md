# Cloudmersive.APIClient.NETCore.Speech.Api.RecognizeApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SpeechRecognizeFileAdvancedPost**](RecognizeApi.md#speechrecognizefileadvancedpost) | **POST** /speech/recognize/file/advanced | Recognize audio input as text using Advanced AI with high-accuracy word-level timestamps
[**SpeechRecognizeFilePost**](RecognizeApi.md#speechrecognizefilepost) | **POST** /speech/recognize/file | Recognize audio input as text using Advanced AI


<a name="speechrecognizefileadvancedpost"></a>
# **SpeechRecognizeFileAdvancedPost**
> SpeechRecognitionResultAdvanced SpeechRecognizeFileAdvancedPost (string languageCode = null, string recognitionMode = null, System.IO.Stream speechFile = null)

Recognize audio input as text using Advanced AI with high-accuracy word-level timestamps

Higher-accuracy variant of /speech/recognize/file. Uses advanced  alignment for token timestamps.  Supports WAV, MP3, M4A, FLAC, OGG, and WMA formats.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NETCore.Speech.Api;
using Cloudmersive.APIClient.NETCore.Speech.Client;
using Cloudmersive.APIClient.NETCore.Speech.Model;

namespace Example
{
    public class SpeechRecognizeFileAdvancedPostExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new RecognizeApi();
            var languageCode = languageCode_example;  // string | ISO 639-3 three-letter language code (e.g. eng, spa, fra). Empty for auto-detect. (optional) 
            var recognitionMode = recognitionMode_example;  // string | Recognition mode: Fast, Normal (default), or Advanced. Advanced is only available on Private Cloud and Managed Instance deployments. (optional)  (default to Normal)
            var speechFile = new System.IO.Stream(); // System.IO.Stream |  (optional) 

            try
            {
                // Recognize audio input as text using Advanced AI with high-accuracy word-level timestamps
                SpeechRecognitionResultAdvanced result = apiInstance.SpeechRecognizeFileAdvancedPost(languageCode, recognitionMode, speechFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecognizeApi.SpeechRecognizeFileAdvancedPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **languageCode** | **string**| ISO 639-3 three-letter language code (e.g. eng, spa, fra). Empty for auto-detect. | [optional] 
 **recognitionMode** | **string**| Recognition mode: Fast, Normal (default), or Advanced. Advanced is only available on Private Cloud and Managed Instance deployments. | [optional] [default to Normal]
 **speechFile** | **System.IO.Stream**|  | [optional] 

### Return type

[**SpeechRecognitionResultAdvanced**](SpeechRecognitionResultAdvanced.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="speechrecognizefilepost"></a>
# **SpeechRecognizeFilePost**
> SpeechRecognitionResult SpeechRecognizeFilePost (string languageCode = null, string recognitionMode = null, System.IO.Stream speechFile = null)

Recognize audio input as text using Advanced AI

Uses advanced AI to convert input audio to text. Supports WAV, MP3, M4A, FLAC, OGG, and WMA formats. Consumes 1 API call per second of audio in Fast mode, 5 API calls per second in Normal mode, and 10 API calls per second in Advanced mode.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NETCore.Speech.Api;
using Cloudmersive.APIClient.NETCore.Speech.Client;
using Cloudmersive.APIClient.NETCore.Speech.Model;

namespace Example
{
    public class SpeechRecognizeFilePostExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

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

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **languageCode** | **string**| ISO 639-3 three-letter language code (e.g. eng, spa, fra). Empty for auto-detect. | [optional] 
 **recognitionMode** | **string**| Recognition mode: Fast, Normal (default), or Advanced. Advanced is only available on Private Cloud and Managed Instance deployments. | [optional] [default to Normal]
 **speechFile** | **System.IO.Stream**|  | [optional] 

### Return type

[**SpeechRecognitionResult**](SpeechRecognitionResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

