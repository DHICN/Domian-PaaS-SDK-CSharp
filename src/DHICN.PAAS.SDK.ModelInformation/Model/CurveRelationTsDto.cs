/* 
 * model-information-service
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
    /// CurveRelationTsDto
    /// </summary>
    [DataContract]
    public partial class CurveRelationTsDto :  IEquatable<CurveRelationTsDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CurveRelationTsDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CurveRelationTsDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CurveRelationTsDto" /> class.
        /// </summary>
        /// <param name="indicatorId">设备指标id，可以为空 device indicator id, can be null.</param>
        /// <param name="modelId">模型中曲线ID curve muid (required).</param>
        /// <param name="t">相对时间列表，单位秒 relative times in second.</param>
        /// <param name="v">数值列表 values.</param>
        /// <param name="id">曲线时序数据ID curve time-series data id.</param>
        public CurveRelationTsDto(Guid? indicatorId = default(Guid?), string modelId = default(string), List<int> t = default(List<int>), List<double> v = default(List<double>), Guid id = default(Guid))
        {
            // to ensure "modelId" is required (not null)
            this.ModelId = modelId ?? throw new ArgumentNullException("modelId is a required property for CurveRelationTsDto and cannot be null");
            this.IndicatorId = indicatorId;
            this.T = t;
            this.V = v;
            this.Id = id;
        }
        
        /// <summary>
        /// 设备指标id，可以为空 device indicator id, can be null
        /// </summary>
        /// <value>设备指标id，可以为空 device indicator id, can be null</value>
        [DataMember(Name="indicatorId", EmitDefaultValue=true)]
        public Guid? IndicatorId { get; set; }

        /// <summary>
        /// 模型中曲线ID curve muid
        /// </summary>
        /// <value>模型中曲线ID curve muid</value>
        [DataMember(Name="modelId", EmitDefaultValue=false)]
        public string ModelId { get; set; }

        /// <summary>
        /// 相对时间列表，单位秒 relative times in second
        /// </summary>
        /// <value>相对时间列表，单位秒 relative times in second</value>
        [DataMember(Name="t", EmitDefaultValue=true)]
        public List<int> T { get; set; }

        /// <summary>
        /// 数值列表 values
        /// </summary>
        /// <value>数值列表 values</value>
        [DataMember(Name="v", EmitDefaultValue=true)]
        public List<double> V { get; set; }

        /// <summary>
        /// 曲线时序数据ID curve time-series data id
        /// </summary>
        /// <value>曲线时序数据ID curve time-series data id</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CurveRelationTsDto {\n");
            sb.Append("  IndicatorId: ").Append(IndicatorId).Append("\n");
            sb.Append("  ModelId: ").Append(ModelId).Append("\n");
            sb.Append("  T: ").Append(T).Append("\n");
            sb.Append("  V: ").Append(V).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(input as CurveRelationTsDto);
        }

        /// <summary>
        /// Returns true if CurveRelationTsDto instances are equal
        /// </summary>
        /// <param name="input">Instance of CurveRelationTsDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CurveRelationTsDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IndicatorId == input.IndicatorId ||
                    (this.IndicatorId != null &&
                    this.IndicatorId.Equals(input.IndicatorId))
                ) && 
                (
                    this.ModelId == input.ModelId ||
                    (this.ModelId != null &&
                    this.ModelId.Equals(input.ModelId))
                ) && 
                (
                    this.T == input.T ||
                    this.T != null &&
                    input.T != null &&
                    this.T.SequenceEqual(input.T)
                ) && 
                (
                    this.V == input.V ||
                    this.V != null &&
                    input.V != null &&
                    this.V.SequenceEqual(input.V)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                if (this.IndicatorId != null)
                    hashCode = hashCode * 59 + this.IndicatorId.GetHashCode();
                if (this.ModelId != null)
                    hashCode = hashCode * 59 + this.ModelId.GetHashCode();
                if (this.T != null)
                    hashCode = hashCode * 59 + this.T.GetHashCode();
                if (this.V != null)
                    hashCode = hashCode * 59 + this.V.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
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
