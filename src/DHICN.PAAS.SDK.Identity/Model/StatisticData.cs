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
    /// StatisticData
    /// </summary>
    [DataContract]
    public partial class StatisticData :  IEquatable<StatisticData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StatisticData" /> class.
        /// </summary>
        /// <param name="code">指标 indicator.</param>
        /// <param name="unit">单位 unit.</param>
        /// <param name="min">最小值 minimum value.</param>
        /// <param name="max">最大值 maximum value.</param>
        /// <param name="mean">平均值 average value.</param>
        /// <param name="online">在线值 online value if existed.</param>
        public StatisticData(string code = default(string), string unit = default(string), double min = default(double), double max = default(double), double mean = default(double), double? online = default(double?))
        {
            this.Code = code;
            this.Unit = unit;
            this.Min = min;
            this.Max = max;
            this.Mean = mean;
            this.Online = online;
        }
        
        /// <summary>
        /// 指标 indicator
        /// </summary>
        /// <value>指标 indicator</value>
        [DataMember(Name="code", EmitDefaultValue=true)]
        public string Code { get; set; }

        /// <summary>
        /// 单位 unit
        /// </summary>
        /// <value>单位 unit</value>
        [DataMember(Name="unit", EmitDefaultValue=true)]
        public string Unit { get; set; }

        /// <summary>
        /// 最小值 minimum value
        /// </summary>
        /// <value>最小值 minimum value</value>
        [DataMember(Name="min", EmitDefaultValue=false)]
        public double Min { get; set; }

        /// <summary>
        /// 最大值 maximum value
        /// </summary>
        /// <value>最大值 maximum value</value>
        [DataMember(Name="max", EmitDefaultValue=false)]
        public double Max { get; set; }

        /// <summary>
        /// 平均值 average value
        /// </summary>
        /// <value>平均值 average value</value>
        [DataMember(Name="mean", EmitDefaultValue=false)]
        public double Mean { get; set; }

        /// <summary>
        /// 在线值 online value if existed
        /// </summary>
        /// <value>在线值 online value if existed</value>
        [DataMember(Name="online", EmitDefaultValue=true)]
        public double? Online { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StatisticData {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Unit: ").Append(Unit).Append("\n");
            sb.Append("  Min: ").Append(Min).Append("\n");
            sb.Append("  Max: ").Append(Max).Append("\n");
            sb.Append("  Mean: ").Append(Mean).Append("\n");
            sb.Append("  Online: ").Append(Online).Append("\n");
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
            return this.Equals(input as StatisticData);
        }

        /// <summary>
        /// Returns true if StatisticData instances are equal
        /// </summary>
        /// <param name="input">Instance of StatisticData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StatisticData input)
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
                    this.Min == input.Min ||
                    this.Min.Equals(input.Min)
                ) && 
                (
                    this.Max == input.Max ||
                    this.Max.Equals(input.Max)
                ) && 
                (
                    this.Mean == input.Mean ||
                    this.Mean.Equals(input.Mean)
                ) && 
                (
                    this.Online == input.Online ||
                    (this.Online != null &&
                    this.Online.Equals(input.Online))
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
                hashCode = hashCode * 59 + this.Min.GetHashCode();
                hashCode = hashCode * 59 + this.Max.GetHashCode();
                hashCode = hashCode * 59 + this.Mean.GetHashCode();
                if (this.Online != null)
                    hashCode = hashCode * 59 + this.Online.GetHashCode();
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
