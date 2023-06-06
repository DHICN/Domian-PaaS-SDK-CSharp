/* 
 * model-information-service
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
using OpenAPIDateConverter = DHICN.PAAS.SDK.ModelInformation.Client.OpenAPIDateConverter;

namespace DHICN.PAAS.SDK.ModelInformation.Model
{
    /// <summary>
    /// SaveScenarioToExperienceInput
    /// </summary>
    [DataContract]
    public partial class SaveScenarioToExperienceInput :  IEquatable<SaveScenarioToExperienceInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SaveScenarioToExperienceInput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SaveScenarioToExperienceInput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SaveScenarioToExperienceInput" /> class.
        /// </summary>
        /// <param name="scenarioId">Scenario id (required).</param>
        /// <param name="experienceName">经验（专家）库名称.</param>
        public SaveScenarioToExperienceInput(Guid scenarioId = default(Guid), string experienceName = default(string))
        {
            this.ScenarioId = scenarioId;
            this.ExperienceName = experienceName;
        }
        
        /// <summary>
        /// Scenario id
        /// </summary>
        /// <value>Scenario id</value>
        [DataMember(Name="scenarioId", EmitDefaultValue=false)]
        public Guid ScenarioId { get; set; }

        /// <summary>
        /// 经验（专家）库名称
        /// </summary>
        /// <value>经验（专家）库名称</value>
        [DataMember(Name="experienceName", EmitDefaultValue=true)]
        public string ExperienceName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SaveScenarioToExperienceInput {\n");
            sb.Append("  ScenarioId: ").Append(ScenarioId).Append("\n");
            sb.Append("  ExperienceName: ").Append(ExperienceName).Append("\n");
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
            return this.Equals(input as SaveScenarioToExperienceInput);
        }

        /// <summary>
        /// Returns true if SaveScenarioToExperienceInput instances are equal
        /// </summary>
        /// <param name="input">Instance of SaveScenarioToExperienceInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SaveScenarioToExperienceInput input)
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
                    this.ExperienceName == input.ExperienceName ||
                    (this.ExperienceName != null &&
                    this.ExperienceName.Equals(input.ExperienceName))
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
                if (this.ExperienceName != null)
                    hashCode = hashCode * 59 + this.ExperienceName.GetHashCode();
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
