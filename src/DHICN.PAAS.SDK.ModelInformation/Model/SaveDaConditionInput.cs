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
    /// SaveDaConditionInput
    /// </summary>
    [DataContract]
    public partial class SaveDaConditionInput :  IEquatable<SaveDaConditionInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SaveDaConditionInput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SaveDaConditionInput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SaveDaConditionInput" /> class.
        /// </summary>
        /// <param name="scenarioId">方案Id scenario id (required).</param>
        /// <param name="daConditions">实时校正点数据 DA condition data (required).</param>
        public SaveDaConditionInput(Guid scenarioId = default(Guid), List<DaConditionDto> daConditions = default(List<DaConditionDto>))
        {
            this.ScenarioId = scenarioId;
            // to ensure "daConditions" is required (not null)
            this.DaConditions = daConditions ?? throw new ArgumentNullException("daConditions is a required property for SaveDaConditionInput and cannot be null");
        }
        
        /// <summary>
        /// 方案Id scenario id
        /// </summary>
        /// <value>方案Id scenario id</value>
        [DataMember(Name="scenarioId", EmitDefaultValue=false)]
        public Guid ScenarioId { get; set; }

        /// <summary>
        /// 实时校正点数据 DA condition data
        /// </summary>
        /// <value>实时校正点数据 DA condition data</value>
        [DataMember(Name="daConditions", EmitDefaultValue=false)]
        public List<DaConditionDto> DaConditions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SaveDaConditionInput {\n");
            sb.Append("  ScenarioId: ").Append(ScenarioId).Append("\n");
            sb.Append("  DaConditions: ").Append(DaConditions).Append("\n");
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
            return this.Equals(input as SaveDaConditionInput);
        }

        /// <summary>
        /// Returns true if SaveDaConditionInput instances are equal
        /// </summary>
        /// <param name="input">Instance of SaveDaConditionInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SaveDaConditionInput input)
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
                    this.DaConditions == input.DaConditions ||
                    this.DaConditions != null &&
                    input.DaConditions != null &&
                    this.DaConditions.SequenceEqual(input.DaConditions)
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
                if (this.DaConditions != null)
                    hashCode = hashCode * 59 + this.DaConditions.GetHashCode();
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
