# Cloudmersive.APIClient.NETCore.Speech.Api.TasksBatchJobApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SpeechBatchJobRecognizeFileAdvancedPost**](TasksBatchJobApi.md#speechbatchjobrecognizefileadvancedpost) | **POST** /speech/batch-job/recognize/file/advanced | Recognize audio input as text using Advanced AI with high-accuracy word-level timestamps as a Batch Job
[**SpeechBatchJobRecognizeFilePost**](TasksBatchJobApi.md#speechbatchjobrecognizefilepost) | **POST** /speech/batch-job/recognize/file | Recognize audio input as text using Advanced AI as a Batch Job
[**SpeechBatchJobSpeakTextVoiceBasicAudioPost**](TasksBatchJobApi.md#speechbatchjobspeaktextvoicebasicaudiopost) | **POST** /speech/batch-job/speak/text/voice/basic/audio | Generate audio from text using Advanced AI as a Batch Job
[**SpeechBatchJobStatusGet**](TasksBatchJobApi.md#speechbatchjobstatusget) | **GET** /speech/batch-job/status | Get the status and result of a Speech Batch Job


<a name="speechbatchjobrecognizefileadvancedpost"></a>
# **SpeechBatchJobRecognizeFileAdvancedPost**
> SpeechBatchJobResult SpeechBatchJobRecognizeFileAdvancedPost (string languageCode = null, string recognitionMode = null, System.IO.Stream speechFile = null)

Recognize audio input as text using Advanced AI with high-accuracy word-level timestamps as a Batch Job

Creates an async batch job for transcribing a long audio file with high-accuracy word-level timestamps.  Use the GetAsyncJobStatus API to check on the status of the job and retrieve the result when complete.  Higher-accuracy variant of /speech/batch-job/recognize/file. Uses advanced alignment for token timestamps.  Supports WAV, MP3, M4A, FLAC, OGG, and WMA formats.  Consumes 1 API call per second of audio in Fast mode, 5 API calls per second in Normal mode, and 10 API calls per second in Advanced mode.  Requires Managed Instance or Private Cloud deployment.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NETCore.Speech.Api;
using Cloudmersive.APIClient.NETCore.Speech.Client;
using Cloudmersive.APIClient.NETCore.Speech.Model;

namespace Example
{
    public class SpeechBatchJobRecognizeFileAdvancedPostExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new TasksBatchJobApi();
            var languageCode = languageCode_example;  // string | ISO 639-3 three-letter language code (e.g. eng, spa, fra). Empty for auto-detect. (optional) 
            var recognitionMode = recognitionMode_example;  // string | Recognition mode: Fast, Normal (default), or Advanced. Advanced is only available on Private Cloud and Managed Instance deployments. (optional)  (default to Normal)
            var speechFile = new System.IO.Stream(); // System.IO.Stream |  (optional) 

            try
            {
                // Recognize audio input as text using Advanced AI with high-accuracy word-level timestamps as a Batch Job
                SpeechBatchJobResult result = apiInstance.SpeechBatchJobRecognizeFileAdvancedPost(languageCode, recognitionMode, speechFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksBatchJobApi.SpeechBatchJobRecognizeFileAdvancedPost: " + e.Message );
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

[**SpeechBatchJobResult**](SpeechBatchJobResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="speechbatchjobrecognizefilepost"></a>
# **SpeechBatchJobRecognizeFilePost**
> SpeechBatchJobResult SpeechBatchJobRecognizeFilePost (string languageCode = null, string recognitionMode = null, System.IO.Stream speechFile = null)

Recognize audio input as text using Advanced AI as a Batch Job

Creates an async batch job for transcribing a long audio file.  Use the GetAsyncJobStatus API to check on the status of the job and retrieve the result when complete.  Uses advanced AI to convert input audio to text.  Supports WAV, MP3, M4A, FLAC, OGG, and WMA formats.  Consumes 1 API call per second of audio in Fast mode, 5 API calls per second in Normal mode, and 10 API calls per second in Advanced mode.  Requires Managed Instance or Private Cloud deployment.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NETCore.Speech.Api;
using Cloudmersive.APIClient.NETCore.Speech.Client;
using Cloudmersive.APIClient.NETCore.Speech.Model;

namespace Example
{
    public class SpeechBatchJobRecognizeFilePostExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new TasksBatchJobApi();
            var languageCode = languageCode_example;  // string | ISO 639-3 three-letter language code (e.g. eng, spa, fra). Empty for auto-detect. (optional) 
            var recognitionMode = recognitionMode_example;  // string | Recognition mode: Fast, Normal (default), or Advanced. Advanced is only available on Private Cloud and Managed Instance deployments. (optional)  (default to Normal)
            var speechFile = new System.IO.Stream(); // System.IO.Stream |  (optional) 

            try
            {
                // Recognize audio input as text using Advanced AI as a Batch Job
                SpeechBatchJobResult result = apiInstance.SpeechBatchJobRecognizeFilePost(languageCode, recognitionMode, speechFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksBatchJobApi.SpeechBatchJobRecognizeFilePost: " + e.Message );
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

[**SpeechBatchJobResult**](SpeechBatchJobResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="speechbatchjobspeaktextvoicebasicaudiopost"></a>
# **SpeechBatchJobSpeakTextVoiceBasicAudioPost**
> SpeechBatchJobResult SpeechBatchJobSpeakTextVoiceBasicAudioPost (TextToSpeechRequest body = null)

Generate audio from text using Advanced AI as a Batch Job

Creates an async batch job for converting long-form text to speech.  Use the GetAsyncJobStatus API to check on the status of the job and retrieve the generated audio when complete.  Converts text to speech using advanced AI.  Supports English, Spanish, French, Hindi, Italian, Japanese, Portuguese, and Chinese.  Specify language with LanguageCode (ISO 639-3, default: eng) and gender with Gender (Male or Female, default: Female).  Output format is controlled by the Format field (mp3 or wav, default: mp3).  Consumes 1 API call per second of generated audio.  Requires Managed Instance or Private Cloud deployment.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NETCore.Speech.Api;
using Cloudmersive.APIClient.NETCore.Speech.Client;
using Cloudmersive.APIClient.NETCore.Speech.Model;

namespace Example
{
    public class SpeechBatchJobSpeakTextVoiceBasicAudioPostExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new TasksBatchJobApi();
            var body = new TextToSpeechRequest(); // TextToSpeechRequest | String input request (optional) 

            try
            {
                // Generate audio from text using Advanced AI as a Batch Job
                SpeechBatchJobResult result = apiInstance.SpeechBatchJobSpeakTextVoiceBasicAudioPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksBatchJobApi.SpeechBatchJobSpeakTextVoiceBasicAudioPost: " + e.Message );
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

[**SpeechBatchJobResult**](SpeechBatchJobResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="speechbatchjobstatusget"></a>
# **SpeechBatchJobStatusGet**
> SpeechBatchJobStatusResult SpeechBatchJobStatusGet (string asyncJobID = null)

Get the status and result of a Speech Batch Job

Returns the result of the Async Job - possible states can be STARTED or COMPLETED.  When COMPLETED, the corresponding result field (Recognize transcription, or generated Text-to-Speech audio) is populated on the response.  This API is only available for Cloudmersive Managed Instance and Private Cloud deployments.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NETCore.Speech.Api;
using Cloudmersive.APIClient.NETCore.Speech.Client;
using Cloudmersive.APIClient.NETCore.Speech.Model;

namespace Example
{
    public class SpeechBatchJobStatusGetExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new TasksBatchJobApi();
            var asyncJobID = asyncJobID_example;  // string | Job ID for the batch job to get the status of (optional) 

            try
            {
                // Get the status and result of a Speech Batch Job
                SpeechBatchJobStatusResult result = apiInstance.SpeechBatchJobStatusGet(asyncJobID);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksBatchJobApi.SpeechBatchJobStatusGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **asyncJobID** | **string**| Job ID for the batch job to get the status of | [optional] 

### Return type

[**SpeechBatchJobStatusResult**](SpeechBatchJobStatusResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

