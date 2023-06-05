/* 
 * wwtp-paas-main-bus-service
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
using OpenAPIDateConverter = DHI.DSS.WWTPPaasMainBusServiceSDK.Client.OpenAPIDateConverter;

namespace DHI.DSS.WWTPPaasMainBusServiceSDK.Model
{
    /// <summary>
    /// WqOnlinePointOutput
    /// </summary>
    [DataContract]
    public partial class WqOnlinePointOutput :  IEquatable<WqOnlinePointOutput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WqOnlinePointOutput" /> class.
        /// </summary>
        /// <param name="location">位置 location.</param>
        /// <param name="points">进水点/工艺线，及其下的指标信息 inlet/product and corresponding indicators.</param>
        public WqOnlinePointOutput(string location = default(string), List<WqOnlinePoint> points = default(List<WqOnlinePoint>))
        {
            this.Location = location;
            this.Points = points;
        }
        
        /// <summary>
        /// 位置 location
        /// </summary>
        /// <value>位置 location</value>
        [DataMember(Name="location", EmitDefaultValue=true)]
        public string Location { get; set; }

        /// <summary>
        /// 进水点/工艺线，及其下的指标信息 inlet/product and corresponding indicators
        /// </summary>
        /// <value>进水点/工艺线，及其下的指标信息 inlet/product and corresponding indicators</value>
        [DataMember(Name="points", EmitDefaultValue=true)]
        public List<WqOnlinePoint> Points { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WqOnlinePointOutput {\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  Points: ").Append(Points).Append("\n");
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
            return this.Equals(input as WqOnlinePointOutput);
        }

        /// <summary>
        /// Returns true if WqOnlinePointOutput instances are equal
        /// </summary>
        /// <param name="input">Instance of WqOnlinePointOutput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WqOnlinePointOutput input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && 
                (
                    this.Points == input.Points ||
                    this.Points != null &&
                    input.Points != null &&
                    this.Points.SequenceEqual(input.Points)
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
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.Points != null)
                    hashCode = hashCode * 59 + this.Points.GetHashCode();
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
