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
    /// GetTimeStatisticResultInput
    /// </summary>
    [DataContract]
    public partial class GetTimeStatisticResultInput :  IEquatable<GetTimeStatisticResultInput>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets SysWDDataType
        /// </summary>
        [DataMember(Name="sysWDDataType", EmitDefaultValue=false)]
        public SysWdDataTypeEnum? SysWDDataType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTimeStatisticResultInput" /> class.
        /// </summary>
        /// <param name="scenarioId">scenarioId.</param>
        /// <param name="sysWDDataType">sysWDDataType.</param>
        /// <param name="frequency">frequency.</param>
        public GetTimeStatisticResultInput(string scenarioId = default(string), SysWdDataTypeEnum? sysWDDataType = default(SysWdDataTypeEnum?), int frequency = default(int))
        {
            this.ScenarioId = scenarioId;
            this.SysWDDataType = sysWDDataType;
            this.Frequency = frequency;
        }
        
        /// <summary>
        /// Gets or Sets ScenarioId
        /// </summary>
        [DataMember(Name="scenarioId", EmitDefaultValue=true)]
        public string ScenarioId { get; set; }

        /// <summary>
        /// Gets or Sets Frequency
        /// </summary>
        [DataMember(Name="frequency", EmitDefaultValue=false)]
        public int Frequency { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetTimeStatisticResultInput {\n");
            sb.Append("  ScenarioId: ").Append(ScenarioId).Append("\n");
            sb.Append("  SysWDDataType: ").Append(SysWDDataType).Append("\n");
            sb.Append("  Frequency: ").Append(Frequency).Append("\n");
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
            return this.Equals(input as GetTimeStatisticResultInput);
        }

        /// <summary>
        /// Returns true if GetTimeStatisticResultInput instances are equal
        /// </summary>
        /// <param name="input">Instance of GetTimeStatisticResultInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetTimeStatisticResultInput input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ScenarioId == input.ScenarioId ||
                    (this.ScenarioId != null &&
                    this.ScenarioId.Equals(input.ScenarioId))
                ) && 
                (
                    this.SysWDDataType == input.SysWDDataType ||
                    this.SysWDDataType.Equals(input.SysWDDataType)
                ) && 
                (
                    this.Frequency == input.Frequency ||
                    this.Frequency.Equals(input.Frequency)
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
                if (this.ScenarioId != null)
                    hashCode = hashCode * 59 + this.ScenarioId.GetHashCode();
                hashCode = hashCode * 59 + this.SysWDDataType.GetHashCode();
                hashCode = hashCode * 59 + this.Frequency.GetHashCode();
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
