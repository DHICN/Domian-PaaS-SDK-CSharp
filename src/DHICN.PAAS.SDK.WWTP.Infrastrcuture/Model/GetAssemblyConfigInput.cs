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
    /// GetAssemblyConfigInput
    /// </summary>
    [DataContract]
    public partial class GetAssemblyConfigInput :  IEquatable<GetAssemblyConfigInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAssemblyConfigInput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetAssemblyConfigInput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAssemblyConfigInput" /> class.
        /// </summary>
        /// <param name="pointTypeCode">点位类型编码.</param>
        /// <param name="pointType">点位类型 point type.</param>
        /// <param name="modelName">模板模型名称（即模板方案名称） template model name (required).</param>
        /// <param name="codes">点位编码 codes.</param>
        /// <param name="isInputPoint">是否在线点位 if it is an online point.</param>
        /// <param name="extInfo">扩展信息，生化池序号 extend information for biochemical pool index.</param>
        /// <param name="productLine">生产线 product line.</param>
        public GetAssemblyConfigInput(string pointTypeCode = default(string), string pointType = default(string), string modelName = default(string), List<string> codes = default(List<string>), bool? isInputPoint = default(bool?), string extInfo = default(string), string productLine = default(string))
        {
            // to ensure "modelName" is required (not null)
            this.ModelName = modelName ?? throw new ArgumentNullException("modelName is a required property for GetAssemblyConfigInput and cannot be null");
            this.PointTypeCode = pointTypeCode;
            this.PointType = pointType;
            this.Codes = codes;
            this.IsInputPoint = isInputPoint;
            this.ExtInfo = extInfo;
            this.ProductLine = productLine;
        }
        
        /// <summary>
        /// 点位类型编码
        /// </summary>
        /// <value>点位类型编码</value>
        [DataMember(Name="pointTypeCode", EmitDefaultValue=true)]
        public string PointTypeCode { get; set; }

        /// <summary>
        /// 点位类型 point type
        /// </summary>
        /// <value>点位类型 point type</value>
        [DataMember(Name="pointType", EmitDefaultValue=true)]
        public string PointType { get; set; }

        /// <summary>
        /// 模板模型名称（即模板方案名称） template model name
        /// </summary>
        /// <value>模板模型名称（即模板方案名称） template model name</value>
        [DataMember(Name="modelName", EmitDefaultValue=false)]
        public string ModelName { get; set; }

        /// <summary>
        /// 点位编码 codes
        /// </summary>
        /// <value>点位编码 codes</value>
        [DataMember(Name="codes", EmitDefaultValue=true)]
        public List<string> Codes { get; set; }

        /// <summary>
        /// 是否在线点位 if it is an online point
        /// </summary>
        /// <value>是否在线点位 if it is an online point</value>
        [DataMember(Name="isInputPoint", EmitDefaultValue=true)]
        public bool? IsInputPoint { get; set; }

        /// <summary>
        /// 扩展信息，生化池序号 extend information for biochemical pool index
        /// </summary>
        /// <value>扩展信息，生化池序号 extend information for biochemical pool index</value>
        [DataMember(Name="extInfo", EmitDefaultValue=true)]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 生产线 product line
        /// </summary>
        /// <value>生产线 product line</value>
        [DataMember(Name="productLine", EmitDefaultValue=true)]
        public string ProductLine { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetAssemblyConfigInput {\n");
            sb.Append("  PointTypeCode: ").Append(PointTypeCode).Append("\n");
            sb.Append("  PointType: ").Append(PointType).Append("\n");
            sb.Append("  ModelName: ").Append(ModelName).Append("\n");
            sb.Append("  Codes: ").Append(Codes).Append("\n");
            sb.Append("  IsInputPoint: ").Append(IsInputPoint).Append("\n");
            sb.Append("  ExtInfo: ").Append(ExtInfo).Append("\n");
            sb.Append("  ProductLine: ").Append(ProductLine).Append("\n");
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
            return this.Equals(input as GetAssemblyConfigInput);
        }

        /// <summary>
        /// Returns true if GetAssemblyConfigInput instances are equal
        /// </summary>
        /// <param name="input">Instance of GetAssemblyConfigInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetAssemblyConfigInput input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PointTypeCode == input.PointTypeCode ||
                    (this.PointTypeCode != null &&
                    this.PointTypeCode.Equals(input.PointTypeCode))
                ) && 
                (
                    this.PointType == input.PointType ||
                    (this.PointType != null &&
                    this.PointType.Equals(input.PointType))
                ) && 
                (
                    this.ModelName == input.ModelName ||
                    (this.ModelName != null &&
                    this.ModelName.Equals(input.ModelName))
                ) && 
                (
                    this.Codes == input.Codes ||
                    this.Codes != null &&
                    input.Codes != null &&
                    this.Codes.SequenceEqual(input.Codes)
                ) && 
                (
                    this.IsInputPoint == input.IsInputPoint ||
                    (this.IsInputPoint != null &&
                    this.IsInputPoint.Equals(input.IsInputPoint))
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
                if (this.PointTypeCode != null)
                    hashCode = hashCode * 59 + this.PointTypeCode.GetHashCode();
                if (this.PointType != null)
                    hashCode = hashCode * 59 + this.PointType.GetHashCode();
                if (this.ModelName != null)
                    hashCode = hashCode * 59 + this.ModelName.GetHashCode();
                if (this.Codes != null)
                    hashCode = hashCode * 59 + this.Codes.GetHashCode();
                if (this.IsInputPoint != null)
                    hashCode = hashCode * 59 + this.IsInputPoint.GetHashCode();
                if (this.ExtInfo != null)
                    hashCode = hashCode * 59 + this.ExtInfo.GetHashCode();
                if (this.ProductLine != null)
                    hashCode = hashCode * 59 + this.ProductLine.GetHashCode();
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