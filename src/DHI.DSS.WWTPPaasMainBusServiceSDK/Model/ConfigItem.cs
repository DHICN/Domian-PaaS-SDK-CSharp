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
    /// ConfigItem
    /// </summary>
    [DataContract]
    public partial class ConfigItem :  IEquatable<ConfigItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigItem" /> class.
        /// </summary>
        /// <param name="configCode">配置项代码 config code.</param>
        /// <param name="configName">配置项名称 config name.</param>
        /// <param name="configDesc">配置项描述 config description.</param>
        /// <param name="selected">是否被选中 if selected.</param>
        public ConfigItem(int configCode = default(int), string configName = default(string), string configDesc = default(string), bool selected = default(bool))
        {
            this.ConfigCode = configCode;
            this.ConfigName = configName;
            this.ConfigDesc = configDesc;
            this.Selected = selected;
        }
        
        /// <summary>
        /// 配置项代码 config code
        /// </summary>
        /// <value>配置项代码 config code</value>
        [DataMember(Name="configCode", EmitDefaultValue=false)]
        public int ConfigCode { get; set; }

        /// <summary>
        /// 配置项名称 config name
        /// </summary>
        /// <value>配置项名称 config name</value>
        [DataMember(Name="configName", EmitDefaultValue=true)]
        public string ConfigName { get; set; }

        /// <summary>
        /// 配置项描述 config description
        /// </summary>
        /// <value>配置项描述 config description</value>
        [DataMember(Name="configDesc", EmitDefaultValue=true)]
        public string ConfigDesc { get; set; }

        /// <summary>
        /// 是否被选中 if selected
        /// </summary>
        /// <value>是否被选中 if selected</value>
        [DataMember(Name="selected", EmitDefaultValue=false)]
        public bool Selected { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConfigItem {\n");
            sb.Append("  ConfigCode: ").Append(ConfigCode).Append("\n");
            sb.Append("  ConfigName: ").Append(ConfigName).Append("\n");
            sb.Append("  ConfigDesc: ").Append(ConfigDesc).Append("\n");
            sb.Append("  Selected: ").Append(Selected).Append("\n");
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
            return this.Equals(input as ConfigItem);
        }

        /// <summary>
        /// Returns true if ConfigItem instances are equal
        /// </summary>
        /// <param name="input">Instance of ConfigItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConfigItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ConfigCode == input.ConfigCode ||
                    this.ConfigCode.Equals(input.ConfigCode)
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
                    this.Selected == input.Selected ||
                    this.Selected.Equals(input.Selected)
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
                hashCode = hashCode * 59 + this.ConfigCode.GetHashCode();
                if (this.ConfigName != null)
                    hashCode = hashCode * 59 + this.ConfigName.GetHashCode();
                if (this.ConfigDesc != null)
                    hashCode = hashCode * 59 + this.ConfigDesc.GetHashCode();
                hashCode = hashCode * 59 + this.Selected.GetHashCode();
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