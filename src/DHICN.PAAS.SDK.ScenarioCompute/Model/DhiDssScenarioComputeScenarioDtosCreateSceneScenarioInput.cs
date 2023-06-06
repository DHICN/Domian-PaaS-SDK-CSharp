/* 
 * scenario-compute-service
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
using OpenAPIDateConverter = DHICN.PAAS.SDK.ScenarioCompute.Client.OpenAPIDateConverter;

namespace DHICN.PAAS.SDK.ScenarioCompute.Model
{
    /// <summary>
    /// DhiDssScenarioComputeScenarioDtosCreateSceneScenarioInput
    /// </summary>
    [DataContract]
    public partial class DhiDssScenarioComputeScenarioDtosCreateSceneScenarioInput :  IEquatable<DhiDssScenarioComputeScenarioDtosCreateSceneScenarioInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DhiDssScenarioComputeScenarioDtosCreateSceneScenarioInput" /> class.
        /// </summary>
        /// <param name="newScenarioName">Manual scenario name.</param>
        /// <param name="startTime">Scenario starttime.</param>
        /// <param name="endTime">Sceanrio endtime.</param>
        /// <param name="description">description.</param>
        public DhiDssScenarioComputeScenarioDtosCreateSceneScenarioInput(string newScenarioName = default(string), DateTime startTime = default(DateTime), DateTime endTime = default(DateTime), string description = default(string))
        {
            this.NewScenarioName = newScenarioName;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Description = description;
        }
        
        /// <summary>
        /// Manual scenario name
        /// </summary>
        /// <value>Manual scenario name</value>
        [DataMember(Name="newScenarioName", EmitDefaultValue=true)]
        public string NewScenarioName { get; set; }

        /// <summary>
        /// Scenario starttime
        /// </summary>
        /// <value>Scenario starttime</value>
        [DataMember(Name="startTime", EmitDefaultValue=false)]
        public DateTime StartTime { get; set; }

        /// <summary>
        /// Sceanrio endtime
        /// </summary>
        /// <value>Sceanrio endtime</value>
        [DataMember(Name="endTime", EmitDefaultValue=false)]
        public DateTime EndTime { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DhiDssScenarioComputeScenarioDtosCreateSceneScenarioInput {\n");
            sb.Append("  NewScenarioName: ").Append(NewScenarioName).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return this.Equals(input as DhiDssScenarioComputeScenarioDtosCreateSceneScenarioInput);
        }

        /// <summary>
        /// Returns true if DhiDssScenarioComputeScenarioDtosCreateSceneScenarioInput instances are equal
        /// </summary>
        /// <param name="input">Instance of DhiDssScenarioComputeScenarioDtosCreateSceneScenarioInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DhiDssScenarioComputeScenarioDtosCreateSceneScenarioInput input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NewScenarioName == input.NewScenarioName ||
                    (this.NewScenarioName != null &&
                    this.NewScenarioName.Equals(input.NewScenarioName))
                ) && 
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
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                if (this.NewScenarioName != null)
                    hashCode = hashCode * 59 + this.NewScenarioName.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
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
