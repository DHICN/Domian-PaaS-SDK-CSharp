/* 
 * wwtp-paas-main-bus-service
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
using OpenAPIDateConverter = wwtp_paas_main_bus_service.Client.OpenAPIDateConverter;

namespace wwtp_paas_main_bus_service.Model
{
    /// <summary>
    /// DeleteScenarioInput
    /// </summary>
    [DataContract]
    public partial class DeleteScenarioInput :  IEquatable<DeleteScenarioInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteScenarioInput" /> class.
        /// </summary>
        /// <param name="scenarioIds">方案ID列表 scenario id list.</param>
        public DeleteScenarioInput(List<Guid> scenarioIds = default(List<Guid>))
        {
            this.ScenarioIds = scenarioIds;
        }
        
        /// <summary>
        /// 方案ID列表 scenario id list
        /// </summary>
        /// <value>方案ID列表 scenario id list</value>
        [DataMember(Name="scenarioIds", EmitDefaultValue=true)]
        public List<Guid> ScenarioIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteScenarioInput {\n");
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
            return this.Equals(input as DeleteScenarioInput);
        }

        /// <summary>
        /// Returns true if DeleteScenarioInput instances are equal
        /// </summary>
        /// <param name="input">Instance of DeleteScenarioInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeleteScenarioInput input)
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