/* 
 * result-analysis-service
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
using OpenAPIDateConverter = DHICN.PAAS.SDK.ResultAnalysis.Client.OpenAPIDateConverter;

namespace DHICN.PAAS.SDK.ResultAnalysis.Model
{
    /// <summary>
    /// StatisticsModelIdResultDto
    /// </summary>
    [DataContract]
    public partial class StatisticsModelIdResultDto :  IEquatable<StatisticsModelIdResultDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StatisticsModelIdResultDto" /> class.
        /// </summary>
        /// <param name="modelId">modelId.</param>
        /// <param name="statisticModelIdItem">statisticModelIdItem.</param>
        public StatisticsModelIdResultDto(string modelId = default(string), StatisticModelIdItemDto statisticModelIdItem = default(StatisticModelIdItemDto))
        {
            this.ModelId = modelId;
            this.StatisticModelIdItem = statisticModelIdItem;
        }
        
        /// <summary>
        /// Gets or Sets ModelId
        /// </summary>
        [DataMember(Name="modelId", EmitDefaultValue=true)]
        public string ModelId { get; set; }

        /// <summary>
        /// Gets or Sets StatisticModelIdItem
        /// </summary>
        [DataMember(Name="statisticModelIdItem", EmitDefaultValue=false)]
        public StatisticModelIdItemDto StatisticModelIdItem { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StatisticsModelIdResultDto {\n");
            sb.Append("  ModelId: ").Append(ModelId).Append("\n");
            sb.Append("  StatisticModelIdItem: ").Append(StatisticModelIdItem).Append("\n");
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
            return this.Equals(input as StatisticsModelIdResultDto);
        }

        /// <summary>
        /// Returns true if StatisticsModelIdResultDto instances are equal
        /// </summary>
        /// <param name="input">Instance of StatisticsModelIdResultDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StatisticsModelIdResultDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ModelId == input.ModelId ||
                    (this.ModelId != null &&
                    this.ModelId.Equals(input.ModelId))
                ) && 
                (
                    this.StatisticModelIdItem == input.StatisticModelIdItem ||
                    (this.StatisticModelIdItem != null &&
                    this.StatisticModelIdItem.Equals(input.StatisticModelIdItem))
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
                if (this.ModelId != null)
                    hashCode = hashCode * 59 + this.ModelId.GetHashCode();
                if (this.StatisticModelIdItem != null)
                    hashCode = hashCode * 59 + this.StatisticModelIdItem.GetHashCode();
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
