/* 
 * message-center-service
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
using OpenAPIDateConverter = DHICN.PAAS.SDK.Message.Center.Client.OpenAPIDateConverter;

namespace DHICN.PAAS.SDK.Message.Center.Model
{
    /// <summary>
    /// GetLastestMessageInput
    /// </summary>
    [DataContract]
    public partial class GetLastestMessageInput :  IEquatable<GetLastestMessageInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetLastestMessageInput" /> class.
        /// </summary>
        /// <param name="receiverUserId">接收人ID receiver&#39;s user ID.</param>
        public GetLastestMessageInput(Guid receiverUserId = default(Guid))
        {
            this.ReceiverUserId = receiverUserId;
        }
        
        /// <summary>
        /// 接收人ID receiver&#39;s user ID
        /// </summary>
        /// <value>接收人ID receiver&#39;s user ID</value>
        [DataMember(Name="receiverUserId", EmitDefaultValue=false)]
        public Guid ReceiverUserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetLastestMessageInput {\n");
            sb.Append("  ReceiverUserId: ").Append(ReceiverUserId).Append("\n");
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
            return this.Equals(input as GetLastestMessageInput);
        }

        /// <summary>
        /// Returns true if GetLastestMessageInput instances are equal
        /// </summary>
        /// <param name="input">Instance of GetLastestMessageInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetLastestMessageInput input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ReceiverUserId == input.ReceiverUserId ||
                    (this.ReceiverUserId != null &&
                    this.ReceiverUserId.Equals(input.ReceiverUserId))
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
                if (this.ReceiverUserId != null)
                    hashCode = hashCode * 59 + this.ReceiverUserId.GetHashCode();
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
