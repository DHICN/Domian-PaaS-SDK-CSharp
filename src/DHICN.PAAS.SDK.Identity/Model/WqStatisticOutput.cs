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
    /// WqStatisticOutput
    /// </summary>
    [DataContract]
    public partial class WqStatisticOutput :  IEquatable<WqStatisticOutput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WqStatisticOutput" /> class.
        /// </summary>
        /// <param name="bioChemicalTank">生化池名称 biochemical pool name.</param>
        /// <param name="data">统计数据 statistic data.</param>
        public WqStatisticOutput(string bioChemicalTank = default(string), List<StatisticData> data = default(List<StatisticData>))
        {
            this.BioChemicalTank = bioChemicalTank;
            this.Data = data;
        }
        
        /// <summary>
        /// 生化池名称 biochemical pool name
        /// </summary>
        /// <value>生化池名称 biochemical pool name</value>
        [DataMember(Name="bioChemicalTank", EmitDefaultValue=true)]
        public string BioChemicalTank { get; set; }

        /// <summary>
        /// 统计数据 statistic data
        /// </summary>
        /// <value>统计数据 statistic data</value>
        [DataMember(Name="data", EmitDefaultValue=true)]
        public List<StatisticData> Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WqStatisticOutput {\n");
            sb.Append("  BioChemicalTank: ").Append(BioChemicalTank).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
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
            return this.Equals(input as WqStatisticOutput);
        }

        /// <summary>
        /// Returns true if WqStatisticOutput instances are equal
        /// </summary>
        /// <param name="input">Instance of WqStatisticOutput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WqStatisticOutput input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BioChemicalTank == input.BioChemicalTank ||
                    (this.BioChemicalTank != null &&
                    this.BioChemicalTank.Equals(input.BioChemicalTank))
                ) && 
                (
                    this.Data == input.Data ||
                    this.Data != null &&
                    input.Data != null &&
                    this.Data.SequenceEqual(input.Data)
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
                if (this.BioChemicalTank != null)
                    hashCode = hashCode * 59 + this.BioChemicalTank.GetHashCode();
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
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
