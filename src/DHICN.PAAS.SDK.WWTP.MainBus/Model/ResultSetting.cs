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
using OpenAPIDateConverter = DHICN.PAAS.SDK.WWTP.MainBus.Client.OpenAPIDateConverter;

namespace DHICN.PAAS.SDK.WWTP.MainBus.Model
{
    /// <summary>
    /// ResultSetting
    /// </summary>
    [DataContract]
    public partial class ResultSetting :  IEquatable<ResultSetting>, IValidatableObject
    {
        /// <summary>
        /// 配置项类型 config type
        /// </summary>
        /// <value>配置项类型 config type</value>
        public enum ConfigTypeEnum
        {
            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            NUMBER_1 = 1,

            /// <summary>
            /// Enum NUMBER_2 for value: 2
            /// </summary>
            NUMBER_2 = 2,

            /// <summary>
            /// Enum NUMBER_3 for value: 3
            /// </summary>
            NUMBER_3 = 3

        }

        /// <summary>
        /// 配置项类型 config type
        /// </summary>
        /// <value>配置项类型 config type</value>
        [DataMember(Name="configType", EmitDefaultValue=false)]
        public ConfigTypeEnum? ConfigType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ResultSetting" /> class.
        /// </summary>
        /// <param name="configType">配置项类型 config type.</param>
        /// <param name="configItems">配置项列表 config items.</param>
        public ResultSetting(ConfigTypeEnum? configType = default(ConfigTypeEnum?), List<ConfigItem> configItems = default(List<ConfigItem>))
        {
            this.ConfigType = configType;
            this.ConfigItems = configItems;
        }
        
        /// <summary>
        /// 配置项列表 config items
        /// </summary>
        /// <value>配置项列表 config items</value>
        [DataMember(Name="configItems", EmitDefaultValue=true)]
        public List<ConfigItem> ConfigItems { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResultSetting {\n");
            sb.Append("  ConfigType: ").Append(ConfigType).Append("\n");
            sb.Append("  ConfigItems: ").Append(ConfigItems).Append("\n");
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
            return this.Equals(input as ResultSetting);
        }

        /// <summary>
        /// Returns true if ResultSetting instances are equal
        /// </summary>
        /// <param name="input">Instance of ResultSetting to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResultSetting input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ConfigType == input.ConfigType ||
                    this.ConfigType.Equals(input.ConfigType)
                ) && 
                (
                    this.ConfigItems == input.ConfigItems ||
                    this.ConfigItems != null &&
                    input.ConfigItems != null &&
                    this.ConfigItems.SequenceEqual(input.ConfigItems)
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
                hashCode = hashCode * 59 + this.ConfigType.GetHashCode();
                if (this.ConfigItems != null)
                    hashCode = hashCode * 59 + this.ConfigItems.GetHashCode();
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
