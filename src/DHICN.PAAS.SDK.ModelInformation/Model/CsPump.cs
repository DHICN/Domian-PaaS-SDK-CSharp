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
    /// CsPump
    /// </summary>
    [DataContract]
    public partial class CsPump :  IEquatable<CsPump>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CsPump" /> class.
        /// </summary>
        /// <param name="pumpID">pumpID.</param>
        /// <param name="startLevel">startLevel.</param>
        /// <param name="stopLevel">stopLevel.</param>
        /// <param name="capacity">capacity.</param>
        public CsPump(string pumpID = default(string), double startLevel = default(double), double stopLevel = default(double), double capacity = default(double))
        {
            this.PumpID = pumpID;
            this.StartLevel = startLevel;
            this.StopLevel = stopLevel;
            this.Capacity = capacity;
        }
        
        /// <summary>
        /// Gets or Sets PumpID
        /// </summary>
        [DataMember(Name="pumpID", EmitDefaultValue=true)]
        public string PumpID { get; set; }

        /// <summary>
        /// Gets or Sets StartLevel
        /// </summary>
        [DataMember(Name="startLevel", EmitDefaultValue=false)]
        public double StartLevel { get; set; }

        /// <summary>
        /// Gets or Sets StopLevel
        /// </summary>
        [DataMember(Name="stopLevel", EmitDefaultValue=false)]
        public double StopLevel { get; set; }

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
            sb.Append("class CsPump {\n");
            sb.Append("  PumpID: ").Append(PumpID).Append("\n");
            sb.Append("  StartLevel: ").Append(StartLevel).Append("\n");
            sb.Append("  StopLevel: ").Append(StopLevel).Append("\n");
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
            return this.Equals(input as CsPump);
        }

        /// <summary>
        /// Returns true if CsPump instances are equal
        /// </summary>
        /// <param name="input">Instance of CsPump to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CsPump input)
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
                    this.StartLevel == input.StartLevel ||
                    this.StartLevel.Equals(input.StartLevel)
                ) && 
                (
                    this.StopLevel == input.StopLevel ||
                    this.StopLevel.Equals(input.StopLevel)
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
                hashCode = hashCode * 59 + this.StartLevel.GetHashCode();
                hashCode = hashCode * 59 + this.StopLevel.GetHashCode();
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