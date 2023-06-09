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
    /// PatternInfo
    /// </summary>
    [DataContract]
    public partial class PatternInfo :  IEquatable<PatternInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PatternInfo" /> class.
        /// </summary>
        /// <param name="patternID">patternID.</param>
        /// <param name="t">t.</param>
        /// <param name="v">v.</param>
        public PatternInfo(string patternID = default(string), List<string> t = default(List<string>), List<double> v = default(List<double>))
        {
            this.PatternID = patternID;
            this.T = t;
            this.V = v;
        }
        
        /// <summary>
        /// Gets or Sets PatternID
        /// </summary>
        [DataMember(Name="patternID", EmitDefaultValue=true)]
        public string PatternID { get; set; }

        /// <summary>
        /// Gets or Sets T
        /// </summary>
        [DataMember(Name="t", EmitDefaultValue=true)]
        public List<string> T { get; set; }

        /// <summary>
        /// Gets or Sets V
        /// </summary>
        [DataMember(Name="v", EmitDefaultValue=true)]
        public List<double> V { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PatternInfo {\n");
            sb.Append("  PatternID: ").Append(PatternID).Append("\n");
            sb.Append("  T: ").Append(T).Append("\n");
            sb.Append("  V: ").Append(V).Append("\n");
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
            return this.Equals(input as PatternInfo);
        }

        /// <summary>
        /// Returns true if PatternInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of PatternInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PatternInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PatternID == input.PatternID ||
                    (this.PatternID != null &&
                    this.PatternID.Equals(input.PatternID))
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
                if (this.PatternID != null)
                    hashCode = hashCode * 59 + this.PatternID.GetHashCode();
                if (this.T != null)
                    hashCode = hashCode * 59 + this.T.GetHashCode();
                if (this.V != null)
                    hashCode = hashCode * 59 + this.V.GetHashCode();
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
