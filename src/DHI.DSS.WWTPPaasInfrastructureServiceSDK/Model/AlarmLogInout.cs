/* 
 * wwtp-paas-infrastructure-service
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
using OpenAPIDateConverter = DHI.DSS.WWTPPaasInfrastructureServiceSDK.Client.OpenAPIDateConverter;

namespace DHI.DSS.WWTPPaasInfrastructureServiceSDK.Model
{
    /// <summary>
    /// AlarmLogInout
    /// </summary>
    [DataContract]
    public partial class AlarmLogInout :  IEquatable<AlarmLogInout>, IValidatableObject
    {
        /// <summary>
        /// 报警类型 alarm type
        /// </summary>
        /// <value>报警类型 alarm type</value>
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
        /// 报警类型 alarm type
        /// </summary>
        /// <value>报警类型 alarm type</value>
        [DataMember(Name="alarmType", EmitDefaultValue=false)]
        public AlarmTypeEnum? AlarmType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlarmLogInout" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="alarmTime">产生报警数据的时间 alarm data generation time.</param>
        /// <param name="predictionTime">报警时间 alarm time.</param>
        /// <param name="pointType">点位类型 point type.</param>
        /// <param name="extInfo">扩展信息，生化池 extend information for biochemical pool index.</param>
        /// <param name="indicator">指标 indicator.</param>
        /// <param name="pointName">点位名称 point name.</param>
        /// <param name="nodeCode">点位代码 point code.</param>
        /// <param name="grade">报警等级 alarm grade.</param>
        /// <param name="value">数值 value.</param>
        /// <param name="message">报警信息 alarm message.</param>
        /// <param name="alarmType">报警类型 alarm type.</param>
        public AlarmLogInout(Guid id = default(Guid), DateTime alarmTime = default(DateTime), DateTime predictionTime = default(DateTime), int pointType = default(int), string extInfo = default(string), string indicator = default(string), string pointName = default(string), string nodeCode = default(string), int grade = default(int), double value = default(double), string message = default(string), AlarmTypeEnum? alarmType = default(AlarmTypeEnum?))
        {
            this.Id = id;
            this.AlarmTime = alarmTime;
            this.PredictionTime = predictionTime;
            this.PointType = pointType;
            this.ExtInfo = extInfo;
            this.Indicator = indicator;
            this.PointName = pointName;
            this.NodeCode = nodeCode;
            this.Grade = grade;
            this.Value = value;
            this.Message = message;
            this.AlarmType = alarmType;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid Id { get; set; }

        /// <summary>
        /// 产生报警数据的时间 alarm data generation time
        /// </summary>
        /// <value>产生报警数据的时间 alarm data generation time</value>
        [DataMember(Name="alarmTime", EmitDefaultValue=false)]
        public DateTime AlarmTime { get; set; }

        /// <summary>
        /// 报警时间 alarm time
        /// </summary>
        /// <value>报警时间 alarm time</value>
        [DataMember(Name="predictionTime", EmitDefaultValue=false)]
        public DateTime PredictionTime { get; set; }

        /// <summary>
        /// 点位类型 point type
        /// </summary>
        /// <value>点位类型 point type</value>
        [DataMember(Name="pointType", EmitDefaultValue=false)]
        public int PointType { get; set; }

        /// <summary>
        /// 扩展信息，生化池 extend information for biochemical pool index
        /// </summary>
        /// <value>扩展信息，生化池 extend information for biochemical pool index</value>
        [DataMember(Name="extInfo", EmitDefaultValue=true)]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 指标 indicator
        /// </summary>
        /// <value>指标 indicator</value>
        [DataMember(Name="indicator", EmitDefaultValue=true)]
        public string Indicator { get; set; }

        /// <summary>
        /// 点位名称 point name
        /// </summary>
        /// <value>点位名称 point name</value>
        [DataMember(Name="pointName", EmitDefaultValue=true)]
        public string PointName { get; set; }

        /// <summary>
        /// 点位代码 point code
        /// </summary>
        /// <value>点位代码 point code</value>
        [DataMember(Name="nodeCode", EmitDefaultValue=true)]
        public string NodeCode { get; set; }

        /// <summary>
        /// 报警等级 alarm grade
        /// </summary>
        /// <value>报警等级 alarm grade</value>
        [DataMember(Name="grade", EmitDefaultValue=false)]
        public int Grade { get; set; }

        /// <summary>
        /// 数值 value
        /// </summary>
        /// <value>数值 value</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public double Value { get; set; }

        /// <summary>
        /// 报警信息 alarm message
        /// </summary>
        /// <value>报警信息 alarm message</value>
        [DataMember(Name="message", EmitDefaultValue=true)]
        public string Message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AlarmLogInout {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AlarmTime: ").Append(AlarmTime).Append("\n");
            sb.Append("  PredictionTime: ").Append(PredictionTime).Append("\n");
            sb.Append("  PointType: ").Append(PointType).Append("\n");
            sb.Append("  ExtInfo: ").Append(ExtInfo).Append("\n");
            sb.Append("  Indicator: ").Append(Indicator).Append("\n");
            sb.Append("  PointName: ").Append(PointName).Append("\n");
            sb.Append("  NodeCode: ").Append(NodeCode).Append("\n");
            sb.Append("  Grade: ").Append(Grade).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
            return this.Equals(input as AlarmLogInout);
        }

        /// <summary>
        /// Returns true if AlarmLogInout instances are equal
        /// </summary>
        /// <param name="input">Instance of AlarmLogInout to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlarmLogInout input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.AlarmTime == input.AlarmTime ||
                    (this.AlarmTime != null &&
                    this.AlarmTime.Equals(input.AlarmTime))
                ) && 
                (
                    this.PredictionTime == input.PredictionTime ||
                    (this.PredictionTime != null &&
                    this.PredictionTime.Equals(input.PredictionTime))
                ) && 
                (
                    this.PointType == input.PointType ||
                    this.PointType.Equals(input.PointType)
                ) && 
                (
                    this.ExtInfo == input.ExtInfo ||
                    (this.ExtInfo != null &&
                    this.ExtInfo.Equals(input.ExtInfo))
                ) && 
                (
                    this.Indicator == input.Indicator ||
                    (this.Indicator != null &&
                    this.Indicator.Equals(input.Indicator))
                ) && 
                (
                    this.PointName == input.PointName ||
                    (this.PointName != null &&
                    this.PointName.Equals(input.PointName))
                ) && 
                (
                    this.NodeCode == input.NodeCode ||
                    (this.NodeCode != null &&
                    this.NodeCode.Equals(input.NodeCode))
                ) && 
                (
                    this.Grade == input.Grade ||
                    this.Grade.Equals(input.Grade)
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.AlarmTime != null)
                    hashCode = hashCode * 59 + this.AlarmTime.GetHashCode();
                if (this.PredictionTime != null)
                    hashCode = hashCode * 59 + this.PredictionTime.GetHashCode();
                hashCode = hashCode * 59 + this.PointType.GetHashCode();
                if (this.ExtInfo != null)
                    hashCode = hashCode * 59 + this.ExtInfo.GetHashCode();
                if (this.Indicator != null)
                    hashCode = hashCode * 59 + this.Indicator.GetHashCode();
                if (this.PointName != null)
                    hashCode = hashCode * 59 + this.PointName.GetHashCode();
                if (this.NodeCode != null)
                    hashCode = hashCode * 59 + this.NodeCode.GetHashCode();
                hashCode = hashCode * 59 + this.Grade.GetHashCode();
                hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
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
