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
    /// WqMaxStatistic
    /// </summary>
    [DataContract]
    public partial class WqMaxStatistic :  IEquatable<WqMaxStatistic>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WqMaxStatistic" /> class.
        /// </summary>
        /// <param name="wqItem">水质项 water quality item.</param>
        /// <param name="wqItemMaxValue">最大值 max value.</param>
        /// <param name="isExceed">是否超标 is exceed.</param>
        /// <param name="maxModelFeatureId">最大浓度位置 Maximum concentration modelfeature id.</param>
        public WqMaxStatistic(string wqItem = default(string), double wqItemMaxValue = default(double), int isExceed = default(int), string maxModelFeatureId = default(string))
        {
            this.WqItem = wqItem;
            this.WqItemMaxValue = wqItemMaxValue;
            this.IsExceed = isExceed;
            this.MaxModelFeatureId = maxModelFeatureId;
        }
        
        /// <summary>
        /// 水质项 water quality item
        /// </summary>
        /// <value>水质项 water quality item</value>
        [DataMember(Name="wqItem", EmitDefaultValue=true)]
        public string WqItem { get; set; }

        /// <summary>
        /// 最大值 max value
        /// </summary>
        /// <value>最大值 max value</value>
        [DataMember(Name="wqItemMaxValue", EmitDefaultValue=false)]
        public double WqItemMaxValue { get; set; }

        /// <summary>
        /// 是否超标 is exceed
        /// </summary>
        /// <value>是否超标 is exceed</value>
        [DataMember(Name="isExceed", EmitDefaultValue=false)]
        public int IsExceed { get; set; }

        /// <summary>
        /// 最大浓度位置 Maximum concentration modelfeature id
        /// </summary>
        /// <value>最大浓度位置 Maximum concentration modelfeature id</value>
        [DataMember(Name="maxModelFeatureId", EmitDefaultValue=true)]
        public string MaxModelFeatureId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WqMaxStatistic {\n");
            sb.Append("  WqItem: ").Append(WqItem).Append("\n");
            sb.Append("  WqItemMaxValue: ").Append(WqItemMaxValue).Append("\n");
            sb.Append("  IsExceed: ").Append(IsExceed).Append("\n");
            sb.Append("  MaxModelFeatureId: ").Append(MaxModelFeatureId).Append("\n");
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
            return this.Equals(input as WqMaxStatistic);
        }

        /// <summary>
        /// Returns true if WqMaxStatistic instances are equal
        /// </summary>
        /// <param name="input">Instance of WqMaxStatistic to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WqMaxStatistic input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.WqItem == input.WqItem ||
                    (this.WqItem != null &&
                    this.WqItem.Equals(input.WqItem))
                ) && 
                (
                    this.WqItemMaxValue == input.WqItemMaxValue ||
                    this.WqItemMaxValue.Equals(input.WqItemMaxValue)
                ) && 
                (
                    this.IsExceed == input.IsExceed ||
                    this.IsExceed.Equals(input.IsExceed)
                ) && 
                (
                    this.MaxModelFeatureId == input.MaxModelFeatureId ||
                    (this.MaxModelFeatureId != null &&
                    this.MaxModelFeatureId.Equals(input.MaxModelFeatureId))
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
                if (this.WqItem != null)
                    hashCode = hashCode * 59 + this.WqItem.GetHashCode();
                hashCode = hashCode * 59 + this.WqItemMaxValue.GetHashCode();
                hashCode = hashCode * 59 + this.IsExceed.GetHashCode();
                if (this.MaxModelFeatureId != null)
                    hashCode = hashCode * 59 + this.MaxModelFeatureId.GetHashCode();
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
