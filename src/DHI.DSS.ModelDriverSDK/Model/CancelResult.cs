/* 
 * model-driver-service
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
using OpenAPIDateConverter = DHI.DSS.ModelDriverSDK.Client.OpenAPIDateConverter;

namespace DHI.DSS.ModelDriverSDK.Model
{
    /// <summary>
    /// 取消计算响应结果
    /// </summary>
    [DataContract]
    public partial class CancelResult :  IEquatable<CancelResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CancelResult" /> class.
        /// </summary>
        /// <param name="hasError">是否有错.</param>
        /// <param name="message">消息 message.</param>
        public CancelResult(bool hasError = default(bool), string message = default(string))
        {
            this.HasError = hasError;
            this.Message = message;
        }
        
        /// <summary>
        /// 是否有错
        /// </summary>
        /// <value>是否有错</value>
        [DataMember(Name="hasError", EmitDefaultValue=false)]
        public bool HasError { get; set; }

        /// <summary>
        /// 消息 message
        /// </summary>
        /// <value>消息 message</value>
        [DataMember(Name="message", EmitDefaultValue=true)]
        public string Message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CancelResult {\n");
            sb.Append("  HasError: ").Append(HasError).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
            return this.Equals(input as CancelResult);
        }

        /// <summary>
        /// Returns true if CancelResult instances are equal
        /// </summary>
        /// <param name="input">Instance of CancelResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CancelResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.HasError == input.HasError ||
                    this.HasError.Equals(input.HasError)
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
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
                hashCode = hashCode * 59 + this.HasError.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
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
