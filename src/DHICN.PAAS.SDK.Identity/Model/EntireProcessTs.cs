/* 
 * identity-service
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
using OpenAPIDateConverter = DHICN.PAAS.SDK.Identity.Client.OpenAPIDateConverter;

namespace DHICN.PAAS.SDK.Identity.Model
{
    /// <summary>
    /// EntireProcessTs
    /// </summary>
    [DataContract]
    public partial class EntireProcessTs :  IEquatable<EntireProcessTs>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EntireProcessTs" /> class.
        /// </summary>
        /// <param name="time">时间 time.</param>
        /// <param name="data">全流程水质数据 data of each biochemical pool.</param>
        public EntireProcessTs(DateTime time = default(DateTime), List<BioValue> data = default(List<BioValue>))
        {
            this.Time = time;
            this.Data = data;
        }
        
        /// <summary>
        /// 时间 time
        /// </summary>
        /// <value>时间 time</value>
        [DataMember(Name="time", EmitDefaultValue=false)]
        public DateTime Time { get; set; }

        /// <summary>
        /// 全流程水质数据 data of each biochemical pool
        /// </summary>
        /// <value>全流程水质数据 data of each biochemical pool</value>
        [DataMember(Name="data", EmitDefaultValue=true)]
        public List<BioValue> Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EntireProcessTs {\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
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
            return this.Equals(input as EntireProcessTs);
        }

        /// <summary>
        /// Returns true if EntireProcessTs instances are equal
        /// </summary>
        /// <param name="input">Instance of EntireProcessTs to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EntireProcessTs input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Time == input.Time ||
                    (this.Time != null &&
                    this.Time.Equals(input.Time))
                ) && 
                (
                    this.Data == input.Data ||
                    this.Data != null &&
                    input.Data != null &&
                    this.Data.SequenceEqual(input.Data)
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
                if (this.Time != null)
                    hashCode = hashCode * 59 + this.Time.GetHashCode();
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
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
