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
    /// OutletTnOutput
    /// </summary>
    [DataContract]
    public partial class OutletTnOutput :  IEquatable<OutletTnOutput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OutletTnOutput" /> class.
        /// </summary>
        /// <param name="code">指标代码 indicator code.</param>
        /// <param name="inletValue">实际出水水质数据 actual effluent water quality data.</param>
        /// <param name="outLetValue">模拟出水水质数据 simulated effluent water quality data.</param>
        /// <param name="unit">单位 unit.</param>
        public OutletTnOutput(string code = default(string), List<TsPair1> inletValue = default(List<TsPair1>), List<TsPair1> outLetValue = default(List<TsPair1>), string unit = default(string))
        {
            this.Code = code;
            this.InletValue = inletValue;
            this.OutLetValue = outLetValue;
            this.Unit = unit;
        }
        
        /// <summary>
        /// 指标代码 indicator code
        /// </summary>
        /// <value>指标代码 indicator code</value>
        [DataMember(Name="code", EmitDefaultValue=true)]
        public string Code { get; set; }

        /// <summary>
        /// 实际出水水质数据 actual effluent water quality data
        /// </summary>
        /// <value>实际出水水质数据 actual effluent water quality data</value>
        [DataMember(Name="inletValue", EmitDefaultValue=true)]
        public List<TsPair1> InletValue { get; set; }

        /// <summary>
        /// 模拟出水水质数据 simulated effluent water quality data
        /// </summary>
        /// <value>模拟出水水质数据 simulated effluent water quality data</value>
        [DataMember(Name="outLetValue", EmitDefaultValue=true)]
        public List<TsPair1> OutLetValue { get; set; }

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
            sb.Append("class OutletTnOutput {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  InletValue: ").Append(InletValue).Append("\n");
            sb.Append("  OutLetValue: ").Append(OutLetValue).Append("\n");
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
            return this.Equals(input as OutletTnOutput);
        }

        /// <summary>
        /// Returns true if OutletTnOutput instances are equal
        /// </summary>
        /// <param name="input">Instance of OutletTnOutput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OutletTnOutput input)
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
                    this.InletValue == input.InletValue ||
                    this.InletValue != null &&
                    input.InletValue != null &&
                    this.InletValue.SequenceEqual(input.InletValue)
                ) && 
                (
                    this.OutLetValue == input.OutLetValue ||
                    this.OutLetValue != null &&
                    input.OutLetValue != null &&
                    this.OutLetValue.SequenceEqual(input.OutLetValue)
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
                if (this.InletValue != null)
                    hashCode = hashCode * 59 + this.InletValue.GetHashCode();
                if (this.OutLetValue != null)
                    hashCode = hashCode * 59 + this.OutLetValue.GetHashCode();
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
