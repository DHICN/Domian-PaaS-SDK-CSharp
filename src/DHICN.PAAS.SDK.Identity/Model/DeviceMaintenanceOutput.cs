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
    /// DeviceMaintenanceOutput
    /// </summary>
    [DataContract]
    public partial class DeviceMaintenanceOutput :  IEquatable<DeviceMaintenanceOutput>, IValidatableObject
    {
        /// <summary>
        /// Defines Grade
        /// </summary>
        public enum GradeEnum
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
        /// Gets or Sets Grade
        /// </summary>
        [DataMember(Name="grade", EmitDefaultValue=false)]
        public GradeEnum? Grade { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceMaintenanceOutput" /> class.
        /// </summary>
        /// <param name="onlinePoint">在线点位名称 online point name.</param>
        /// <param name="pointCode">在线点位代码 online point code.</param>
        /// <param name="time">时间 time.</param>
        /// <param name="location">位置 location.</param>
        /// <param name="status">维护预警状态 maintenance alarm status.</param>
        /// <param name="message">维护预警信息 maintenance alarm message.</param>
        /// <param name="label">设备状态标签 device status label.</param>
        /// <param name="tag">清洗标签 data clean tag.</param>
        /// <param name="grade">grade.</param>
        public DeviceMaintenanceOutput(string onlinePoint = default(string), string pointCode = default(string), DateTime time = default(DateTime), string location = default(string), string status = default(string), string message = default(string), string label = default(string), string tag = default(string), GradeEnum? grade = default(GradeEnum?))
        {
            this.OnlinePoint = onlinePoint;
            this.PointCode = pointCode;
            this.Time = time;
            this.Location = location;
            this.Status = status;
            this.Message = message;
            this.Label = label;
            this.Tag = tag;
            this.Grade = grade;
        }
        
        /// <summary>
        /// 在线点位名称 online point name
        /// </summary>
        /// <value>在线点位名称 online point name</value>
        [DataMember(Name="onlinePoint", EmitDefaultValue=true)]
        public string OnlinePoint { get; set; }

        /// <summary>
        /// 在线点位代码 online point code
        /// </summary>
        /// <value>在线点位代码 online point code</value>
        [DataMember(Name="pointCode", EmitDefaultValue=true)]
        public string PointCode { get; set; }

        /// <summary>
        /// 时间 time
        /// </summary>
        /// <value>时间 time</value>
        [DataMember(Name="time", EmitDefaultValue=false)]
        public DateTime Time { get; set; }

        /// <summary>
        /// 位置 location
        /// </summary>
        /// <value>位置 location</value>
        [DataMember(Name="location", EmitDefaultValue=true)]
        public string Location { get; set; }

        /// <summary>
        /// 维护预警状态 maintenance alarm status
        /// </summary>
        /// <value>维护预警状态 maintenance alarm status</value>
        [DataMember(Name="status", EmitDefaultValue=true)]
        public string Status { get; set; }

        /// <summary>
        /// 维护预警信息 maintenance alarm message
        /// </summary>
        /// <value>维护预警信息 maintenance alarm message</value>
        [DataMember(Name="message", EmitDefaultValue=true)]
        public string Message { get; set; }

        /// <summary>
        /// 设备状态标签 device status label
        /// </summary>
        /// <value>设备状态标签 device status label</value>
        [DataMember(Name="label", EmitDefaultValue=true)]
        public string Label { get; set; }

        /// <summary>
        /// 清洗标签 data clean tag
        /// </summary>
        /// <value>清洗标签 data clean tag</value>
        [DataMember(Name="tag", EmitDefaultValue=true)]
        public string Tag { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeviceMaintenanceOutput {\n");
            sb.Append("  OnlinePoint: ").Append(OnlinePoint).Append("\n");
            sb.Append("  PointCode: ").Append(PointCode).Append("\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  Tag: ").Append(Tag).Append("\n");
            sb.Append("  Grade: ").Append(Grade).Append("\n");
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
            return this.Equals(input as DeviceMaintenanceOutput);
        }

        /// <summary>
        /// Returns true if DeviceMaintenanceOutput instances are equal
        /// </summary>
        /// <param name="input">Instance of DeviceMaintenanceOutput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeviceMaintenanceOutput input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OnlinePoint == input.OnlinePoint ||
                    (this.OnlinePoint != null &&
                    this.OnlinePoint.Equals(input.OnlinePoint))
                ) && 
                (
                    this.PointCode == input.PointCode ||
                    (this.PointCode != null &&
                    this.PointCode.Equals(input.PointCode))
                ) && 
                (
                    this.Time == input.Time ||
                    (this.Time != null &&
                    this.Time.Equals(input.Time))
                ) && 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
                ) && 
                (
                    this.Tag == input.Tag ||
                    (this.Tag != null &&
                    this.Tag.Equals(input.Tag))
                ) && 
                (
                    this.Grade == input.Grade ||
                    this.Grade.Equals(input.Grade)
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
                if (this.OnlinePoint != null)
                    hashCode = hashCode * 59 + this.OnlinePoint.GetHashCode();
                if (this.PointCode != null)
                    hashCode = hashCode * 59 + this.PointCode.GetHashCode();
                if (this.Time != null)
                    hashCode = hashCode * 59 + this.Time.GetHashCode();
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.Label != null)
                    hashCode = hashCode * 59 + this.Label.GetHashCode();
                if (this.Tag != null)
                    hashCode = hashCode * 59 + this.Tag.GetHashCode();
                hashCode = hashCode * 59 + this.Grade.GetHashCode();
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
