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
using OpenAPIDateConverter = DHICN.PAAS.SDK.WWTP.Infrastrcuture.Client.OpenAPIDateConverter;

namespace DHICN.PAAS.SDK.WWTP.Infrastrcuture.Model
{
    /// <summary>
    /// AlarmConfigInOut
    /// </summary>
    [DataContract]
    public partial class AlarmConfigInOut :  IEquatable<AlarmConfigInOut>, IValidatableObject
    {
        /// <summary>
        /// 警报类型 alarm type
        /// </summary>
        /// <value>警报类型 alarm type</value>
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
        /// 警报类型 alarm type
        /// </summary>
        /// <value>警报类型 alarm type</value>
        [DataMember(Name="alarmType", EmitDefaultValue=false)]
        public AlarmTypeEnum? AlarmType { get; set; }
        /// <summary>
        /// 节点类型 node type
        /// </summary>
        /// <value>节点类型 node type</value>
        public enum NodeTypeEnum
        {
            /// <summary>
            /// Enum NUMBER_0 for value: 0
            /// </summary>
            NUMBER_0 = 0,

            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            NUMBER_1 = 1

        }

        /// <summary>
        /// 节点类型 node type
        /// </summary>
        /// <value>节点类型 node type</value>
        [DataMember(Name="nodeType", EmitDefaultValue=false)]
        public NodeTypeEnum? NodeType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlarmConfigInOut" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="nodeCode">节点代码 code.</param>
        /// <param name="indicator">指标 indicator.</param>
        /// <param name="grade">规则等级 alarm grade.</param>
        /// <param name="maxValue">最大值，超过此数值将预警 maximum value, if the value is larger than this, it will be alarmed.</param>
        /// <param name="minValue">最小值，低于此数值将预警 minimum value, if the value is smaller than this, it will be alarmed.</param>
        /// <param name="alarmType">警报类型 alarm type.</param>
        /// <param name="nodeType">节点类型 node type.</param>
        /// <param name="unit">单位 unit.</param>
        /// <param name="message">报警信息 alarm message.</param>
        public AlarmConfigInOut(Guid id = default(Guid), string nodeCode = default(string), string indicator = default(string), int grade = default(int), double maxValue = default(double), double minValue = default(double), AlarmTypeEnum? alarmType = default(AlarmTypeEnum?), NodeTypeEnum? nodeType = default(NodeTypeEnum?), string unit = default(string), string message = default(string))
        {
            this.Id = id;
            this.NodeCode = nodeCode;
            this.Indicator = indicator;
            this.Grade = grade;
            this.MaxValue = maxValue;
            this.MinValue = minValue;
            this.AlarmType = alarmType;
            this.NodeType = nodeType;
            this.Unit = unit;
            this.Message = message;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid Id { get; set; }

        /// <summary>
        /// 节点代码 code
        /// </summary>
        /// <value>节点代码 code</value>
        [DataMember(Name="nodeCode", EmitDefaultValue=true)]
        public string NodeCode { get; set; }

        /// <summary>
        /// 指标 indicator
        /// </summary>
        /// <value>指标 indicator</value>
        [DataMember(Name="indicator", EmitDefaultValue=true)]
        public string Indicator { get; set; }

        /// <summary>
        /// 规则等级 alarm grade
        /// </summary>
        /// <value>规则等级 alarm grade</value>
        [DataMember(Name="grade", EmitDefaultValue=false)]
        public int Grade { get; set; }

        /// <summary>
        /// 最大值，超过此数值将预警 maximum value, if the value is larger than this, it will be alarmed
        /// </summary>
        /// <value>最大值，超过此数值将预警 maximum value, if the value is larger than this, it will be alarmed</value>
        [DataMember(Name="maxValue", EmitDefaultValue=false)]
        public double MaxValue { get; set; }

        /// <summary>
        /// 最小值，低于此数值将预警 minimum value, if the value is smaller than this, it will be alarmed
        /// </summary>
        /// <value>最小值，低于此数值将预警 minimum value, if the value is smaller than this, it will be alarmed</value>
        [DataMember(Name="minValue", EmitDefaultValue=false)]
        public double MinValue { get; set; }

        /// <summary>
        /// 单位 unit
        /// </summary>
        /// <value>单位 unit</value>
        [DataMember(Name="unit", EmitDefaultValue=true)]
        public string Unit { get; set; }

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
            sb.Append("class AlarmConfigInOut {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  NodeCode: ").Append(NodeCode).Append("\n");
            sb.Append("  Indicator: ").Append(Indicator).Append("\n");
            sb.Append("  Grade: ").Append(Grade).Append("\n");
            sb.Append("  MaxValue: ").Append(MaxValue).Append("\n");
            sb.Append("  MinValue: ").Append(MinValue).Append("\n");
            sb.Append("  AlarmType: ").Append(AlarmType).Append("\n");
            sb.Append("  NodeType: ").Append(NodeType).Append("\n");
            sb.Append("  Unit: ").Append(Unit).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
            return this.Equals(input as AlarmConfigInOut);
        }

        /// <summary>
        /// Returns true if AlarmConfigInOut instances are equal
        /// </summary>
        /// <param name="input">Instance of AlarmConfigInOut to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlarmConfigInOut input)
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
                    this.NodeCode == input.NodeCode ||
                    (this.NodeCode != null &&
                    this.NodeCode.Equals(input.NodeCode))
                ) && 
                (
                    this.Indicator == input.Indicator ||
                    (this.Indicator != null &&
                    this.Indicator.Equals(input.Indicator))
                ) && 
                (
                    this.Grade == input.Grade ||
                    this.Grade.Equals(input.Grade)
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
                    this.AlarmType == input.AlarmType ||
                    this.AlarmType.Equals(input.AlarmType)
                ) && 
                (
                    this.NodeType == input.NodeType ||
                    this.NodeType.Equals(input.NodeType)
                ) && 
                (
                    this.Unit == input.Unit ||
                    (this.Unit != null &&
                    this.Unit.Equals(input.Unit))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
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
                if (this.NodeCode != null)
                    hashCode = hashCode * 59 + this.NodeCode.GetHashCode();
                if (this.Indicator != null)
                    hashCode = hashCode * 59 + this.Indicator.GetHashCode();
                hashCode = hashCode * 59 + this.Grade.GetHashCode();
                hashCode = hashCode * 59 + this.MaxValue.GetHashCode();
                hashCode = hashCode * 59 + this.MinValue.GetHashCode();
                hashCode = hashCode * 59 + this.AlarmType.GetHashCode();
                hashCode = hashCode * 59 + this.NodeType.GetHashCode();
                if (this.Unit != null)
                    hashCode = hashCode * 59 + this.Unit.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
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
