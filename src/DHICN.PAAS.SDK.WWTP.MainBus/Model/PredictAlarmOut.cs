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
    /// 预警信息
    /// </summary>
    [DataContract]
    public partial class PredictAlarmOut :  IEquatable<PredictAlarmOut>, IValidatableObject
    {
        /// <summary>
        /// 预警类型 alarm type
        /// </summary>
        /// <value>预警类型 alarm type</value>
        public enum AlarmTypeEnum
        {
            /// <summary>
            /// Enum NUMBER_0 for value: 0
            /// </summary>
            NUMBER_0 = 0,

            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            NUMBER_1 = 1,

            /// <summary>
            /// Enum NUMBER_2 for value: 2
            /// </summary>
            NUMBER_2 = 2

        }

        /// <summary>
        /// 预警类型 alarm type
        /// </summary>
        /// <value>预警类型 alarm type</value>
        [DataMember(Name="alarmType", EmitDefaultValue=false)]
        public AlarmTypeEnum? AlarmType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PredictAlarmOut" /> class.
        /// </summary>
        /// <param name="code">指标 indicator code.</param>
        /// <param name="predictionTime">时刻 alarm time.</param>
        /// <param name="value">预测值 value.</param>
        /// <param name="message">预警信息 alarm message.</param>
        /// <param name="detailMessage">详细预警信息 alarm message detail.</param>
        /// <param name="unit">单位 unit.</param>
        /// <param name="alarmType">预警类型 alarm type.</param>
        public PredictAlarmOut(string code = default(string), DateTime predictionTime = default(DateTime), double value = default(double), string message = default(string), string detailMessage = default(string), string unit = default(string), AlarmTypeEnum? alarmType = default(AlarmTypeEnum?))
        {
            this.Code = code;
            this.PredictionTime = predictionTime;
            this.Value = value;
            this.Message = message;
            this.DetailMessage = detailMessage;
            this.Unit = unit;
            this.AlarmType = alarmType;
        }
        
        /// <summary>
        /// 指标 indicator code
        /// </summary>
        /// <value>指标 indicator code</value>
        [DataMember(Name="code", EmitDefaultValue=true)]
        public string Code { get; set; }

        /// <summary>
        /// 时刻 alarm time
        /// </summary>
        /// <value>时刻 alarm time</value>
        [DataMember(Name="predictionTime", EmitDefaultValue=false)]
        public DateTime PredictionTime { get; set; }

        /// <summary>
        /// 预测值 value
        /// </summary>
        /// <value>预测值 value</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public double Value { get; set; }

        /// <summary>
        /// 预警信息 alarm message
        /// </summary>
        /// <value>预警信息 alarm message</value>
        [DataMember(Name="message", EmitDefaultValue=true)]
        public string Message { get; set; }

        /// <summary>
        /// 详细预警信息 alarm message detail
        /// </summary>
        /// <value>详细预警信息 alarm message detail</value>
        [DataMember(Name="detailMessage", EmitDefaultValue=true)]
        public string DetailMessage { get; set; }

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
            sb.Append("class PredictAlarmOut {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  PredictionTime: ").Append(PredictionTime).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  DetailMessage: ").Append(DetailMessage).Append("\n");
            sb.Append("  Unit: ").Append(Unit).Append("\n");
            sb.Append("  AlarmType: ").Append(AlarmType).Append("\n");
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
            return this.Equals(input as PredictAlarmOut);
        }

        /// <summary>
        /// Returns true if PredictAlarmOut instances are equal
        /// </summary>
        /// <param name="input">Instance of PredictAlarmOut to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PredictAlarmOut input)
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
                    this.PredictionTime == input.PredictionTime ||
                    (this.PredictionTime != null &&
                    this.PredictionTime.Equals(input.PredictionTime))
                ) && 
                (
                    this.Value == input.Value ||
                    this.Value.Equals(input.Value)
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.DetailMessage == input.DetailMessage ||
                    (this.DetailMessage != null &&
                    this.DetailMessage.Equals(input.DetailMessage))
                ) && 
                (
                    this.Unit == input.Unit ||
                    (this.Unit != null &&
                    this.Unit.Equals(input.Unit))
                ) && 
                (
                    this.AlarmType == input.AlarmType ||
                    this.AlarmType.Equals(input.AlarmType)
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
                if (this.PredictionTime != null)
                    hashCode = hashCode * 59 + this.PredictionTime.GetHashCode();
                hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.DetailMessage != null)
                    hashCode = hashCode * 59 + this.DetailMessage.GetHashCode();
                if (this.Unit != null)
                    hashCode = hashCode * 59 + this.Unit.GetHashCode();
                hashCode = hashCode * 59 + this.AlarmType.GetHashCode();
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
