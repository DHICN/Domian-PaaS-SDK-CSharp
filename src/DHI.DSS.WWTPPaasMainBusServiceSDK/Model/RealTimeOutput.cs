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
    /// RealTimeOutput
    /// </summary>
    [DataContract]
    public partial class RealTimeOutput :  IEquatable<RealTimeOutput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RealTimeOutput" /> class.
        /// </summary>
        /// <param name="location">毒性仪位置 toxicity meter location.</param>
        /// <param name="inlet">所处的进水点 inlet.</param>
        /// <param name="inletName">inletName.</param>
        /// <param name="datas">具体数据 detailed data.</param>
        public RealTimeOutput(string location = default(string), string inlet = default(string), string inletName = default(string), List<RealTimeData> datas = default(List<RealTimeData>))
        {
            this.Location = location;
            this.Inlet = inlet;
            this.InletName = inletName;
            this.Datas = datas;
        }
        
        /// <summary>
        /// 毒性仪位置 toxicity meter location
        /// </summary>
        /// <value>毒性仪位置 toxicity meter location</value>
        [DataMember(Name="location", EmitDefaultValue=true)]
        public string Location { get; set; }

        /// <summary>
        /// 所处的进水点 inlet
        /// </summary>
        /// <value>所处的进水点 inlet</value>
        [DataMember(Name="inlet", EmitDefaultValue=true)]
        public string Inlet { get; set; }

        /// <summary>
        /// Gets or Sets InletName
        /// </summary>
        [DataMember(Name="inletName", EmitDefaultValue=true)]
        public string InletName { get; set; }

        /// <summary>
        /// 具体数据 detailed data
        /// </summary>
        /// <value>具体数据 detailed data</value>
        [DataMember(Name="datas", EmitDefaultValue=true)]
        public List<RealTimeData> Datas { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RealTimeOutput {\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  Inlet: ").Append(Inlet).Append("\n");
            sb.Append("  InletName: ").Append(InletName).Append("\n");
            sb.Append("  Datas: ").Append(Datas).Append("\n");
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
            return this.Equals(input as RealTimeOutput);
        }

        /// <summary>
        /// Returns true if RealTimeOutput instances are equal
        /// </summary>
        /// <param name="input">Instance of RealTimeOutput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RealTimeOutput input)
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
                    this.Inlet == input.Inlet ||
                    (this.Inlet != null &&
                    this.Inlet.Equals(input.Inlet))
                ) && 
                (
                    this.InletName == input.InletName ||
                    (this.InletName != null &&
                    this.InletName.Equals(input.InletName))
                ) && 
                (
                    this.Datas == input.Datas ||
                    this.Datas != null &&
                    input.Datas != null &&
                    this.Datas.SequenceEqual(input.Datas)
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
                if (this.Inlet != null)
                    hashCode = hashCode * 59 + this.Inlet.GetHashCode();
                if (this.InletName != null)
                    hashCode = hashCode * 59 + this.InletName.GetHashCode();
                if (this.Datas != null)
                    hashCode = hashCode * 59 + this.Datas.GetHashCode();
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
