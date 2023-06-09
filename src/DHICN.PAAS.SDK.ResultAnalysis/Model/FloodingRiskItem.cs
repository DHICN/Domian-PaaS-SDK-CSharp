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
    /// FloodingRiskItem
    /// </summary>
    [DataContract]
    public partial class FloodingRiskItem :  IEquatable<FloodingRiskItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FloodingRiskItem" /> class.
        /// </summary>
        /// <param name="geometry">内涝风险区域的空间几何信息，采用GeoJSON格式 geometry in GeoJson format.</param>
        /// <param name="area">内涝风险区域的面积 area.</param>
        public FloodingRiskItem(string geometry = default(string), int area = default(int))
        {
            this.Geometry = geometry;
            this.Area = area;
        }
        
        /// <summary>
        /// 内涝风险区域的空间几何信息，采用GeoJSON格式 geometry in GeoJson format
        /// </summary>
        /// <value>内涝风险区域的空间几何信息，采用GeoJSON格式 geometry in GeoJson format</value>
        [DataMember(Name="geometry", EmitDefaultValue=true)]
        public string Geometry { get; set; }

        /// <summary>
        /// 内涝风险区域的面积 area
        /// </summary>
        /// <value>内涝风险区域的面积 area</value>
        [DataMember(Name="area", EmitDefaultValue=false)]
        public int Area { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FloodingRiskItem {\n");
            sb.Append("  Geometry: ").Append(Geometry).Append("\n");
            sb.Append("  Area: ").Append(Area).Append("\n");
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
            return this.Equals(input as FloodingRiskItem);
        }

        /// <summary>
        /// Returns true if FloodingRiskItem instances are equal
        /// </summary>
        /// <param name="input">Instance of FloodingRiskItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FloodingRiskItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Geometry == input.Geometry ||
                    (this.Geometry != null &&
                    this.Geometry.Equals(input.Geometry))
                ) && 
                (
                    this.Area == input.Area ||
                    this.Area.Equals(input.Area)
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
                if (this.Geometry != null)
                    hashCode = hashCode * 59 + this.Geometry.GetHashCode();
                hashCode = hashCode * 59 + this.Area.GetHashCode();
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
