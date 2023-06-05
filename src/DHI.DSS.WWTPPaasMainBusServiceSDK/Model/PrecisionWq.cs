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
    /// 预测出水水质
    /// </summary>
    [DataContract]
    public partial class PrecisionWq :  IEquatable<PrecisionWq>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PrecisionWq" /> class.
        /// </summary>
        /// <param name="code">指标 indicator code.</param>
        /// <param name="displayMsg">展示信息 display message.</param>
        /// <param name="tsData">时间序列值 time-series data.</param>
        public PrecisionWq(string code = default(string), string displayMsg = default(string), List<TsPair1> tsData = default(List<TsPair1>))
        {
            this.Code = code;
            this.DisplayMsg = displayMsg;
            this.TsData = tsData;
        }
        
        /// <summary>
        /// 指标 indicator code
        /// </summary>
        /// <value>指标 indicator code</value>
        [DataMember(Name="code", EmitDefaultValue=true)]
        public string Code { get; set; }

        /// <summary>
        /// 展示信息 display message
        /// </summary>
        /// <value>展示信息 display message</value>
        [DataMember(Name="displayMsg", EmitDefaultValue=true)]
        public string DisplayMsg { get; set; }

        /// <summary>
        /// 最大值 maximum value
        /// </summary>
        /// <value>最大值 maximum value</value>
        [DataMember(Name="maxValue", EmitDefaultValue=false)]
        public double MaxValue { get; private set; }

        /// <summary>
        /// 最小值 minimum value
        /// </summary>
        /// <value>最小值 minimum value</value>
        [DataMember(Name="minValue", EmitDefaultValue=false)]
        public double MinValue { get; private set; }

        /// <summary>
        /// 平均值 average value
        /// </summary>
        /// <value>平均值 average value</value>
        [DataMember(Name="averageValue", EmitDefaultValue=false)]
        public double AverageValue { get; private set; }

        /// <summary>
        /// 差值 difference value
        /// </summary>
        /// <value>差值 difference value</value>
        [DataMember(Name="deviationValue", EmitDefaultValue=false)]
        public double DeviationValue { get; private set; }

        /// <summary>
        /// 时间序列值 time-series data
        /// </summary>
        /// <value>时间序列值 time-series data</value>
        [DataMember(Name="tsData", EmitDefaultValue=true)]
        public List<TsPair1> TsData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PrecisionWq {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  DisplayMsg: ").Append(DisplayMsg).Append("\n");
            sb.Append("  MaxValue: ").Append(MaxValue).Append("\n");
            sb.Append("  MinValue: ").Append(MinValue).Append("\n");
            sb.Append("  AverageValue: ").Append(AverageValue).Append("\n");
            sb.Append("  DeviationValue: ").Append(DeviationValue).Append("\n");
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
            return this.Equals(input as PrecisionWq);
        }

        /// <summary>
        /// Returns true if PrecisionWq instances are equal
        /// </summary>
        /// <param name="input">Instance of PrecisionWq to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PrecisionWq input)
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
                    this.DisplayMsg == input.DisplayMsg ||
                    (this.DisplayMsg != null &&
                    this.DisplayMsg.Equals(input.DisplayMsg))
                ) && 
                (
                    this.MaxValue == input.MaxValue ||
                    this.MaxValue.Equals(input.MaxValue)
                ) && 
                (
                    this.MinValue == input.MinValue ||
                    this.MinValue.Equals(input.MinValue)
                ) && 
                (
                    this.AverageValue == input.AverageValue ||
                    this.AverageValue.Equals(input.AverageValue)
                ) && 
                (
                    this.DeviationValue == input.DeviationValue ||
                    this.DeviationValue.Equals(input.DeviationValue)
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
                if (this.DisplayMsg != null)
                    hashCode = hashCode * 59 + this.DisplayMsg.GetHashCode();
                hashCode = hashCode * 59 + this.MaxValue.GetHashCode();
                hashCode = hashCode * 59 + this.MinValue.GetHashCode();
                hashCode = hashCode * 59 + this.AverageValue.GetHashCode();
                hashCode = hashCode * 59 + this.DeviationValue.GetHashCode();
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
