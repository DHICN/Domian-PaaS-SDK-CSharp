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
using OpenAPIDateConverter = DHI.DSS.IdentityServiceSDK.Client.OpenAPIDateConverter;

namespace DHI.DSS.IdentityServiceSDK.Model
{
    /// <summary>
    /// IntelligentDeniConfigInOut
    /// </summary>
    [DataContract]
    public partial class IntelligentDeniConfigInOut :  IEquatable<IntelligentDeniConfigInOut>, IValidatableObject
    {
        /// <summary>
        /// 药剂投加类别
        /// </summary>
        /// <value>药剂投加类别</value>
        public enum CategoryEnum
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
            NUMBER_4 = 4

        }

        /// <summary>
        /// 药剂投加类别
        /// </summary>
        /// <value>药剂投加类别</value>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public CategoryEnum? Category { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="IntelligentDeniConfigInOut" /> class.
        /// </summary>
        /// <param name="id">配置ID config id.</param>
        /// <param name="displayType">展示类型枚举 display type.</param>
        /// <param name="displayTypeName">展示类型名称 display type name.</param>
        /// <param name="codes">系统点位编码，逗号分割 system point codes, seperated by comma.</param>
        /// <param name="subType">点位类型 point type.</param>
        /// <param name="isInputPoint">是否为输入点位 if it is an online point for input.</param>
        /// <param name="extInfo">扩展信息，生化池序号 extend information for biochemical pool index.</param>
        /// <param name="productLine">生产线代码 product line code.</param>
        /// <param name="category">药剂投加类别.</param>
        public IntelligentDeniConfigInOut(Guid id = default(Guid), int displayType = default(int), string displayTypeName = default(string), string codes = default(string), string subType = default(string), bool isInputPoint = default(bool), string extInfo = default(string), string productLine = default(string), CategoryEnum? category = default(CategoryEnum?))
        {
            this.Id = id;
            this.DisplayType = displayType;
            this.DisplayTypeName = displayTypeName;
            this.Codes = codes;
            this.SubType = subType;
            this.IsInputPoint = isInputPoint;
            this.ExtInfo = extInfo;
            this.ProductLine = productLine;
            this.Category = category;
        }
        
        /// <summary>
        /// 配置ID config id
        /// </summary>
        /// <value>配置ID config id</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid Id { get; set; }

        /// <summary>
        /// 展示类型枚举 display type
        /// </summary>
        /// <value>展示类型枚举 display type</value>
        [DataMember(Name="displayType", EmitDefaultValue=false)]
        public int DisplayType { get; set; }

        /// <summary>
        /// 展示类型名称 display type name
        /// </summary>
        /// <value>展示类型名称 display type name</value>
        [DataMember(Name="displayTypeName", EmitDefaultValue=true)]
        public string DisplayTypeName { get; set; }

        /// <summary>
        /// 系统点位编码，逗号分割 system point codes, seperated by comma
        /// </summary>
        /// <value>系统点位编码，逗号分割 system point codes, seperated by comma</value>
        [DataMember(Name="codes", EmitDefaultValue=true)]
        public string Codes { get; set; }

        /// <summary>
        /// 点位类型 point type
        /// </summary>
        /// <value>点位类型 point type</value>
        [DataMember(Name="subType", EmitDefaultValue=true)]
        public string SubType { get; set; }

        /// <summary>
        /// 是否为输入点位 if it is an online point for input
        /// </summary>
        /// <value>是否为输入点位 if it is an online point for input</value>
        [DataMember(Name="isInputPoint", EmitDefaultValue=false)]
        public bool IsInputPoint { get; set; }

        /// <summary>
        /// 扩展信息，生化池序号 extend information for biochemical pool index
        /// </summary>
        /// <value>扩展信息，生化池序号 extend information for biochemical pool index</value>
        [DataMember(Name="extInfo", EmitDefaultValue=true)]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 生产线代码 product line code
        /// </summary>
        /// <value>生产线代码 product line code</value>
        [DataMember(Name="productLine", EmitDefaultValue=true)]
        public string ProductLine { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IntelligentDeniConfigInOut {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DisplayType: ").Append(DisplayType).Append("\n");
            sb.Append("  DisplayTypeName: ").Append(DisplayTypeName).Append("\n");
            sb.Append("  Codes: ").Append(Codes).Append("\n");
            sb.Append("  SubType: ").Append(SubType).Append("\n");
            sb.Append("  IsInputPoint: ").Append(IsInputPoint).Append("\n");
            sb.Append("  ExtInfo: ").Append(ExtInfo).Append("\n");
            sb.Append("  ProductLine: ").Append(ProductLine).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
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
            return this.Equals(input as IntelligentDeniConfigInOut);
        }

        /// <summary>
        /// Returns true if IntelligentDeniConfigInOut instances are equal
        /// </summary>
        /// <param name="input">Instance of IntelligentDeniConfigInOut to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IntelligentDeniConfigInOut input)
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
                    this.Codes == input.Codes ||
                    (this.Codes != null &&
                    this.Codes.Equals(input.Codes))
                ) && 
                (
                    this.SubType == input.SubType ||
                    (this.SubType != null &&
                    this.SubType.Equals(input.SubType))
                ) && 
                (
                    this.IsInputPoint == input.IsInputPoint ||
                    this.IsInputPoint.Equals(input.IsInputPoint)
                ) && 
                (
                    this.ExtInfo == input.ExtInfo ||
                    (this.ExtInfo != null &&
                    this.ExtInfo.Equals(input.ExtInfo))
                ) && 
                (
                    this.ProductLine == input.ProductLine ||
                    (this.ProductLine != null &&
                    this.ProductLine.Equals(input.ProductLine))
                ) && 
                (
                    this.Category == input.Category ||
                    this.Category.Equals(input.Category)
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
                if (this.Codes != null)
                    hashCode = hashCode * 59 + this.Codes.GetHashCode();
                if (this.SubType != null)
                    hashCode = hashCode * 59 + this.SubType.GetHashCode();
                hashCode = hashCode * 59 + this.IsInputPoint.GetHashCode();
                if (this.ExtInfo != null)
                    hashCode = hashCode * 59 + this.ExtInfo.GetHashCode();
                if (this.ProductLine != null)
                    hashCode = hashCode * 59 + this.ProductLine.GetHashCode();
                hashCode = hashCode * 59 + this.Category.GetHashCode();
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
