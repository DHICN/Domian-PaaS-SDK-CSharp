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
    /// SelectItemNodeDetailInfo
    /// </summary>
    [DataContract]
    public partial class SelectItemNodeDetailInfo :  IEquatable<SelectItemNodeDetailInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SelectItemNodeDetailInfo" /> class.
        /// </summary>
        /// <param name="code">code.</param>
        /// <param name="unit">unit.</param>
        /// <param name="onlineCode">onlineCode.</param>
        /// <param name="modelCode">modelCode.</param>
        /// <param name="modelDataType">modelDataType.</param>
        public SelectItemNodeDetailInfo(string code = default(string), string unit = default(string), string onlineCode = default(string), string modelCode = default(string), string modelDataType = default(string))
        {
            this.Code = code;
            this.Unit = unit;
            this.OnlineCode = onlineCode;
            this.ModelCode = modelCode;
            this.ModelDataType = modelDataType;
        }
        
        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name="code", EmitDefaultValue=true)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets Unit
        /// </summary>
        [DataMember(Name="unit", EmitDefaultValue=true)]
        public string Unit { get; set; }

        /// <summary>
        /// Gets or Sets OnlineCode
        /// </summary>
        [DataMember(Name="onlineCode", EmitDefaultValue=true)]
        public string OnlineCode { get; set; }

        /// <summary>
        /// Gets or Sets ModelCode
        /// </summary>
        [DataMember(Name="modelCode", EmitDefaultValue=true)]
        public string ModelCode { get; set; }

        /// <summary>
        /// Gets or Sets ModelDataType
        /// </summary>
        [DataMember(Name="modelDataType", EmitDefaultValue=true)]
        public string ModelDataType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SelectItemNodeDetailInfo {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Unit: ").Append(Unit).Append("\n");
            sb.Append("  OnlineCode: ").Append(OnlineCode).Append("\n");
            sb.Append("  ModelCode: ").Append(ModelCode).Append("\n");
            sb.Append("  ModelDataType: ").Append(ModelDataType).Append("\n");
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
            return this.Equals(input as SelectItemNodeDetailInfo);
        }

        /// <summary>
        /// Returns true if SelectItemNodeDetailInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of SelectItemNodeDetailInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SelectItemNodeDetailInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Unit == input.Unit ||
                    (this.Unit != null &&
                    this.Unit.Equals(input.Unit))
                ) && 
                (
                    this.OnlineCode == input.OnlineCode ||
                    (this.OnlineCode != null &&
                    this.OnlineCode.Equals(input.OnlineCode))
                ) && 
                (
                    this.ModelCode == input.ModelCode ||
                    (this.ModelCode != null &&
                    this.ModelCode.Equals(input.ModelCode))
                ) && 
                (
                    this.ModelDataType == input.ModelDataType ||
                    (this.ModelDataType != null &&
                    this.ModelDataType.Equals(input.ModelDataType))
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
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Unit != null)
                    hashCode = hashCode * 59 + this.Unit.GetHashCode();
                if (this.OnlineCode != null)
                    hashCode = hashCode * 59 + this.OnlineCode.GetHashCode();
                if (this.ModelCode != null)
                    hashCode = hashCode * 59 + this.ModelCode.GetHashCode();
                if (this.ModelDataType != null)
                    hashCode = hashCode * 59 + this.ModelDataType.GetHashCode();
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
