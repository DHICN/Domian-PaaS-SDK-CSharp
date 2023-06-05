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
using OpenAPIDateConverter = DHI.DSS.ScenarioManagerServiceSDK.Client.OpenAPIDateConverter;

namespace DHI.DSS.ScenarioManagerServiceSDK.Model
{
    /// <summary>
    /// RenameScenarioGroupPara
    /// </summary>
    [DataContract]
    public partial class RenameScenarioGroupPara :  IEquatable<RenameScenarioGroupPara>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RenameScenarioGroupPara" /> class.
        /// </summary>
        /// <param name="oldScenarioGroupId">方案组ID the scenario group&#39;s Id.</param>
        /// <param name="newGroupName">新的方案组名称 new scenario group name.</param>
        public RenameScenarioGroupPara(string oldScenarioGroupId = default(string), string newGroupName = default(string))
        {
            this.OldScenarioGroupId = oldScenarioGroupId;
            this.NewGroupName = newGroupName;
        }
        
        /// <summary>
        /// 方案组ID the scenario group&#39;s Id
        /// </summary>
        /// <value>方案组ID the scenario group&#39;s Id</value>
        [DataMember(Name="oldScenarioGroupId", EmitDefaultValue=true)]
        public string OldScenarioGroupId { get; set; }

        /// <summary>
        /// 新的方案组名称 new scenario group name
        /// </summary>
        /// <value>新的方案组名称 new scenario group name</value>
        [DataMember(Name="newGroupName", EmitDefaultValue=true)]
        public string NewGroupName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RenameScenarioGroupPara {\n");
            sb.Append("  OldScenarioGroupId: ").Append(OldScenarioGroupId).Append("\n");
            sb.Append("  NewGroupName: ").Append(NewGroupName).Append("\n");
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
            return this.Equals(input as RenameScenarioGroupPara);
        }

        /// <summary>
        /// Returns true if RenameScenarioGroupPara instances are equal
        /// </summary>
        /// <param name="input">Instance of RenameScenarioGroupPara to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RenameScenarioGroupPara input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OldScenarioGroupId == input.OldScenarioGroupId ||
                    (this.OldScenarioGroupId != null &&
                    this.OldScenarioGroupId.Equals(input.OldScenarioGroupId))
                ) && 
                (
                    this.NewGroupName == input.NewGroupName ||
                    (this.NewGroupName != null &&
                    this.NewGroupName.Equals(input.NewGroupName))
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
                if (this.OldScenarioGroupId != null)
                    hashCode = hashCode * 59 + this.OldScenarioGroupId.GetHashCode();
                if (this.NewGroupName != null)
                    hashCode = hashCode * 59 + this.NewGroupName.GetHashCode();
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
