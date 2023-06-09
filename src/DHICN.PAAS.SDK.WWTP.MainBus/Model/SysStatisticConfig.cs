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
    /// SysStatisticConfig
    /// </summary>
    [DataContract]
    public partial class SysStatisticConfig :  IEquatable<SysStatisticConfig>, IValidatableObject
    {
        /// <summary>
        /// Defines StatisticType
        /// </summary>
        public enum StatisticTypeEnum
        {
            /// <summary>
            /// Enum NUMBER_0 for value: 0
            /// </summary>
            NUMBER_0 = 0,

            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            NUMBER_1 = 1,

            /// <summary>
            /// Enum NUMBER_2 for value: 2
            /// </summary>
            NUMBER_2 = 2

        }

        /// <summary>
        /// Gets or Sets StatisticType
        /// </summary>
        [DataMember(Name="statisticType", EmitDefaultValue=false)]
        public StatisticTypeEnum? StatisticType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SysStatisticConfig" /> class.
        /// </summary>
        /// <param name="tenantId">tenantId.</param>
        /// <param name="statisticCode">statisticCode.</param>
        /// <param name="statisticName">statisticName.</param>
        /// <param name="statisticType">statisticType.</param>
        /// <param name="statisticVarRef">statisticVarRef.</param>
        /// <param name="creationTime">creationTime.</param>
        /// <param name="isDisplay">isDisplay.</param>
        /// <param name="unit">unit.</param>
        /// <param name="groupName">groupName.</param>
        public SysStatisticConfig(Guid? tenantId = default(Guid?), string statisticCode = default(string), string statisticName = default(string), StatisticTypeEnum? statisticType = default(StatisticTypeEnum?), string statisticVarRef = default(string), DateTime creationTime = default(DateTime), bool isDisplay = default(bool), string unit = default(string), string groupName = default(string))
        {
            this.TenantId = tenantId;
            this.StatisticCode = statisticCode;
            this.StatisticName = statisticName;
            this.StatisticType = statisticType;
            this.StatisticVarRef = statisticVarRef;
            this.CreationTime = creationTime;
            this.IsDisplay = isDisplay;
            this.Unit = unit;
            this.GroupName = groupName;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid Id { get; private set; }

        /// <summary>
        /// Gets or Sets TenantId
        /// </summary>
        [DataMember(Name="tenantId", EmitDefaultValue=true)]
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Gets or Sets StatisticCode
        /// </summary>
        [DataMember(Name="statisticCode", EmitDefaultValue=true)]
        public string StatisticCode { get; set; }

        /// <summary>
        /// Gets or Sets StatisticName
        /// </summary>
        [DataMember(Name="statisticName", EmitDefaultValue=true)]
        public string StatisticName { get; set; }

        /// <summary>
        /// Gets or Sets StatisticVarRef
        /// </summary>
        [DataMember(Name="statisticVarRef", EmitDefaultValue=true)]
        public string StatisticVarRef { get; set; }

        /// <summary>
        /// Gets or Sets CreationTime
        /// </summary>
        [DataMember(Name="creationTime", EmitDefaultValue=false)]
        public DateTime CreationTime { get; set; }

        /// <summary>
        /// Gets or Sets IsDisplay
        /// </summary>
        [DataMember(Name="isDisplay", EmitDefaultValue=false)]
        public bool IsDisplay { get; set; }

        /// <summary>
        /// Gets or Sets Unit
        /// </summary>
        [DataMember(Name="unit", EmitDefaultValue=true)]
        public string Unit { get; set; }

        /// <summary>
        /// Gets or Sets GroupName
        /// </summary>
        [DataMember(Name="groupName", EmitDefaultValue=true)]
        public string GroupName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SysStatisticConfig {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  StatisticCode: ").Append(StatisticCode).Append("\n");
            sb.Append("  StatisticName: ").Append(StatisticName).Append("\n");
            sb.Append("  StatisticType: ").Append(StatisticType).Append("\n");
            sb.Append("  StatisticVarRef: ").Append(StatisticVarRef).Append("\n");
            sb.Append("  CreationTime: ").Append(CreationTime).Append("\n");
            sb.Append("  IsDisplay: ").Append(IsDisplay).Append("\n");
            sb.Append("  Unit: ").Append(Unit).Append("\n");
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
            return this.Equals(input as SysStatisticConfig);
        }

        /// <summary>
        /// Returns true if SysStatisticConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of SysStatisticConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SysStatisticConfig input)
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
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
                ) && 
                (
                    this.StatisticCode == input.StatisticCode ||
                    (this.StatisticCode != null &&
                    this.StatisticCode.Equals(input.StatisticCode))
                ) && 
                (
                    this.StatisticName == input.StatisticName ||
                    (this.StatisticName != null &&
                    this.StatisticName.Equals(input.StatisticName))
                ) && 
                (
                    this.StatisticType == input.StatisticType ||
                    this.StatisticType.Equals(input.StatisticType)
                ) && 
                (
                    this.StatisticVarRef == input.StatisticVarRef ||
                    (this.StatisticVarRef != null &&
                    this.StatisticVarRef.Equals(input.StatisticVarRef))
                ) && 
                (
                    this.CreationTime == input.CreationTime ||
                    (this.CreationTime != null &&
                    this.CreationTime.Equals(input.CreationTime))
                ) && 
                (
                    this.IsDisplay == input.IsDisplay ||
                    this.IsDisplay.Equals(input.IsDisplay)
                ) && 
                (
                    this.Unit == input.Unit ||
                    (this.Unit != null &&
                    this.Unit.Equals(input.Unit))
                ) && 
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.StatisticCode != null)
                    hashCode = hashCode * 59 + this.StatisticCode.GetHashCode();
                if (this.StatisticName != null)
                    hashCode = hashCode * 59 + this.StatisticName.GetHashCode();
                hashCode = hashCode * 59 + this.StatisticType.GetHashCode();
                if (this.StatisticVarRef != null)
                    hashCode = hashCode * 59 + this.StatisticVarRef.GetHashCode();
                if (this.CreationTime != null)
                    hashCode = hashCode * 59 + this.CreationTime.GetHashCode();
                hashCode = hashCode * 59 + this.IsDisplay.GetHashCode();
                if (this.Unit != null)
                    hashCode = hashCode * 59 + this.Unit.GetHashCode();
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
