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
using OpenAPIDateConverter = wwtp_paas_main_bus_service.Client.OpenAPIDateConverter;

namespace wwtp_paas_main_bus_service.Model
{
    /// <summary>
    /// GroupData
    /// </summary>
    [DataContract]
    public partial class GroupData :  IEquatable<GroupData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupData" /> class.
        /// </summary>
        /// <param name="boardName">看板项名称 statistic item name.</param>
        /// <param name="boardValue">看板项数值 statistic item value.</param>
        /// <param name="unit">看板项单位 statistic item unit.</param>
        public GroupData(string boardName = default(string), double? boardValue = default(double?), string unit = default(string))
        {
            this.BoardName = boardName;
            this.BoardValue = boardValue;
            this.Unit = unit;
        }
        
        /// <summary>
        /// 看板项名称 statistic item name
        /// </summary>
        /// <value>看板项名称 statistic item name</value>
        [DataMember(Name="boardName", EmitDefaultValue=true)]
        public string BoardName { get; set; }

        /// <summary>
        /// 看板项数值 statistic item value
        /// </summary>
        /// <value>看板项数值 statistic item value</value>
        [DataMember(Name="boardValue", EmitDefaultValue=true)]
        public double? BoardValue { get; set; }

        /// <summary>
        /// 看板项单位 statistic item unit
        /// </summary>
        /// <value>看板项单位 statistic item unit</value>
        [DataMember(Name="unit", EmitDefaultValue=true)]
        public string Unit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GroupData {\n");
            sb.Append("  BoardName: ").Append(BoardName).Append("\n");
            sb.Append("  BoardValue: ").Append(BoardValue).Append("\n");
            sb.Append("  Unit: ").Append(Unit).Append("\n");
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
            return this.Equals(input as GroupData);
        }

        /// <summary>
        /// Returns true if GroupData instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BoardName == input.BoardName ||
                    (this.BoardName != null &&
                    this.BoardName.Equals(input.BoardName))
                ) && 
                (
                    this.BoardValue == input.BoardValue ||
                    (this.BoardValue != null &&
                    this.BoardValue.Equals(input.BoardValue))
                ) && 
                (
                    this.Unit == input.Unit ||
                    (this.Unit != null &&
                    this.Unit.Equals(input.Unit))
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
                if (this.BoardName != null)
                    hashCode = hashCode * 59 + this.BoardName.GetHashCode();
                if (this.BoardValue != null)
                    hashCode = hashCode * 59 + this.BoardValue.GetHashCode();
                if (this.Unit != null)
                    hashCode = hashCode * 59 + this.Unit.GetHashCode();
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
