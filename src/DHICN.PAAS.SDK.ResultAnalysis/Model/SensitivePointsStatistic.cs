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
    /// SensitivePointsStatistic
    /// </summary>
    [DataContract]
    public partial class SensitivePointsStatistic :  IEquatable<SensitivePointsStatistic>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SensitivePointsStatistic" /> class.
        /// </summary>
        /// <param name="pointID">易涝点ID flood sensitive point ID.</param>
        /// <param name="pointName">易涝点名称 flood sensitive point name.</param>
        /// <param name="tsData">易涝点的统计数据 time series statistic data.</param>
        public SensitivePointsStatistic(string pointID = default(string), string pointName = default(string), List<SensitivePointsTimeseries> tsData = default(List<SensitivePointsTimeseries>))
        {
            this.PointID = pointID;
            this.PointName = pointName;
            this.TsData = tsData;
        }
        
        /// <summary>
        /// 易涝点ID flood sensitive point ID
        /// </summary>
        /// <value>易涝点ID flood sensitive point ID</value>
        [DataMember(Name="pointID", EmitDefaultValue=true)]
        public string PointID { get; set; }

        /// <summary>
        /// 易涝点名称 flood sensitive point name
        /// </summary>
        /// <value>易涝点名称 flood sensitive point name</value>
        [DataMember(Name="pointName", EmitDefaultValue=true)]
        public string PointName { get; set; }

        /// <summary>
        /// 易涝点的统计数据 time series statistic data
        /// </summary>
        /// <value>易涝点的统计数据 time series statistic data</value>
        [DataMember(Name="tsData", EmitDefaultValue=true)]
        public List<SensitivePointsTimeseries> TsData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SensitivePointsStatistic {\n");
            sb.Append("  PointID: ").Append(PointID).Append("\n");
            sb.Append("  PointName: ").Append(PointName).Append("\n");
            sb.Append("  TsData: ").Append(TsData).Append("\n");
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
            return this.Equals(input as SensitivePointsStatistic);
        }

        /// <summary>
        /// Returns true if SensitivePointsStatistic instances are equal
        /// </summary>
        /// <param name="input">Instance of SensitivePointsStatistic to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SensitivePointsStatistic input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PointID == input.PointID ||
                    (this.PointID != null &&
                    this.PointID.Equals(input.PointID))
                ) && 
                (
                    this.PointName == input.PointName ||
                    (this.PointName != null &&
                    this.PointName.Equals(input.PointName))
                ) && 
                (
                    this.TsData == input.TsData ||
                    this.TsData != null &&
                    input.TsData != null &&
                    this.TsData.SequenceEqual(input.TsData)
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
                if (this.PointID != null)
                    hashCode = hashCode * 59 + this.PointID.GetHashCode();
                if (this.PointName != null)
                    hashCode = hashCode * 59 + this.PointName.GetHashCode();
                if (this.TsData != null)
                    hashCode = hashCode * 59 + this.TsData.GetHashCode();
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
