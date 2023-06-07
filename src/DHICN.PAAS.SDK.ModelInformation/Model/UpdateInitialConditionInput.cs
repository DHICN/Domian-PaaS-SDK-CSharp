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
    /// UpdateInitialConditionInput
    /// </summary>
    [DataContract]
    public partial class UpdateInitialConditionInput :  IEquatable<UpdateInitialConditionInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateInitialConditionInput" /> class.
        /// </summary>
        /// <param name="scenarioId">热启动方案ID hotstart scenario id.</param>
        /// <param name="hotstartFiles">hotstartFiles.</param>
        public UpdateInitialConditionInput(string scenarioId = default(string), InitialCondition hotstartFiles = default(InitialCondition))
        {
            this.ScenarioId = scenarioId;
            this.HotstartFiles = hotstartFiles;
        }
        
        /// <summary>
        /// 热启动方案ID hotstart scenario id
        /// </summary>
        /// <value>热启动方案ID hotstart scenario id</value>
        [DataMember(Name="scenarioId", EmitDefaultValue=true)]
        public string ScenarioId { get; set; }

        /// <summary>
        /// Gets or Sets HotstartFiles
        /// </summary>
        [DataMember(Name="hotstartFiles", EmitDefaultValue=false)]
        public InitialCondition HotstartFiles { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateInitialConditionInput {\n");
            sb.Append("  ScenarioId: ").Append(ScenarioId).Append("\n");
            sb.Append("  HotstartFiles: ").Append(HotstartFiles).Append("\n");
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
            return this.Equals(input as UpdateInitialConditionInput);
        }

        /// <summary>
        /// Returns true if UpdateInitialConditionInput instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateInitialConditionInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateInitialConditionInput input)
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
                    this.HotstartFiles == input.HotstartFiles ||
                    (this.HotstartFiles != null &&
                    this.HotstartFiles.Equals(input.HotstartFiles))
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
                if (this.HotstartFiles != null)
                    hashCode = hashCode * 59 + this.HotstartFiles.GetHashCode();
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