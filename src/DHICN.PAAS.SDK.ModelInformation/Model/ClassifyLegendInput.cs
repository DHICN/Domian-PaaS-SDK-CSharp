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
using OpenAPIDateConverter = DHICN.PAAS.SDK.ModelInformation.Client.OpenAPIDateConverter;

namespace DHICN.PAAS.SDK.ModelInformation.Model
{
    /// <summary>
    /// ClassifyLegendInput
    /// </summary>
    [DataContract]
    public partial class ClassifyLegendInput :  IEquatable<ClassifyLegendInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifyLegendInput" /> class.
        /// </summary>
        /// <param name="modelType">模型类型 model type.</param>
        /// <param name="dataType">数据类型 data type.</param>
        /// <param name="classifyLegends">图例项对应的等级设置信息 legend classifications.</param>
        public ClassifyLegendInput(string modelType = default(string), string dataType = default(string), List<ClassifyLegendInfo> classifyLegends = default(List<ClassifyLegendInfo>))
        {
            this.ModelType = modelType;
            this.DataType = dataType;
            this.ClassifyLegends = classifyLegends;
        }
        
        /// <summary>
        /// 模型类型 model type
        /// </summary>
        /// <value>模型类型 model type</value>
        [DataMember(Name="modelType", EmitDefaultValue=true)]
        public string ModelType { get; set; }

        /// <summary>
        /// 数据类型 data type
        /// </summary>
        /// <value>数据类型 data type</value>
        [DataMember(Name="dataType", EmitDefaultValue=true)]
        public string DataType { get; set; }

        /// <summary>
        /// 图例项对应的等级设置信息 legend classifications
        /// </summary>
        /// <value>图例项对应的等级设置信息 legend classifications</value>
        [DataMember(Name="classifyLegends", EmitDefaultValue=true)]
        public List<ClassifyLegendInfo> ClassifyLegends { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClassifyLegendInput {\n");
            sb.Append("  ModelType: ").Append(ModelType).Append("\n");
            sb.Append("  DataType: ").Append(DataType).Append("\n");
            sb.Append("  ClassifyLegends: ").Append(ClassifyLegends).Append("\n");
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
            return this.Equals(input as ClassifyLegendInput);
        }

        /// <summary>
        /// Returns true if ClassifyLegendInput instances are equal
        /// </summary>
        /// <param name="input">Instance of ClassifyLegendInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClassifyLegendInput input)
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
                    this.DataType == input.DataType ||
                    (this.DataType != null &&
                    this.DataType.Equals(input.DataType))
                ) && 
                (
                    this.ClassifyLegends == input.ClassifyLegends ||
                    this.ClassifyLegends != null &&
                    input.ClassifyLegends != null &&
                    this.ClassifyLegends.SequenceEqual(input.ClassifyLegends)
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
                if (this.DataType != null)
                    hashCode = hashCode * 59 + this.DataType.GetHashCode();
                if (this.ClassifyLegends != null)
                    hashCode = hashCode * 59 + this.ClassifyLegends.GetHashCode();
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
