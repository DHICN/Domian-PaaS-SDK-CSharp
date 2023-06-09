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
    /// AddValveInput
    /// </summary>
    [DataContract]
    public partial class AddValveInput :  IEquatable<AddValveInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddValveInput" /> class.
        /// </summary>
        /// <param name="scenarioId">方案ID scenario id.</param>
        /// <param name="valves">待新增的阀门信息列表 valves to be added.</param>
        public AddValveInput(string scenarioId = default(string), List<AddValveDto> valves = default(List<AddValveDto>))
        {
            this.ScenarioId = scenarioId;
            this.Valves = valves;
        }
        
        /// <summary>
        /// 方案ID scenario id
        /// </summary>
        /// <value>方案ID scenario id</value>
        [DataMember(Name="scenarioId", EmitDefaultValue=true)]
        public string ScenarioId { get; set; }

        /// <summary>
        /// 待新增的阀门信息列表 valves to be added
        /// </summary>
        /// <value>待新增的阀门信息列表 valves to be added</value>
        [DataMember(Name="valves", EmitDefaultValue=true)]
        public List<AddValveDto> Valves { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddValveInput {\n");
            sb.Append("  ScenarioId: ").Append(ScenarioId).Append("\n");
            sb.Append("  Valves: ").Append(Valves).Append("\n");
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
            return this.Equals(input as AddValveInput);
        }

        /// <summary>
        /// Returns true if AddValveInput instances are equal
        /// </summary>
        /// <param name="input">Instance of AddValveInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddValveInput input)
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
                    this.Valves == input.Valves ||
                    this.Valves != null &&
                    input.Valves != null &&
                    this.Valves.SequenceEqual(input.Valves)
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
                if (this.Valves != null)
                    hashCode = hashCode * 59 + this.Valves.GetHashCode();
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
