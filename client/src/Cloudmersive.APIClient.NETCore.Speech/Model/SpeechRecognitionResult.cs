/* 
 * speechapi
 *
 * Speech APIs enable you to recognize speech and convert it to text using advanced machine learning, and also to convert text to speech.
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = Cloudmersive.APIClient.NETCore.Speech.Client.SwaggerDateConverter;

namespace Cloudmersive.APIClient.NETCore.Speech.Model
{
    /// <summary>
    /// Result of recognizing speech
    /// </summary>
    [DataContract]
    public partial class SpeechRecognitionResult :  IEquatable<SpeechRecognitionResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechRecognitionResult" /> class.
        /// </summary>
        /// <param name="textResult">Recognition result in text format.</param>
        public SpeechRecognitionResult(string textResult = default(string))
        {
            this.TextResult = textResult;
        }
        
        /// <summary>
        /// Recognition result in text format
        /// </summary>
        /// <value>Recognition result in text format</value>
        [DataMember(Name="TextResult", EmitDefaultValue=false)]
        public string TextResult { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SpeechRecognitionResult {\n");
            sb.Append("  TextResult: ").Append(TextResult).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as SpeechRecognitionResult);
        }

        /// <summary>
        /// Returns true if SpeechRecognitionResult instances are equal
        /// </summary>
        /// <param name="input">Instance of SpeechRecognitionResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SpeechRecognitionResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TextResult == input.TextResult ||
                    (this.TextResult != null &&
                    this.TextResult.Equals(input.TextResult))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.TextResult != null)
                    hashCode = hashCode * 59 + this.TextResult.GetHashCode();
                return hashCode;
            }
        }
    }

}
