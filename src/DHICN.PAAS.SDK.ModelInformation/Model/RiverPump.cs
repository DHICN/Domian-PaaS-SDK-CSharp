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
    /// RiverPump
    /// </summary>
    [DataContract]
    public partial class RiverPump :  IEquatable<RiverPump>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RiverPump" /> class.
        /// </summary>
        /// <param name="pumpID">pumpID.</param>
        /// <param name="controlWL">controlWL.</param>
        /// <param name="capacity">capacity.</param>
        public RiverPump(string pumpID = default(string), double controlWL = default(double), double capacity = default(double))
        {
            this.PumpID = pumpID;
            this.ControlWL = controlWL;
            this.Capacity = capacity;
        }
        
        /// <summary>
        /// Gets or Sets PumpID
        /// </summary>
        [DataMember(Name="pumpID", EmitDefaultValue=true)]
        public string PumpID { get; set; }

        /// <summary>
        /// Gets or Sets ControlWL
        /// </summary>
        [DataMember(Name="controlWL", EmitDefaultValue=false)]
        public double ControlWL { get; set; }

        /// <summary>
        /// Gets or Sets Capacity
        /// </summary>
        [DataMember(Name="capacity", EmitDefaultValue=false)]
        public double Capacity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RiverPump {\n");
            sb.Append("  PumpID: ").Append(PumpID).Append("\n");
            sb.Append("  ControlWL: ").Append(ControlWL).Append("\n");
            sb.Append("  Capacity: ").Append(Capacity).Append("\n");
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
            return this.Equals(input as RiverPump);
        }

        /// <summary>
        /// Returns true if RiverPump instances are equal
        /// </summary>
        /// <param name="input">Instance of RiverPump to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RiverPump input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PumpID == input.PumpID ||
                    (this.PumpID != null &&
                    this.PumpID.Equals(input.PumpID))
                ) && 
                (
                    this.ControlWL == input.ControlWL ||
                    this.ControlWL.Equals(input.ControlWL)
                ) && 
                (
                    this.Capacity == input.Capacity ||
                    this.Capacity.Equals(input.Capacity)
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
                if (this.PumpID != null)
                    hashCode = hashCode * 59 + this.PumpID.GetHashCode();
                hashCode = hashCode * 59 + this.ControlWL.GetHashCode();
                hashCode = hashCode * 59 + this.Capacity.GetHashCode();
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
