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
    /// 河道水质动态结果
    /// </summary>
    [DataContract]
    public partial class ModelResultRiverWQsOutput :  IEquatable<ModelResultRiverWQsOutput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelResultRiverWQsOutput" /> class.
        /// </summary>
        /// <param name="time">时间 time.</param>
        /// <param name="iDs">河道名,里程 river,chainage.</param>
        /// <param name="wqItem">水质 water quality item.</param>
        /// <param name="concentration">浓度 concentration.</param>
        public ModelResultRiverWQsOutput(List<string> time = default(List<string>), List<string> iDs = default(List<string>), string wqItem = default(string), List<List<double>> concentration = default(List<List<double>>))
        {
            this.Time = time;
            this.IDs = iDs;
            this.WqItem = wqItem;
            this.Concentration = concentration;
        }
        
        /// <summary>
        /// 时间 time
        /// </summary>
        /// <value>时间 time</value>
        [DataMember(Name="time", EmitDefaultValue=true)]
        public List<string> Time { get; set; }

        /// <summary>
        /// 河道名,里程 river,chainage
        /// </summary>
        /// <value>河道名,里程 river,chainage</value>
        [DataMember(Name="iDs", EmitDefaultValue=true)]
        public List<string> IDs { get; set; }

        /// <summary>
        /// 水质 water quality item
        /// </summary>
        /// <value>水质 water quality item</value>
        [DataMember(Name="wqItem", EmitDefaultValue=true)]
        public string WqItem { get; set; }

        /// <summary>
        /// 浓度 concentration
        /// </summary>
        /// <value>浓度 concentration</value>
        [DataMember(Name="concentration", EmitDefaultValue=true)]
        public List<List<double>> Concentration { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModelResultRiverWQsOutput {\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  IDs: ").Append(IDs).Append("\n");
            sb.Append("  WqItem: ").Append(WqItem).Append("\n");
            sb.Append("  Concentration: ").Append(Concentration).Append("\n");
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
            return this.Equals(input as ModelResultRiverWQsOutput);
        }

        /// <summary>
        /// Returns true if ModelResultRiverWQsOutput instances are equal
        /// </summary>
        /// <param name="input">Instance of ModelResultRiverWQsOutput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModelResultRiverWQsOutput input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Time == input.Time ||
                    this.Time != null &&
                    input.Time != null &&
                    this.Time.SequenceEqual(input.Time)
                ) && 
                (
                    this.IDs == input.IDs ||
                    this.IDs != null &&
                    input.IDs != null &&
                    this.IDs.SequenceEqual(input.IDs)
                ) && 
                (
                    this.WqItem == input.WqItem ||
                    (this.WqItem != null &&
                    this.WqItem.Equals(input.WqItem))
                ) && 
                (
                    this.Concentration == input.Concentration ||
                    this.Concentration != null &&
                    input.Concentration != null &&
                    this.Concentration.SequenceEqual(input.Concentration)
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
                if (this.Time != null)
                    hashCode = hashCode * 59 + this.Time.GetHashCode();
                if (this.IDs != null)
                    hashCode = hashCode * 59 + this.IDs.GetHashCode();
                if (this.WqItem != null)
                    hashCode = hashCode * 59 + this.WqItem.GetHashCode();
                if (this.Concentration != null)
                    hashCode = hashCode * 59 + this.Concentration.GetHashCode();
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
