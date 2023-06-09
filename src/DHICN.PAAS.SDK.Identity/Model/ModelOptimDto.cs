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
    /// ModelOptimDto
    /// </summary>
    [DataContract]
    public partial class ModelOptimDto :  IEquatable<ModelOptimDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelOptimDto" /> class.
        /// </summary>
        /// <param name="controlItems">控制项数据 control item data.</param>
        /// <param name="precisionWQs">预测出水水质 effluent water quality data.</param>
        public ModelOptimDto(List<ControlItem> controlItems = default(List<ControlItem>), List<PrecisionWq> precisionWQs = default(List<PrecisionWq>))
        {
            this.ControlItems = controlItems;
            this.PrecisionWQs = precisionWQs;
        }
        
        /// <summary>
        /// 控制项数据 control item data
        /// </summary>
        /// <value>控制项数据 control item data</value>
        [DataMember(Name="controlItems", EmitDefaultValue=true)]
        public List<ControlItem> ControlItems { get; set; }

        /// <summary>
        /// 预测出水水质 effluent water quality data
        /// </summary>
        /// <value>预测出水水质 effluent water quality data</value>
        [DataMember(Name="precisionWQs", EmitDefaultValue=true)]
        public List<PrecisionWq> PrecisionWQs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModelOptimDto {\n");
            sb.Append("  ControlItems: ").Append(ControlItems).Append("\n");
            sb.Append("  PrecisionWQs: ").Append(PrecisionWQs).Append("\n");
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
            return this.Equals(input as ModelOptimDto);
        }

        /// <summary>
        /// Returns true if ModelOptimDto instances are equal
        /// </summary>
        /// <param name="input">Instance of ModelOptimDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModelOptimDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ControlItems == input.ControlItems ||
                    this.ControlItems != null &&
                    input.ControlItems != null &&
                    this.ControlItems.SequenceEqual(input.ControlItems)
                ) && 
                (
                    this.PrecisionWQs == input.PrecisionWQs ||
                    this.PrecisionWQs != null &&
                    input.PrecisionWQs != null &&
                    this.PrecisionWQs.SequenceEqual(input.PrecisionWQs)
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
                if (this.ControlItems != null)
                    hashCode = hashCode * 59 + this.ControlItems.GetHashCode();
                if (this.PrecisionWQs != null)
                    hashCode = hashCode * 59 + this.PrecisionWQs.GetHashCode();
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
