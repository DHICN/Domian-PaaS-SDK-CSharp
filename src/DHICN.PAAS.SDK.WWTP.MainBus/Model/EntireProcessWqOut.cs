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
    /// EntireProcessWqOut
    /// </summary>
    [DataContract]
    public partial class EntireProcessWqOut :  IEquatable<EntireProcessWqOut>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EntireProcessWqOut" /> class.
        /// </summary>
        /// <param name="code">指标 indicator code.</param>
        /// <param name="unit">单位 unit.</param>
        /// <param name="tsData">全流程水质时间序列 entire process time-series data.</param>
        public EntireProcessWqOut(string code = default(string), string unit = default(string), List<EntireProcessTs> tsData = default(List<EntireProcessTs>))
        {
            this.Code = code;
            this.Unit = unit;
            this.TsData = tsData;
        }
        
        /// <summary>
        /// 指标 indicator code
        /// </summary>
        /// <value>指标 indicator code</value>
        [DataMember(Name="code", EmitDefaultValue=true)]
        public string Code { get; set; }

        /// <summary>
        /// 单位 unit
        /// </summary>
        /// <value>单位 unit</value>
        [DataMember(Name="unit", EmitDefaultValue=true)]
        public string Unit { get; set; }

        /// <summary>
        /// 全流程水质时间序列 entire process time-series data
        /// </summary>
        /// <value>全流程水质时间序列 entire process time-series data</value>
        [DataMember(Name="tsData", EmitDefaultValue=true)]
        public List<EntireProcessTs> TsData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EntireProcessWqOut {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Unit: ").Append(Unit).Append("\n");
            sb.Append("  TsData: ").Append(TsData).Append("\n");
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
            return this.Equals(input as EntireProcessWqOut);
        }

        /// <summary>
        /// Returns true if EntireProcessWqOut instances are equal
        /// </summary>
        /// <param name="input">Instance of EntireProcessWqOut to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EntireProcessWqOut input)
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
                    this.TsData == input.TsData ||
                    this.TsData != null &&
                    input.TsData != null &&
                    this.TsData.SequenceEqual(input.TsData)
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
                if (this.TsData != null)
                    hashCode = hashCode * 59 + this.TsData.GetHashCode();
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
