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
    /// DeleteScenarioGroupPara
    /// </summary>
    [DataContract]
    public partial class DeleteScenarioGroupPara :  IEquatable<DeleteScenarioGroupPara>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteScenarioGroupPara" /> class.
        /// </summary>
        /// <param name="scenarioGroupId">方案组ID scenario&#39;s group Id.</param>
        public DeleteScenarioGroupPara(string scenarioGroupId = default(string))
        {
            this.ScenarioGroupId = scenarioGroupId;
        }
        
        /// <summary>
        /// 方案组ID scenario&#39;s group Id
        /// </summary>
        /// <value>方案组ID scenario&#39;s group Id</value>
        [DataMember(Name="scenarioGroupId", EmitDefaultValue=true)]
        public string ScenarioGroupId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteScenarioGroupPara {\n");
            sb.Append("  ScenarioGroupId: ").Append(ScenarioGroupId).Append("\n");
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
            return this.Equals(input as DeleteScenarioGroupPara);
        }

        /// <summary>
        /// Returns true if DeleteScenarioGroupPara instances are equal
        /// </summary>
        /// <param name="input">Instance of DeleteScenarioGroupPara to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeleteScenarioGroupPara input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ScenarioGroupId == input.ScenarioGroupId ||
                    (this.ScenarioGroupId != null &&
                    this.ScenarioGroupId.Equals(input.ScenarioGroupId))
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
                if (this.ScenarioGroupId != null)
                    hashCode = hashCode * 59 + this.ScenarioGroupId.GetHashCode();
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