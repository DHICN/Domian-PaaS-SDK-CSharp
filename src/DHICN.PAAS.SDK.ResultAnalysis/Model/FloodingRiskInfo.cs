/* 
 * result-analysis-service
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
using OpenAPIDateConverter = DHICN.PAAS.SDK.ResultAnalysis.Client.OpenAPIDateConverter;

namespace DHICN.PAAS.SDK.ResultAnalysis.Model
{
    /// <summary>
    /// FloodingRiskInfo
    /// </summary>
    [DataContract]
    public partial class FloodingRiskInfo :  IEquatable<FloodingRiskInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FloodingRiskInfo" /> class.
        /// </summary>
        /// <param name="grade">内涝风险等级 flood risk grade.</param>
        /// <param name="data">data.</param>
        public FloodingRiskInfo(int grade = default(int), FloodingRiskItem data = default(FloodingRiskItem))
        {
            this.Grade = grade;
            this.Data = data;
        }
        
        /// <summary>
        /// 内涝风险等级 flood risk grade
        /// </summary>
        /// <value>内涝风险等级 flood risk grade</value>
        [DataMember(Name="grade", EmitDefaultValue=false)]
        public int Grade { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public FloodingRiskItem Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FloodingRiskInfo {\n");
            sb.Append("  Grade: ").Append(Grade).Append("\n");
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
            return this.Equals(input as FloodingRiskInfo);
        }

        /// <summary>
        /// Returns true if FloodingRiskInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of FloodingRiskInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FloodingRiskInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Grade == input.Grade ||
                    this.Grade.Equals(input.Grade)
                ) && 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
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
                hashCode = hashCode * 59 + this.Grade.GetHashCode();
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
