/* 
 * identity-service
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
using OpenAPIDateConverter = DHICN.PAAS.SDK.Identity.Client.OpenAPIDateConverter;

namespace DHICN.PAAS.SDK.Identity.Model
{
    /// <summary>
    /// ResultParam
    /// </summary>
    [DataContract]
    public partial class ResultParam :  IEquatable<ResultParam>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResultParam" /> class.
        /// </summary>
        /// <param name="scenarioId">方案ID scenario id.</param>
        /// <param name="resultSettings">结果设置 result setting data.</param>
        public ResultParam(Guid scenarioId = default(Guid), List<ResultSetting> resultSettings = default(List<ResultSetting>))
        {
            this.ScenarioId = scenarioId;
            this.ResultSettings = resultSettings;
        }
        
        /// <summary>
        /// 方案ID scenario id
        /// </summary>
        /// <value>方案ID scenario id</value>
        [DataMember(Name="scenarioId", EmitDefaultValue=false)]
        public Guid ScenarioId { get; set; }

        /// <summary>
        /// 结果设置 result setting data
        /// </summary>
        /// <value>结果设置 result setting data</value>
        [DataMember(Name="resultSettings", EmitDefaultValue=true)]
        public List<ResultSetting> ResultSettings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResultParam {\n");
            sb.Append("  ScenarioId: ").Append(ScenarioId).Append("\n");
            sb.Append("  ResultSettings: ").Append(ResultSettings).Append("\n");
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
            return this.Equals(input as ResultParam);
        }

        /// <summary>
        /// Returns true if ResultParam instances are equal
        /// </summary>
        /// <param name="input">Instance of ResultParam to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResultParam input)
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
                    this.ResultSettings == input.ResultSettings ||
                    this.ResultSettings != null &&
                    input.ResultSettings != null &&
                    this.ResultSettings.SequenceEqual(input.ResultSettings)
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
                if (this.ResultSettings != null)
                    hashCode = hashCode * 59 + this.ResultSettings.GetHashCode();
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