# Cloudmersive.APIClient.NETCore.Speech.Model.SpeechBatchJobStatusResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Successful** | **bool?** | True if the operation to check the status of the job was successful, false otherwise | [optional] 
**AsyncJobStatus** | **string** | Returns the job status of the Async Job, if applicable.  Possible states are STARTED and COMPLETED | [optional] 
**AsyncJobID** | **string** | Job ID | [optional] 
**RecognizeResult** | [**SpeechRecognitionResult**](SpeechRecognitionResult.md) |  | [optional] 
**RecognizeAdvancedResult** | [**SpeechRecognitionResultAdvanced**](SpeechRecognitionResultAdvanced.md) |  | [optional] 
**SpeakAudioResultFileContent** | **byte[]** | Generated audio file produced by a completed Text-to-Speech batch job, in the requested format (mp3 or wav) | [optional] 
**SpeakAudioContentType** | **string** | MIME type of SpeakAudioResultFileContent (audio/mpeg or audio/wav) | [optional] 
**ErrorMessage** | **string** | Error message (if any) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

