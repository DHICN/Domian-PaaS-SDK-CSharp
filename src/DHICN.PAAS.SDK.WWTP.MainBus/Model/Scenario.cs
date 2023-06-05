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
using OpenAPIDateConverter = DHICN.PAAS.SDK.WWTP.MainBus.Client.OpenAPIDateConverter;

namespace DHICN.PAAS.SDK.WWTP.MainBus.Model
{
    /// <summary>
    /// Scenario
    /// </summary>
    [DataContract]
    public partial class Scenario :  IEquatable<Scenario>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Scenario" /> class.
        /// </summary>
        /// <param name="scenarioName">方案名称 scenario name.</param>
        /// <param name="value">参数值 parameter value.</param>
        public Scenario(string scenarioName = default(string), double value = default(double))
        {
            this.ScenarioName = scenarioName;
            this.Value = value;
        }
        
        /// <summary>
        /// 方案名称 scenario name
        /// </summary>
        /// <value>方案名称 scenario name</value>
        [DataMember(Name="scenarioName", EmitDefaultValue=true)]
        public string ScenarioName { get; set; }

        /// <summary>
        /// 参数值 parameter value
        /// </summary>
        /// <value>参数值 parameter value</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public double Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Scenario {\n");
            sb.Append("  ScenarioName: ").Append(ScenarioName).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as Scenario);
        }

        /// <summary>
        /// Returns true if Scenario instances are equal
        /// </summary>
        /// <param name="input">Instance of Scenario to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Scenario input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ScenarioName == input.ScenarioName ||
                    (this.ScenarioName != null &&
                    this.ScenarioName.Equals(input.ScenarioName))
                ) && 
                (
                    this.Value == input.Value ||
                    this.Value.Equals(input.Value)
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
                if (this.ScenarioName != null)
                    hashCode = hashCode * 59 + this.ScenarioName.GetHashCode();
                hashCode = hashCode * 59 + this.Value.GetHashCode();
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
