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
    /// WqInstantStatisticInfo
    /// </summary>
    [DataContract]
    public partial class WqInstantStatisticInfo :  IEquatable<WqInstantStatisticInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WqInstantStatisticInfo" /> class.
        /// </summary>
        /// <param name="dt">时间 time.</param>
        /// <param name="wqInfos">水质信息列表 list of water quality information.</param>
        public WqInstantStatisticInfo(string dt = default(string), List<WqValueInfo> wqInfos = default(List<WqValueInfo>))
        {
            this.Dt = dt;
            this.WqInfos = wqInfos;
        }
        
        /// <summary>
        /// 时间 time
        /// </summary>
        /// <value>时间 time</value>
        [DataMember(Name="dt", EmitDefaultValue=true)]
        public string Dt { get; set; }

        /// <summary>
        /// 水质信息列表 list of water quality information
        /// </summary>
        /// <value>水质信息列表 list of water quality information</value>
        [DataMember(Name="wqInfos", EmitDefaultValue=true)]
        public List<WqValueInfo> WqInfos { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WqInstantStatisticInfo {\n");
            sb.Append("  Dt: ").Append(Dt).Append("\n");
            sb.Append("  WqInfos: ").Append(WqInfos).Append("\n");
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
            return this.Equals(input as WqInstantStatisticInfo);
        }

        /// <summary>
        /// Returns true if WqInstantStatisticInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of WqInstantStatisticInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WqInstantStatisticInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Dt == input.Dt ||
                    (this.Dt != null &&
                    this.Dt.Equals(input.Dt))
                ) && 
                (
                    this.WqInfos == input.WqInfos ||
                    this.WqInfos != null &&
                    input.WqInfos != null &&
                    this.WqInfos.SequenceEqual(input.WqInfos)
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
                if (this.Dt != null)
                    hashCode = hashCode * 59 + this.Dt.GetHashCode();
                if (this.WqInfos != null)
                    hashCode = hashCode * 59 + this.WqInfos.GetHashCode();
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
