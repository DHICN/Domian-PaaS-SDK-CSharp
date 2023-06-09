/* 
 * scenario-manager-service
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
using OpenAPIDateConverter = DHICN.PAAS.SDK.ScenarioManager.Client.OpenAPIDateConverter;

namespace DHICN.PAAS.SDK.ScenarioManager.Model
{
    /// <summary>
    /// CreateRootScenarioGroupPara
    /// </summary>
    [DataContract]
    public partial class CreateRootScenarioGroupPara :  IEquatable<CreateRootScenarioGroupPara>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRootScenarioGroupPara" /> class.
        /// </summary>
        /// <param name="groupName">根方案组名称 root scenario group name.</param>
        public CreateRootScenarioGroupPara(string groupName = default(string))
        {
            this.GroupName = groupName;
        }
        
        /// <summary>
        /// 根方案组名称 root scenario group name
        /// </summary>
        /// <value>根方案组名称 root scenario group name</value>
        [DataMember(Name="groupName", EmitDefaultValue=true)]
        public string GroupName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateRootScenarioGroupPara {\n");
            sb.Append("  GroupName: ").Append(GroupName).Append("\n");
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
            return this.Equals(input as CreateRootScenarioGroupPara);
        }

        /// <summary>
        /// Returns true if CreateRootScenarioGroupPara instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateRootScenarioGroupPara to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateRootScenarioGroupPara input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GroupName == input.GroupName ||
                    (this.GroupName != null &&
                    this.GroupName.Equals(input.GroupName))
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
                if (this.GroupName != null)
                    hashCode = hashCode * 59 + this.GroupName.GetHashCode();
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
