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
    /// TraceWqValveInfo
    /// </summary>
    [DataContract]
    public partial class TraceWqValveInfo :  IEquatable<TraceWqValveInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TraceWqValveInfo" /> class.
        /// </summary>
        /// <param name="gisId">Gis Id.</param>
        /// <param name="x">坐标 - X.</param>
        /// <param name="y">坐标 - Y.</param>
        /// <param name="z">坐标 - Z.</param>
        public TraceWqValveInfo(string gisId = default(string), double x = default(double), double y = default(double), double z = default(double))
        {
            this.GisId = gisId;
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        
        /// <summary>
        /// Gis Id
        /// </summary>
        /// <value>Gis Id</value>
        [DataMember(Name="gisId", EmitDefaultValue=true)]
        public string GisId { get; set; }

        /// <summary>
        /// 坐标 - X
        /// </summary>
        /// <value>坐标 - X</value>
        [DataMember(Name="x", EmitDefaultValue=false)]
        public double X { get; set; }

        /// <summary>
        /// 坐标 - Y
        /// </summary>
        /// <value>坐标 - Y</value>
        [DataMember(Name="y", EmitDefaultValue=false)]
        public double Y { get; set; }

        /// <summary>
        /// 坐标 - Z
        /// </summary>
        /// <value>坐标 - Z</value>
        [DataMember(Name="z", EmitDefaultValue=false)]
        public double Z { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TraceWqValveInfo {\n");
            sb.Append("  GisId: ").Append(GisId).Append("\n");
            sb.Append("  X: ").Append(X).Append("\n");
            sb.Append("  Y: ").Append(Y).Append("\n");
            sb.Append("  Z: ").Append(Z).Append("\n");
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
            return this.Equals(input as TraceWqValveInfo);
        }

        /// <summary>
        /// Returns true if TraceWqValveInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of TraceWqValveInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TraceWqValveInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GisId == input.GisId ||
                    (this.GisId != null &&
                    this.GisId.Equals(input.GisId))
                ) && 
                (
                    this.X == input.X ||
                    this.X.Equals(input.X)
                ) && 
                (
                    this.Y == input.Y ||
                    this.Y.Equals(input.Y)
                ) && 
                (
                    this.Z == input.Z ||
                    this.Z.Equals(input.Z)
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
                if (this.GisId != null)
                    hashCode = hashCode * 59 + this.GisId.GetHashCode();
                hashCode = hashCode * 59 + this.X.GetHashCode();
                hashCode = hashCode * 59 + this.Y.GetHashCode();
                hashCode = hashCode * 59 + this.Z.GetHashCode();
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
