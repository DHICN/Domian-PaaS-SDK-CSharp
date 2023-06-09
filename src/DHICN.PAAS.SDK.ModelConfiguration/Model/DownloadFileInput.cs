/* 
 * model-configuration-service
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = DHICN.PAAS.SDK.ModelConfiguration.Client.OpenAPIDateConverter;

namespace DHICN.PAAS.SDK.ModelConfiguration.Model
{
    /// <summary>
    /// DownloadFileInput
    /// </summary>
    [DataContract]
    public partial class DownloadFileInput :  IEquatable<DownloadFileInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DownloadFileInput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DownloadFileInput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DownloadFileInput" /> class.
        /// </summary>
        /// <param name="fileName">模板模型文件名称 template file name (required).</param>
        public DownloadFileInput(string fileName = default(string))
        {
            // to ensure "fileName" is required (not null)
            this.FileName = fileName ?? throw new ArgumentNullException("fileName is a required property for DownloadFileInput and cannot be null");
        }
        
        /// <summary>
        /// 模板模型文件名称 template file name
        /// </summary>
        /// <value>模板模型文件名称 template file name</value>
        [DataMember(Name="fileName", EmitDefaultValue=false)]
        public string FileName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DownloadFileInput {\n");
            sb.Append("  FileName: ").Append(FileName).Append("\n");
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
            return this.Equals(input as DownloadFileInput);
        }

        /// <summary>
        /// Returns true if DownloadFileInput instances are equal
        /// </summary>
        /// <param name="input">Instance of DownloadFileInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DownloadFileInput input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FileName == input.FileName ||
                    (this.FileName != null &&
                    this.FileName.Equals(input.FileName))
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
                if (this.FileName != null)
                    hashCode = hashCode * 59 + this.FileName.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
