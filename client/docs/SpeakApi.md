# Cloudmersive.APIClient.NETCore.Speech.Api.SpeakApi

All URIs are relative to *https://api.cloudmersive.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SpeakPost**](SpeakApi.md#speakpost) | **POST** /speech/speak/text/basicVoice/{format} | Perform text-to-speech on a string
[**SpeakTextToSpeech**](SpeakApi.md#speaktexttospeech) | **POST** /speech/speak/text/voice/basic/audio | Perform text-to-speech on a string


<a name="speakpost"></a>
# **SpeakPost**
> Object SpeakPost (string format, string text)

Perform text-to-speech on a string

Takes as input a string and a file format (mp3 or wav) and outputs a wave form in the appropriate format.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NETCore.Speech.Api;
using Cloudmersive.APIClient.NETCore.Speech.Client;
using Cloudmersive.APIClient.NETCore.Speech.Model;

namespace Example
{
    public class SpeakPostExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new SpeakApi();
            var format = format_example;  // string | File format to generate response in; possible values are \"mp3\" or \"wav\"
            var text = text_example;  // string | The text you would like to conver to speech.  Be sure to surround with quotes, e.g. \"The quick brown fox jumps over the lazy dog.\"

            try
            {
                // Perform text-to-speech on a string
                Object result = apiInstance.SpeakPost(format, text);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeakApi.SpeakPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **string**| File format to generate response in; possible values are \&quot;mp3\&quot; or \&quot;wav\&quot; | 
 **text** | **string**| The text you would like to conver to speech.  Be sure to surround with quotes, e.g. \&quot;The quick brown fox jumps over the lazy dog.\&quot; | 

### Return type

**Object**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="speaktexttospeech"></a>
# **SpeakTextToSpeech**
> Object SpeakTextToSpeech (TextToSpeechRequest reqConfig)

Perform text-to-speech on a string

Takes as input a string and a file format (mp3 or wav) and outputs a wave form in the appropriate format.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NETCore.Speech.Api;
using Cloudmersive.APIClient.NETCore.Speech.Client;
using Cloudmersive.APIClient.NETCore.Speech.Model;

namespace Example
{
    public class SpeakTextToSpeechExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new SpeakApi();
            var reqConfig = new TextToSpeechRequest(); // TextToSpeechRequest | String input request

            try
            {
                // Perform text-to-speech on a string
                Object result = apiInstance.SpeakTextToSpeech(reqConfig);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeakApi.SpeakTextToSpeech: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **reqConfig** | [**TextToSpeechRequest**](TextToSpeechRequest.md)| String input request | 

### Return type

**Object**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

