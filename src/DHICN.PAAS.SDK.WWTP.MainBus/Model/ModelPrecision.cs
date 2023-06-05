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
    /// 模型精度数据
    /// </summary>
    [DataContract]
    public partial class ModelPrecision :  IEquatable<ModelPrecision>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelPrecision" /> class.
        /// </summary>
        /// <param name="code">指标 indicator code.</param>
        /// <param name="unit">单位 unit.</param>
        /// <param name="evaluation">总体评价 overall evaluation.</param>
        /// <param name="levelCode">评价Code.</param>
        /// <param name="percentagesDistri">精度百分比区间占比 precision region detailed data.</param>
        public ModelPrecision(string code = default(string), string unit = default(string), string evaluation = default(string), string levelCode = default(string), List<PercentagesDto> percentagesDistri = default(List<PercentagesDto>))
        {
            this.Code = code;
            this.Unit = unit;
            this.Evaluation = evaluation;
            this.LevelCode = levelCode;
            this.PercentagesDistri = percentagesDistri;
        }
        
        /// <summary>
        /// 指标 indicator code
        /// </summary>
        /// <value>指标 indicator code</value>
        [DataMember(Name="code", EmitDefaultValue=true)]
        public string Code { get; set; }

        /// <summary>
        /// 单位 unit
        /// </summary>
        /// <value>单位 unit</value>
        [DataMember(Name="unit", EmitDefaultValue=true)]
        public string Unit { get; set; }

        /// <summary>
        /// 总体评价 overall evaluation
        /// </summary>
        /// <value>总体评价 overall evaluation</value>
        [DataMember(Name="evaluation", EmitDefaultValue=true)]
        public string Evaluation { get; set; }

        /// <summary>
        /// 评价Code
        /// </summary>
        /// <value>评价Code</value>
        [DataMember(Name="levelCode", EmitDefaultValue=true)]
        public string LevelCode { get; set; }

        /// <summary>
        /// 精度百分比区间占比 precision region detailed data
        /// </summary>
        /// <value>精度百分比区间占比 precision region detailed data</value>
        [DataMember(Name="percentagesDistri", EmitDefaultValue=true)]
        public List<PercentagesDto> PercentagesDistri { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModelPrecision {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Unit: ").Append(Unit).Append("\n");
            sb.Append("  Evaluation: ").Append(Evaluation).Append("\n");
            sb.Append("  LevelCode: ").Append(LevelCode).Append("\n");
            sb.Append("  PercentagesDistri: ").Append(PercentagesDistri).Append("\n");
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
            return this.Equals(input as ModelPrecision);
        }

        /// <summary>
        /// Returns true if ModelPrecision instances are equal
        /// </summary>
        /// <param name="input">Instance of ModelPrecision to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModelPrecision input)
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
                    this.Unit == input.Unit ||
                    (this.Unit != null &&
                    this.Unit.Equals(input.Unit))
                ) && 
                (
                    this.Evaluation == input.Evaluation ||
                    (this.Evaluation != null &&
                    this.Evaluation.Equals(input.Evaluation))
                ) && 
                (
                    this.LevelCode == input.LevelCode ||
                    (this.LevelCode != null &&
                    this.LevelCode.Equals(input.LevelCode))
                ) && 
                (
                    this.PercentagesDistri == input.PercentagesDistri ||
                    this.PercentagesDistri != null &&
                    input.PercentagesDistri != null &&
                    this.PercentagesDistri.SequenceEqual(input.PercentagesDistri)
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
                if (this.Unit != null)
                    hashCode = hashCode * 59 + this.Unit.GetHashCode();
                if (this.Evaluation != null)
                    hashCode = hashCode * 59 + this.Evaluation.GetHashCode();
                if (this.LevelCode != null)
                    hashCode = hashCode * 59 + this.LevelCode.GetHashCode();
                if (this.PercentagesDistri != null)
                    hashCode = hashCode * 59 + this.PercentagesDistri.GetHashCode();
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
