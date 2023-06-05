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
using OpenAPIDateConverter = DHI.DSS.IdentityServiceSDK.Client.OpenAPIDateConverter;

namespace DHI.DSS.IdentityServiceSDK.Model
{
    /// <summary>
    /// CdAdditionRateOutput
    /// </summary>
    [DataContract]
    public partial class CdAdditionRateOutput :  IEquatable<CdAdditionRateOutput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CdAdditionRateOutput" /> class.
        /// </summary>
        /// <param name="code">药剂代码 dosage code.</param>
        /// <param name="calValue">计算值 calculated value.</param>
        /// <param name="value">实际值 actual value.</param>
        /// <param name="unit">单位 unit.</param>
        public CdAdditionRateOutput(string code = default(string), List<TsPair1> calValue = default(List<TsPair1>), List<TsPair1> value = default(List<TsPair1>), string unit = default(string))
        {
            this.Code = code;
            this.CalValue = calValue;
            this.Value = value;
            this.Unit = unit;
        }
        
        /// <summary>
        /// 药剂代码 dosage code
        /// </summary>
        /// <value>药剂代码 dosage code</value>
        [DataMember(Name="code", EmitDefaultValue=true)]
        public string Code { get; set; }

        /// <summary>
        /// 计算值 calculated value
        /// </summary>
        /// <value>计算值 calculated value</value>
        [DataMember(Name="calValue", EmitDefaultValue=true)]
        public List<TsPair1> CalValue { get; set; }

        /// <summary>
        /// 实际值 actual value
        /// </summary>
        /// <value>实际值 actual value</value>
        [DataMember(Name="value", EmitDefaultValue=true)]
        public List<TsPair1> Value { get; set; }

        /// <summary>
        /// 单位 unit
        /// </summary>
        /// <value>单位 unit</value>
        [DataMember(Name="unit", EmitDefaultValue=true)]
        public string Unit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CdAdditionRateOutput {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  CalValue: ").Append(CalValue).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Unit: ").Append(Unit).Append("\n");
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
            return this.Equals(input as CdAdditionRateOutput);
        }

        /// <summary>
        /// Returns true if CdAdditionRateOutput instances are equal
        /// </summary>
        /// <param name="input">Instance of CdAdditionRateOutput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CdAdditionRateOutput input)
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
                    this.CalValue == input.CalValue ||
                    this.CalValue != null &&
                    input.CalValue != null &&
                    this.CalValue.SequenceEqual(input.CalValue)
                ) && 
                (
                    this.Value == input.Value ||
                    this.Value != null &&
                    input.Value != null &&
                    this.Value.SequenceEqual(input.Value)
                ) && 
                (
                    this.Unit == input.Unit ||
                    (this.Unit != null &&
                    this.Unit.Equals(input.Unit))
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
                if (this.CalValue != null)
                    hashCode = hashCode * 59 + this.CalValue.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.Unit != null)
                    hashCode = hashCode * 59 + this.Unit.GetHashCode();
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
