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
    /// RoleDto
    /// </summary>
    [DataContract]
    public partial class RoleDto :  IEquatable<RoleDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoleDto" /> class.
        /// </summary>
        /// <param name="id">角色ID role id.</param>
        /// <param name="name">角色名称 role name.</param>
        /// <param name="remarks">角色备注 role remark.</param>
        /// <param name="isDefault">是否为默认角色 if it is the default role.</param>
        /// <param name="extraProperties">额外的属性 extra properties.</param>
        /// <param name="creationTime">创建时间 create time.</param>
        /// <param name="creatorId">创建者ID creator id.</param>
        /// <param name="tenantId">租户ID tenant id.</param>
        public RoleDto(Guid id = default(Guid), string name = default(string), string remarks = default(string), bool isDefault = default(bool), string extraProperties = default(string), DateTime creationTime = default(DateTime), Guid? creatorId = default(Guid?), Guid? tenantId = default(Guid?))
        {
            this.Id = id;
            this.Name = name;
            this.Remarks = remarks;
            this.IsDefault = isDefault;
            this.ExtraProperties = extraProperties;
            this.CreationTime = creationTime;
            this.CreatorId = creatorId;
            this.TenantId = tenantId;
        }
        
        /// <summary>
        /// 角色ID role id
        /// </summary>
        /// <value>角色ID role id</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid Id { get; set; }

        /// <summary>
        /// 角色名称 role name
        /// </summary>
        /// <value>角色名称 role name</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// 角色备注 role remark
        /// </summary>
        /// <value>角色备注 role remark</value>
        [DataMember(Name="remarks", EmitDefaultValue=true)]
        public string Remarks { get; set; }

        /// <summary>
        /// 是否为默认角色 if it is the default role
        /// </summary>
        /// <value>是否为默认角色 if it is the default role</value>
        [DataMember(Name="isDefault", EmitDefaultValue=false)]
        public bool IsDefault { get; set; }

        /// <summary>
        /// 额外的属性 extra properties
        /// </summary>
        /// <value>额外的属性 extra properties</value>
        [DataMember(Name="extraProperties", EmitDefaultValue=true)]
        public string ExtraProperties { get; set; }

        /// <summary>
        /// 创建时间 create time
        /// </summary>
        /// <value>创建时间 create time</value>
        [DataMember(Name="creationTime", EmitDefaultValue=false)]
        public DateTime CreationTime { get; set; }

        /// <summary>
        /// 创建者ID creator id
        /// </summary>
        /// <value>创建者ID creator id</value>
        [DataMember(Name="creatorId", EmitDefaultValue=true)]
        public Guid? CreatorId { get; set; }

        /// <summary>
        /// 租户ID tenant id
        /// </summary>
        /// <value>租户ID tenant id</value>
        [DataMember(Name="tenantId", EmitDefaultValue=true)]
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RoleDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Remarks: ").Append(Remarks).Append("\n");
            sb.Append("  IsDefault: ").Append(IsDefault).Append("\n");
            sb.Append("  ExtraProperties: ").Append(ExtraProperties).Append("\n");
            sb.Append("  CreationTime: ").Append(CreationTime).Append("\n");
            sb.Append("  CreatorId: ").Append(CreatorId).Append("\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
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
            return this.Equals(input as RoleDto);
        }

        /// <summary>
        /// Returns true if RoleDto instances are equal
        /// </summary>
        /// <param name="input">Instance of RoleDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RoleDto input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Remarks == input.Remarks ||
                    (this.Remarks != null &&
                    this.Remarks.Equals(input.Remarks))
                ) && 
                (
                    this.IsDefault == input.IsDefault ||
                    this.IsDefault.Equals(input.IsDefault)
                ) && 
                (
                    this.ExtraProperties == input.ExtraProperties ||
                    (this.ExtraProperties != null &&
                    this.ExtraProperties.Equals(input.ExtraProperties))
                ) && 
                (
                    this.CreationTime == input.CreationTime ||
                    (this.CreationTime != null &&
                    this.CreationTime.Equals(input.CreationTime))
                ) && 
                (
                    this.CreatorId == input.CreatorId ||
                    (this.CreatorId != null &&
                    this.CreatorId.Equals(input.CreatorId))
                ) && 
                (
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Remarks != null)
                    hashCode = hashCode * 59 + this.Remarks.GetHashCode();
                hashCode = hashCode * 59 + this.IsDefault.GetHashCode();
                if (this.ExtraProperties != null)
                    hashCode = hashCode * 59 + this.ExtraProperties.GetHashCode();
                if (this.CreationTime != null)
                    hashCode = hashCode * 59 + this.CreationTime.GetHashCode();
                if (this.CreatorId != null)
                    hashCode = hashCode * 59 + this.CreatorId.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
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
