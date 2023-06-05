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
using OpenAPIDateConverter = DHI.DSS.IdentityServiceSDK.Client.OpenAPIDateConverter;

namespace DHI.DSS.IdentityServiceSDK.Model
{
    /// <summary>
    /// ToxicityInput
    /// </summary>
    [DataContract]
    public partial class ToxicityInput :  IEquatable<ToxicityInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ToxicityInput" /> class.
        /// </summary>
        /// <param name="startTime">开始时间 start time.</param>
        /// <param name="endTime">结束时间 end time.</param>
        /// <param name="location">毒性仪位置 toxicity meter location.</param>
        /// <param name="inlet">进水点 inlet.</param>
        public ToxicityInput(DateTime startTime = default(DateTime), DateTime endTime = default(DateTime), string location = default(string), string inlet = default(string))
        {
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Location = location;
            this.Inlet = inlet;
        }
        
        /// <summary>
        /// 开始时间 start time
        /// </summary>
        /// <value>开始时间 start time</value>
        [DataMember(Name="startTime", EmitDefaultValue=false)]
        public DateTime StartTime { get; set; }

        /// <summary>
        /// 结束时间 end time
        /// </summary>
        /// <value>结束时间 end time</value>
        [DataMember(Name="endTime", EmitDefaultValue=false)]
        public DateTime EndTime { get; set; }

        /// <summary>
        /// 毒性仪位置 toxicity meter location
        /// </summary>
        /// <value>毒性仪位置 toxicity meter location</value>
        [DataMember(Name="location", EmitDefaultValue=true)]
        public string Location { get; set; }

        /// <summary>
        /// 进水点 inlet
        /// </summary>
        /// <value>进水点 inlet</value>
        [DataMember(Name="inlet", EmitDefaultValue=true)]
        public string Inlet { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ToxicityInput {\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  Inlet: ").Append(Inlet).Append("\n");
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
            return this.Equals(input as ToxicityInput);
        }

        /// <summary>
        /// Returns true if ToxicityInput instances are equal
        /// </summary>
        /// <param name="input">Instance of ToxicityInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ToxicityInput input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && 
                (
                    this.Inlet == input.Inlet ||
                    (this.Inlet != null &&
                    this.Inlet.Equals(input.Inlet))
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
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.Inlet != null)
                    hashCode = hashCode * 59 + this.Inlet.GetHashCode();
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
