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
    /// GetPatternTsListyModelIdInput
    /// </summary>
    [DataContract]
    public partial class GetPatternTsListyModelIdInput :  IEquatable<GetPatternTsListyModelIdInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetPatternTsListyModelIdInput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetPatternTsListyModelIdInput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetPatternTsListyModelIdInput" /> class.
        /// </summary>
        /// <param name="scenarioId">方案Id scenario id (required).</param>
        /// <param name="modelIds">模型中模式ID列表 pattern muids (required).</param>
        public GetPatternTsListyModelIdInput(string scenarioId = default(string), List<string> modelIds = default(List<string>))
        {
            // to ensure "scenarioId" is required (not null)
            this.ScenarioId = scenarioId ?? throw new ArgumentNullException("scenarioId is a required property for GetPatternTsListyModelIdInput and cannot be null");
            // to ensure "modelIds" is required (not null)
            this.ModelIds = modelIds ?? throw new ArgumentNullException("modelIds is a required property for GetPatternTsListyModelIdInput and cannot be null");
        }
        
        /// <summary>
        /// 方案Id scenario id
        /// </summary>
        /// <value>方案Id scenario id</value>
        [DataMember(Name="scenarioId", EmitDefaultValue=false)]
        public string ScenarioId { get; set; }

        /// <summary>
        /// 模型中模式ID列表 pattern muids
        /// </summary>
        /// <value>模型中模式ID列表 pattern muids</value>
        [DataMember(Name="modelIds", EmitDefaultValue=false)]
        public List<string> ModelIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetPatternTsListyModelIdInput {\n");
            sb.Append("  ScenarioId: ").Append(ScenarioId).Append("\n");
            sb.Append("  ModelIds: ").Append(ModelIds).Append("\n");
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
            return this.Equals(input as GetPatternTsListyModelIdInput);
        }

        /// <summary>
        /// Returns true if GetPatternTsListyModelIdInput instances are equal
        /// </summary>
        /// <param name="input">Instance of GetPatternTsListyModelIdInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetPatternTsListyModelIdInput input)
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
                    this.ModelIds == input.ModelIds ||
                    this.ModelIds != null &&
                    input.ModelIds != null &&
                    this.ModelIds.SequenceEqual(input.ModelIds)
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
                if (this.ModelIds != null)
                    hashCode = hashCode * 59 + this.ModelIds.GetHashCode();
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