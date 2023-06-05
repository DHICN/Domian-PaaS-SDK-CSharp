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
    /// DosingParameterOutput
    /// </summary>
    [DataContract]
    public partial class DosingParameterOutput :  IEquatable<DosingParameterOutput>, IValidatableObject
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
        /// Initializes a new instance of the <see cref="DosingParameterOutput" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="sysCode">系统代码 corresponding system code.</param>
        /// <param name="value">值 value.</param>
        /// <param name="unit">单位 unit.</param>
        /// <param name="orderBy">序号 display index.</param>
        /// <param name="isEditManual">是否为手动加药参数 if support manual dosage.</param>
        /// <param name="isEditSmart">是否为智能加药参数 if support smart dosage.</param>
        /// <param name="name">参数名称 parameter name.</param>
        /// <param name="code">参数编码 parameter code.</param>
        /// <param name="productLine">生产线 product line code.</param>
        /// <param name="category">药剂投加类别.</param>
        public DosingParameterOutput(Guid id = default(Guid), string sysCode = default(string), double value = default(double), string unit = default(string), int orderBy = default(int), bool? isEditManual = default(bool?), bool? isEditSmart = default(bool?), string name = default(string), string code = default(string), string productLine = default(string), CategoryEnum? category = default(CategoryEnum?))
        {
            this.Id = id;
            this.SysCode = sysCode;
            this.Value = value;
            this.Unit = unit;
            this.OrderBy = orderBy;
            this.IsEditManual = isEditManual;
            this.IsEditSmart = isEditSmart;
            this.Name = name;
            this.Code = code;
            this.ProductLine = productLine;
            this.Category = category;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid Id { get; set; }

        /// <summary>
        /// 系统代码 corresponding system code
        /// </summary>
        /// <value>系统代码 corresponding system code</value>
        [DataMember(Name="sysCode", EmitDefaultValue=true)]
        public string SysCode { get; set; }

        /// <summary>
        /// 值 value
        /// </summary>
        /// <value>值 value</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public double Value { get; set; }

        /// <summary>
        /// 单位 unit
        /// </summary>
        /// <value>单位 unit</value>
        [DataMember(Name="unit", EmitDefaultValue=true)]
        public string Unit { get; set; }

        /// <summary>
        /// 序号 display index
        /// </summary>
        /// <value>序号 display index</value>
        [DataMember(Name="orderBy", EmitDefaultValue=false)]
        public int OrderBy { get; set; }

        /// <summary>
        /// 是否为手动加药参数 if support manual dosage
        /// </summary>
        /// <value>是否为手动加药参数 if support manual dosage</value>
        [DataMember(Name="isEditManual", EmitDefaultValue=true)]
        public bool? IsEditManual { get; set; }

        /// <summary>
        /// 是否为智能加药参数 if support smart dosage
        /// </summary>
        /// <value>是否为智能加药参数 if support smart dosage</value>
        [DataMember(Name="isEditSmart", EmitDefaultValue=true)]
        public bool? IsEditSmart { get; set; }

        /// <summary>
        /// 参数名称 parameter name
        /// </summary>
        /// <value>参数名称 parameter name</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// 参数编码 parameter code
        /// </summary>
        /// <value>参数编码 parameter code</value>
        [DataMember(Name="code", EmitDefaultValue=true)]
        public string Code { get; set; }

        /// <summary>
        /// 生产线 product line code
        /// </summary>
        /// <value>生产线 product line code</value>
        [DataMember(Name="productLine", EmitDefaultValue=true)]
        public string ProductLine { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DosingParameterOutput {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  SysCode: ").Append(SysCode).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Unit: ").Append(Unit).Append("\n");
            sb.Append("  OrderBy: ").Append(OrderBy).Append("\n");
            sb.Append("  IsEditManual: ").Append(IsEditManual).Append("\n");
            sb.Append("  IsEditSmart: ").Append(IsEditSmart).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
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
            return this.Equals(input as DosingParameterOutput);
        }

        /// <summary>
        /// Returns true if DosingParameterOutput instances are equal
        /// </summary>
        /// <param name="input">Instance of DosingParameterOutput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DosingParameterOutput input)
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
                    this.SysCode == input.SysCode ||
                    (this.SysCode != null &&
                    this.SysCode.Equals(input.SysCode))
                ) && 
                (
                    this.Value == input.Value ||
                    this.Value.Equals(input.Value)
                ) && 
                (
                    this.Unit == input.Unit ||
                    (this.Unit != null &&
                    this.Unit.Equals(input.Unit))
                ) && 
                (
                    this.OrderBy == input.OrderBy ||
                    this.OrderBy.Equals(input.OrderBy)
                ) && 
                (
                    this.IsEditManual == input.IsEditManual ||
                    (this.IsEditManual != null &&
                    this.IsEditManual.Equals(input.IsEditManual))
                ) && 
                (
                    this.IsEditSmart == input.IsEditSmart ||
                    (this.IsEditSmart != null &&
                    this.IsEditSmart.Equals(input.IsEditSmart))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
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
                if (this.SysCode != null)
                    hashCode = hashCode * 59 + this.SysCode.GetHashCode();
                hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.Unit != null)
                    hashCode = hashCode * 59 + this.Unit.GetHashCode();
                hashCode = hashCode * 59 + this.OrderBy.GetHashCode();
                if (this.IsEditManual != null)
                    hashCode = hashCode * 59 + this.IsEditManual.GetHashCode();
                if (this.IsEditSmart != null)
                    hashCode = hashCode * 59 + this.IsEditSmart.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
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
