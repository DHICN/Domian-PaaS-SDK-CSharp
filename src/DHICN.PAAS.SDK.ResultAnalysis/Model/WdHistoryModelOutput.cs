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
    /// WdHistoryModelOutput
    /// </summary>
    [DataContract]
    public partial class WdHistoryModelOutput :  IEquatable<WdHistoryModelOutput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WdHistoryModelOutput" /> class.
        /// </summary>
        /// <param name="modelFeatureId">modelFeatureId.</param>
        /// <param name="ts">ts.</param>
        public WdHistoryModelOutput(string modelFeatureId = default(string), TsPairs ts = default(TsPairs))
        {
            this.ModelFeatureId = modelFeatureId;
            this.Ts = ts;
        }
        
        /// <summary>
        /// Gets or Sets ModelFeatureId
        /// </summary>
        [DataMember(Name="modelFeatureId", EmitDefaultValue=true)]
        public string ModelFeatureId { get; set; }

        /// <summary>
        /// Gets or Sets Ts
        /// </summary>
        [DataMember(Name="ts", EmitDefaultValue=false)]
        public TsPairs Ts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WdHistoryModelOutput {\n");
            sb.Append("  ModelFeatureId: ").Append(ModelFeatureId).Append("\n");
            sb.Append("  Ts: ").Append(Ts).Append("\n");
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
            return this.Equals(input as WdHistoryModelOutput);
        }

        /// <summary>
        /// Returns true if WdHistoryModelOutput instances are equal
        /// </summary>
        /// <param name="input">Instance of WdHistoryModelOutput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WdHistoryModelOutput input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ModelFeatureId == input.ModelFeatureId ||
                    (this.ModelFeatureId != null &&
                    this.ModelFeatureId.Equals(input.ModelFeatureId))
                ) && 
                (
                    this.Ts == input.Ts ||
                    (this.Ts != null &&
                    this.Ts.Equals(input.Ts))
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
                if (this.ModelFeatureId != null)
                    hashCode = hashCode * 59 + this.ModelFeatureId.GetHashCode();
                if (this.Ts != null)
                    hashCode = hashCode * 59 + this.Ts.GetHashCode();
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
