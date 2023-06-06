/* 
 * model-configuration-service
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
using OpenAPIDateConverter = DHICN.PAAS.SDK.ModelConfiguration.Client.OpenAPIDateConverter;

namespace DHICN.PAAS.SDK.ModelConfiguration.Model
{
    /// <summary>
    /// LegendItemDto
    /// </summary>
    [DataContract]
    public partial class LegendItemDto :  IEquatable<LegendItemDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LegendItemDto" /> class.
        /// </summary>
        /// <param name="modelType">模型类型 model type.</param>
        /// <param name="resultType">结果类型 result type.</param>
        /// <param name="typeName">数据类型 data type name.</param>
        /// <param name="description">描述 description.</param>
        public LegendItemDto(string modelType = default(string), string resultType = default(string), string typeName = default(string), string description = default(string))
        {
            this.ModelType = modelType;
            this.ResultType = resultType;
            this.TypeName = typeName;
            this.Description = description;
        }
        
        /// <summary>
        /// 模型类型 model type
        /// </summary>
        /// <value>模型类型 model type</value>
        [DataMember(Name="modelType", EmitDefaultValue=true)]
        public string ModelType { get; set; }

        /// <summary>
        /// 结果类型 result type
        /// </summary>
        /// <value>结果类型 result type</value>
        [DataMember(Name="resultType", EmitDefaultValue=true)]
        public string ResultType { get; set; }

        /// <summary>
        /// 数据类型 data type name
        /// </summary>
        /// <value>数据类型 data type name</value>
        [DataMember(Name="typeName", EmitDefaultValue=true)]
        public string TypeName { get; set; }

        /// <summary>
        /// 描述 description
        /// </summary>
        /// <value>描述 description</value>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LegendItemDto {\n");
            sb.Append("  ModelType: ").Append(ModelType).Append("\n");
            sb.Append("  ResultType: ").Append(ResultType).Append("\n");
            sb.Append("  TypeName: ").Append(TypeName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return this.Equals(input as LegendItemDto);
        }

        /// <summary>
        /// Returns true if LegendItemDto instances are equal
        /// </summary>
        /// <param name="input">Instance of LegendItemDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LegendItemDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ModelType == input.ModelType ||
                    (this.ModelType != null &&
                    this.ModelType.Equals(input.ModelType))
                ) && 
                (
                    this.ResultType == input.ResultType ||
                    (this.ResultType != null &&
                    this.ResultType.Equals(input.ResultType))
                ) && 
                (
                    this.TypeName == input.TypeName ||
                    (this.TypeName != null &&
                    this.TypeName.Equals(input.TypeName))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                if (this.ModelType != null)
                    hashCode = hashCode * 59 + this.ModelType.GetHashCode();
                if (this.ResultType != null)
                    hashCode = hashCode * 59 + this.ResultType.GetHashCode();
                if (this.TypeName != null)
                    hashCode = hashCode * 59 + this.TypeName.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
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
