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
    /// HpDisplayConfigInOut
    /// </summary>
    [DataContract]
    public partial class HpDisplayConfigInOut :  IEquatable<HpDisplayConfigInOut>, IValidatableObject
    {
        /// <summary>
        /// 显示类型枚举
        /// </summary>
        /// <value>显示类型枚举</value>
        public enum DisplayTypeEnum
        {
            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            NUMBER_1 = 1,

            /// <summary>
            /// Enum NUMBER_2 for value: 2
            /// </summary>
            NUMBER_2 = 2,

            /// <summary>
            /// Enum NUMBER_3 for value: 3
            /// </summary>
            NUMBER_3 = 3,

            /// <summary>
            /// Enum NUMBER_4 for value: 4
            /// </summary>
            NUMBER_4 = 4,

            /// <summary>
            /// Enum NUMBER_5 for value: 5
            /// </summary>
            NUMBER_5 = 5,

            /// <summary>
            /// Enum NUMBER_6 for value: 6
            /// </summary>
            NUMBER_6 = 6,

            /// <summary>
            /// Enum NUMBER_7 for value: 7
            /// </summary>
            NUMBER_7 = 7

        }

        /// <summary>
        /// 显示类型枚举
        /// </summary>
        /// <value>显示类型枚举</value>
        [DataMember(Name="displayType", EmitDefaultValue=false)]
        public DisplayTypeEnum? DisplayType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="HpDisplayConfigInOut" /> class.
        /// </summary>
        /// <param name="id">配置ID config id.</param>
        /// <param name="displayType">显示类型枚举.</param>
        /// <param name="displayTypeName">展示的模块名称 display type name.</param>
        /// <param name="displayCodes">要展示的点位编码，以英文逗号\&quot;,\&quot;隔开 system point codes, seperated by comma.</param>
        /// <param name="subTypes">点位类型：如进水、出水、生化池…… point type.</param>
        /// <param name="isInputPoint">是否为输入点位 if it is an online point for input.</param>
        public HpDisplayConfigInOut(Guid id = default(Guid), DisplayTypeEnum? displayType = default(DisplayTypeEnum?), string displayTypeName = default(string), string displayCodes = default(string), string subTypes = default(string), bool isInputPoint = default(bool))
        {
            this.Id = id;
            this.DisplayType = displayType;
            this.DisplayTypeName = displayTypeName;
            this.DisplayCodes = displayCodes;
            this.SubTypes = subTypes;
            this.IsInputPoint = isInputPoint;
        }
        
        /// <summary>
        /// 配置ID config id
        /// </summary>
        /// <value>配置ID config id</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid Id { get; set; }

        /// <summary>
        /// 展示的模块名称 display type name
        /// </summary>
        /// <value>展示的模块名称 display type name</value>
        [DataMember(Name="displayTypeName", EmitDefaultValue=true)]
        public string DisplayTypeName { get; set; }

        /// <summary>
        /// 要展示的点位编码，以英文逗号\&quot;,\&quot;隔开 system point codes, seperated by comma
        /// </summary>
        /// <value>要展示的点位编码，以英文逗号\&quot;,\&quot;隔开 system point codes, seperated by comma</value>
        [DataMember(Name="displayCodes", EmitDefaultValue=true)]
        public string DisplayCodes { get; set; }

        /// <summary>
        /// 点位类型：如进水、出水、生化池…… point type
        /// </summary>
        /// <value>点位类型：如进水、出水、生化池…… point type</value>
        [DataMember(Name="subTypes", EmitDefaultValue=true)]
        public string SubTypes { get; set; }

        /// <summary>
        /// 是否为输入点位 if it is an online point for input
        /// </summary>
        /// <value>是否为输入点位 if it is an online point for input</value>
        [DataMember(Name="isInputPoint", EmitDefaultValue=false)]
        public bool IsInputPoint { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HpDisplayConfigInOut {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DisplayType: ").Append(DisplayType).Append("\n");
            sb.Append("  DisplayTypeName: ").Append(DisplayTypeName).Append("\n");
            sb.Append("  DisplayCodes: ").Append(DisplayCodes).Append("\n");
            sb.Append("  SubTypes: ").Append(SubTypes).Append("\n");
            sb.Append("  IsInputPoint: ").Append(IsInputPoint).Append("\n");
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
            return this.Equals(input as HpDisplayConfigInOut);
        }

        /// <summary>
        /// Returns true if HpDisplayConfigInOut instances are equal
        /// </summary>
        /// <param name="input">Instance of HpDisplayConfigInOut to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HpDisplayConfigInOut input)
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
                    this.DisplayType == input.DisplayType ||
                    this.DisplayType.Equals(input.DisplayType)
                ) && 
                (
                    this.DisplayTypeName == input.DisplayTypeName ||
                    (this.DisplayTypeName != null &&
                    this.DisplayTypeName.Equals(input.DisplayTypeName))
                ) && 
                (
                    this.DisplayCodes == input.DisplayCodes ||
                    (this.DisplayCodes != null &&
                    this.DisplayCodes.Equals(input.DisplayCodes))
                ) && 
                (
                    this.SubTypes == input.SubTypes ||
                    (this.SubTypes != null &&
                    this.SubTypes.Equals(input.SubTypes))
                ) && 
                (
                    this.IsInputPoint == input.IsInputPoint ||
                    this.IsInputPoint.Equals(input.IsInputPoint)
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
                hashCode = hashCode * 59 + this.DisplayType.GetHashCode();
                if (this.DisplayTypeName != null)
                    hashCode = hashCode * 59 + this.DisplayTypeName.GetHashCode();
                if (this.DisplayCodes != null)
                    hashCode = hashCode * 59 + this.DisplayCodes.GetHashCode();
                if (this.SubTypes != null)
                    hashCode = hashCode * 59 + this.SubTypes.GetHashCode();
                hashCode = hashCode * 59 + this.IsInputPoint.GetHashCode();
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
