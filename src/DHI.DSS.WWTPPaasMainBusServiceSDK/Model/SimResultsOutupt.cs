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
    /// SimResultsOutupt
    /// </summary>
    [DataContract]
    public partial class SimResultsOutupt :  IEquatable<SimResultsOutupt>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SimResultsOutupt" /> class.
        /// </summary>
        /// <param name="code">指标代码 indicator code.</param>
        /// <param name="outWatersUnit">指标单位 indicator unit.</param>
        /// <param name="outWaters">时间序列数据 time-series data.</param>
        public SimResultsOutupt(string code = default(string), string outWatersUnit = default(string), List<TsPair1> outWaters = default(List<TsPair1>))
        {
            this.Code = code;
            this.OutWatersUnit = outWatersUnit;
            this.OutWaters = outWaters;
        }
        
        /// <summary>
        /// 指标代码 indicator code
        /// </summary>
        /// <value>指标代码 indicator code</value>
        [DataMember(Name="code", EmitDefaultValue=true)]
        public string Code { get; set; }

        /// <summary>
        /// 指标单位 indicator unit
        /// </summary>
        /// <value>指标单位 indicator unit</value>
        [DataMember(Name="outWatersUnit", EmitDefaultValue=true)]
        public string OutWatersUnit { get; set; }

        /// <summary>
        /// 时间序列数据 time-series data
        /// </summary>
        /// <value>时间序列数据 time-series data</value>
        [DataMember(Name="outWaters", EmitDefaultValue=true)]
        public List<TsPair1> OutWaters { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SimResultsOutupt {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  OutWatersUnit: ").Append(OutWatersUnit).Append("\n");
            sb.Append("  OutWaters: ").Append(OutWaters).Append("\n");
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
            return this.Equals(input as SimResultsOutupt);
        }

        /// <summary>
        /// Returns true if SimResultsOutupt instances are equal
        /// </summary>
        /// <param name="input">Instance of SimResultsOutupt to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SimResultsOutupt input)
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
                    this.OutWatersUnit == input.OutWatersUnit ||
                    (this.OutWatersUnit != null &&
                    this.OutWatersUnit.Equals(input.OutWatersUnit))
                ) && 
                (
                    this.OutWaters == input.OutWaters ||
                    this.OutWaters != null &&
                    input.OutWaters != null &&
                    this.OutWaters.SequenceEqual(input.OutWaters)
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
                if (this.OutWatersUnit != null)
                    hashCode = hashCode * 59 + this.OutWatersUnit.GetHashCode();
                if (this.OutWaters != null)
                    hashCode = hashCode * 59 + this.OutWaters.GetHashCode();
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
