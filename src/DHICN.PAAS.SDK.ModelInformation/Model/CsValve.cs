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
    /// CsValve
    /// </summary>
    [DataContract]
    public partial class CsValve :  IEquatable<CsValve>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CsValve" /> class.
        /// </summary>
        /// <param name="valveID">valveID.</param>
        /// <param name="opening">opening.</param>
        public CsValve(string valveID = default(string), double opening = default(double))
        {
            this.ValveID = valveID;
            this.Opening = opening;
        }
        
        /// <summary>
        /// Gets or Sets ValveID
        /// </summary>
        [DataMember(Name="valveID", EmitDefaultValue=true)]
        public string ValveID { get; set; }

        /// <summary>
        /// Gets or Sets Opening
        /// </summary>
        [DataMember(Name="opening", EmitDefaultValue=false)]
        public double Opening { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CsValve {\n");
            sb.Append("  ValveID: ").Append(ValveID).Append("\n");
            sb.Append("  Opening: ").Append(Opening).Append("\n");
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
            return this.Equals(input as CsValve);
        }

        /// <summary>
        /// Returns true if CsValve instances are equal
        /// </summary>
        /// <param name="input">Instance of CsValve to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CsValve input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ValveID == input.ValveID ||
                    (this.ValveID != null &&
                    this.ValveID.Equals(input.ValveID))
                ) && 
                (
                    this.Opening == input.Opening ||
                    this.Opening.Equals(input.Opening)
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
                if (this.ValveID != null)
                    hashCode = hashCode * 59 + this.ValveID.GetHashCode();
                hashCode = hashCode * 59 + this.Opening.GetHashCode();
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
