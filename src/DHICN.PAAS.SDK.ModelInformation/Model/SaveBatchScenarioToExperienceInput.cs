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
    /// SaveBatchScenarioToExperienceInput
    /// </summary>
    [DataContract]
    public partial class SaveBatchScenarioToExperienceInput :  IEquatable<SaveBatchScenarioToExperienceInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SaveBatchScenarioToExperienceInput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SaveBatchScenarioToExperienceInput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SaveBatchScenarioToExperienceInput" /> class.
        /// </summary>
        /// <param name="scenarioIds">Scenario id (required).</param>
        public SaveBatchScenarioToExperienceInput(List<Guid> scenarioIds = default(List<Guid>))
        {
            // to ensure "scenarioIds" is required (not null)
            this.ScenarioIds = scenarioIds ?? throw new ArgumentNullException("scenarioIds is a required property for SaveBatchScenarioToExperienceInput and cannot be null");
        }
        
        /// <summary>
        /// Scenario id
        /// </summary>
        /// <value>Scenario id</value>
        [DataMember(Name="scenarioIds", EmitDefaultValue=false)]
        public List<Guid> ScenarioIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SaveBatchScenarioToExperienceInput {\n");
            sb.Append("  ScenarioIds: ").Append(ScenarioIds).Append("\n");
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
            return this.Equals(input as SaveBatchScenarioToExperienceInput);
        }

        /// <summary>
        /// Returns true if SaveBatchScenarioToExperienceInput instances are equal
        /// </summary>
        /// <param name="input">Instance of SaveBatchScenarioToExperienceInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SaveBatchScenarioToExperienceInput input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ScenarioIds == input.ScenarioIds ||
                    this.ScenarioIds != null &&
                    input.ScenarioIds != null &&
                    this.ScenarioIds.SequenceEqual(input.ScenarioIds)
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
                if (this.ScenarioIds != null)
                    hashCode = hashCode * 59 + this.ScenarioIds.GetHashCode();
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
