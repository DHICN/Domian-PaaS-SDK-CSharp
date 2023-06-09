/* 
 * scenario-manager-service
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
using OpenAPIDateConverter = DHICN.PAAS.SDK.ScenarioManager.Client.OpenAPIDateConverter;

namespace DHICN.PAAS.SDK.ScenarioManager.Model
{
    /// <summary>
    /// UpdateScenarioPara
    /// </summary>
    [DataContract]
    public partial class UpdateScenarioPara :  IEquatable<UpdateScenarioPara>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateScenarioPara" /> class.
        /// </summary>
        /// <param name="scenarios">待更新的方案列表 scenarios to be updated.</param>
        public UpdateScenarioPara(List<Scenario> scenarios = default(List<Scenario>))
        {
            this.Scenarios = scenarios;
        }
        
        /// <summary>
        /// 待更新的方案列表 scenarios to be updated
        /// </summary>
        /// <value>待更新的方案列表 scenarios to be updated</value>
        [DataMember(Name="scenarios", EmitDefaultValue=true)]
        public List<Scenario> Scenarios { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateScenarioPara {\n");
            sb.Append("  Scenarios: ").Append(Scenarios).Append("\n");
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
            return this.Equals(input as UpdateScenarioPara);
        }

        /// <summary>
        /// Returns true if UpdateScenarioPara instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateScenarioPara to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateScenarioPara input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Scenarios == input.Scenarios ||
                    this.Scenarios != null &&
                    input.Scenarios != null &&
                    this.Scenarios.SequenceEqual(input.Scenarios)
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
                if (this.Scenarios != null)
                    hashCode = hashCode * 59 + this.Scenarios.GetHashCode();
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
