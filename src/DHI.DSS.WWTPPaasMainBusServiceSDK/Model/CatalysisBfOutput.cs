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
using OpenAPIDateConverter = DHI.DSS.WWTPPaasMainBusServiceSDK.Client.OpenAPIDateConverter;

namespace DHI.DSS.WWTPPaasMainBusServiceSDK.Model
{
    /// <summary>
    /// CatalysisBfOutput
    /// </summary>
    [DataContract]
    public partial class CatalysisBfOutput :  IEquatable<CatalysisBfOutput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CatalysisBfOutput" /> class.
        /// </summary>
        /// <param name="code">指标代码 indicator code.</param>
        /// <param name="unit">单位 unit.</param>
        /// <param name="valuesBefore">催化反应前时间序列 time-series result before catalysis.</param>
        /// <param name="valuesAfter">催化反应后时间序列 time-series result after catalysis.</param>
        public CatalysisBfOutput(string code = default(string), string unit = default(string), List<TsPair1> valuesBefore = default(List<TsPair1>), List<TsPair1> valuesAfter = default(List<TsPair1>))
        {
            this.Code = code;
            this.Unit = unit;
            this.ValuesBefore = valuesBefore;
            this.ValuesAfter = valuesAfter;
        }
        
        /// <summary>
        /// 指标代码 indicator code
        /// </summary>
        /// <value>指标代码 indicator code</value>
        [DataMember(Name="code", EmitDefaultValue=true)]
        public string Code { get; set; }

        /// <summary>
        /// 单位 unit
        /// </summary>
        /// <value>单位 unit</value>
        [DataMember(Name="unit", EmitDefaultValue=true)]
        public string Unit { get; set; }

        /// <summary>
        /// 催化反应前时间序列 time-series result before catalysis
        /// </summary>
        /// <value>催化反应前时间序列 time-series result before catalysis</value>
        [DataMember(Name="valuesBefore", EmitDefaultValue=true)]
        public List<TsPair1> ValuesBefore { get; set; }

        /// <summary>
        /// 催化反应后时间序列 time-series result after catalysis
        /// </summary>
        /// <value>催化反应后时间序列 time-series result after catalysis</value>
        [DataMember(Name="valuesAfter", EmitDefaultValue=true)]
        public List<TsPair1> ValuesAfter { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CatalysisBfOutput {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Unit: ").Append(Unit).Append("\n");
            sb.Append("  ValuesBefore: ").Append(ValuesBefore).Append("\n");
            sb.Append("  ValuesAfter: ").Append(ValuesAfter).Append("\n");
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
            return this.Equals(input as CatalysisBfOutput);
        }

        /// <summary>
        /// Returns true if CatalysisBfOutput instances are equal
        /// </summary>
        /// <param name="input">Instance of CatalysisBfOutput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CatalysisBfOutput input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Unit == input.Unit ||
                    (this.Unit != null &&
                    this.Unit.Equals(input.Unit))
                ) && 
                (
                    this.ValuesBefore == input.ValuesBefore ||
                    this.ValuesBefore != null &&
                    input.ValuesBefore != null &&
                    this.ValuesBefore.SequenceEqual(input.ValuesBefore)
                ) && 
                (
                    this.ValuesAfter == input.ValuesAfter ||
                    this.ValuesAfter != null &&
                    input.ValuesAfter != null &&
                    this.ValuesAfter.SequenceEqual(input.ValuesAfter)
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
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Unit != null)
                    hashCode = hashCode * 59 + this.Unit.GetHashCode();
                if (this.ValuesBefore != null)
                    hashCode = hashCode * 59 + this.ValuesBefore.GetHashCode();
                if (this.ValuesAfter != null)
                    hashCode = hashCode * 59 + this.ValuesAfter.GetHashCode();
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
