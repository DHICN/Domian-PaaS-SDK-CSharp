/* 
 * identity-service
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
using OpenAPIDateConverter = DHICN.PAAS.SDK.Identity.Client.OpenAPIDateConverter;

namespace DHICN.PAAS.SDK.Identity.Model
{
    /// <summary>
    /// WqSimulationIndicatorOutput
    /// </summary>
    [DataContract]
    public partial class WqSimulationIndicatorOutput :  IEquatable<WqSimulationIndicatorOutput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WqSimulationIndicatorOutput" /> class.
        /// </summary>
        /// <param name="id">指标ID indicator id.</param>
        /// <param name="configName">指标代码 indicator code.</param>
        /// <param name="configDesc">指标描述 indicator description.</param>
        /// <param name="isDisplay">是否展示 if display at the front end.</param>
        /// <param name="index">展示序号 display index.</param>
        public WqSimulationIndicatorOutput(Guid id = default(Guid), string configName = default(string), string configDesc = default(string), bool isDisplay = default(bool), int index = default(int))
        {
            this.Id = id;
            this.ConfigName = configName;
            this.ConfigDesc = configDesc;
            this.IsDisplay = isDisplay;
            this.Index = index;
        }
        
        /// <summary>
        /// 指标ID indicator id
        /// </summary>
        /// <value>指标ID indicator id</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid Id { get; set; }

        /// <summary>
        /// 指标代码 indicator code
        /// </summary>
        /// <value>指标代码 indicator code</value>
        [DataMember(Name="configName", EmitDefaultValue=true)]
        public string ConfigName { get; set; }

        /// <summary>
        /// 指标描述 indicator description
        /// </summary>
        /// <value>指标描述 indicator description</value>
        [DataMember(Name="configDesc", EmitDefaultValue=true)]
        public string ConfigDesc { get; set; }

        /// <summary>
        /// 是否展示 if display at the front end
        /// </summary>
        /// <value>是否展示 if display at the front end</value>
        [DataMember(Name="isDisplay", EmitDefaultValue=false)]
        public bool IsDisplay { get; set; }

        /// <summary>
        /// 展示序号 display index
        /// </summary>
        /// <value>展示序号 display index</value>
        [DataMember(Name="index", EmitDefaultValue=false)]
        public int Index { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WqSimulationIndicatorOutput {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ConfigName: ").Append(ConfigName).Append("\n");
            sb.Append("  ConfigDesc: ").Append(ConfigDesc).Append("\n");
            sb.Append("  IsDisplay: ").Append(IsDisplay).Append("\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
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
            return this.Equals(input as WqSimulationIndicatorOutput);
        }

        /// <summary>
        /// Returns true if WqSimulationIndicatorOutput instances are equal
        /// </summary>
        /// <param name="input">Instance of WqSimulationIndicatorOutput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WqSimulationIndicatorOutput input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.ConfigName == input.ConfigName ||
                    (this.ConfigName != null &&
                    this.ConfigName.Equals(input.ConfigName))
                ) && 
                (
                    this.ConfigDesc == input.ConfigDesc ||
                    (this.ConfigDesc != null &&
                    this.ConfigDesc.Equals(input.ConfigDesc))
                ) && 
                (
                    this.IsDisplay == input.IsDisplay ||
                    this.IsDisplay.Equals(input.IsDisplay)
                ) && 
                (
                    this.Index == input.Index ||
                    this.Index.Equals(input.Index)
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ConfigName != null)
                    hashCode = hashCode * 59 + this.ConfigName.GetHashCode();
                if (this.ConfigDesc != null)
                    hashCode = hashCode * 59 + this.ConfigDesc.GetHashCode();
                hashCode = hashCode * 59 + this.IsDisplay.GetHashCode();
                hashCode = hashCode * 59 + this.Index.GetHashCode();
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
