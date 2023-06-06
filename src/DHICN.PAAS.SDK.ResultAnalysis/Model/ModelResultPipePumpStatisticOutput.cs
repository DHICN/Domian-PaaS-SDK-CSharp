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
    /// 管网泵运行预报统计
    /// </summary>
    [DataContract]
    public partial class ModelResultPipePumpStatisticOutput :  IEquatable<ModelResultPipePumpStatisticOutput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelResultPipePumpStatisticOutput" /> class.
        /// </summary>
        /// <param name="assetID">泵站id pump id.</param>
        /// <param name="assetName">泵站名称 pump name.</param>
        /// <param name="totalMinutes">总补水时长，以分钟为单位 total water make-up duration (unit:minute).</param>
        /// <param name="totalVolume">总补水量 total make-up water.</param>
        public ModelResultPipePumpStatisticOutput(string assetID = default(string), string assetName = default(string), double totalMinutes = default(double), double totalVolume = default(double))
        {
            this.AssetID = assetID;
            this.AssetName = assetName;
            this.TotalMinutes = totalMinutes;
            this.TotalVolume = totalVolume;
        }
        
        /// <summary>
        /// 泵站id pump id
        /// </summary>
        /// <value>泵站id pump id</value>
        [DataMember(Name="assetID", EmitDefaultValue=true)]
        public string AssetID { get; set; }

        /// <summary>
        /// 泵站名称 pump name
        /// </summary>
        /// <value>泵站名称 pump name</value>
        [DataMember(Name="assetName", EmitDefaultValue=true)]
        public string AssetName { get; set; }

        /// <summary>
        /// 总补水时长，以分钟为单位 total water make-up duration (unit:minute)
        /// </summary>
        /// <value>总补水时长，以分钟为单位 total water make-up duration (unit:minute)</value>
        [DataMember(Name="totalMinutes", EmitDefaultValue=false)]
        public double TotalMinutes { get; set; }

        /// <summary>
        /// 总补水量 total make-up water
        /// </summary>
        /// <value>总补水量 total make-up water</value>
        [DataMember(Name="totalVolume", EmitDefaultValue=false)]
        public double TotalVolume { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModelResultPipePumpStatisticOutput {\n");
            sb.Append("  AssetID: ").Append(AssetID).Append("\n");
            sb.Append("  AssetName: ").Append(AssetName).Append("\n");
            sb.Append("  TotalMinutes: ").Append(TotalMinutes).Append("\n");
            sb.Append("  TotalVolume: ").Append(TotalVolume).Append("\n");
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
            return this.Equals(input as ModelResultPipePumpStatisticOutput);
        }

        /// <summary>
        /// Returns true if ModelResultPipePumpStatisticOutput instances are equal
        /// </summary>
        /// <param name="input">Instance of ModelResultPipePumpStatisticOutput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModelResultPipePumpStatisticOutput input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AssetID == input.AssetID ||
                    (this.AssetID != null &&
                    this.AssetID.Equals(input.AssetID))
                ) && 
                (
                    this.AssetName == input.AssetName ||
                    (this.AssetName != null &&
                    this.AssetName.Equals(input.AssetName))
                ) && 
                (
                    this.TotalMinutes == input.TotalMinutes ||
                    this.TotalMinutes.Equals(input.TotalMinutes)
                ) && 
                (
                    this.TotalVolume == input.TotalVolume ||
                    this.TotalVolume.Equals(input.TotalVolume)
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
                if (this.AssetID != null)
                    hashCode = hashCode * 59 + this.AssetID.GetHashCode();
                if (this.AssetName != null)
                    hashCode = hashCode * 59 + this.AssetName.GetHashCode();
                hashCode = hashCode * 59 + this.TotalMinutes.GetHashCode();
                hashCode = hashCode * 59 + this.TotalVolume.GetHashCode();
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
