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
    /// AddRolePermissionsInput
    /// </summary>
    [DataContract]
    public partial class AddRolePermissionsInput :  IEquatable<AddRolePermissionsInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddRolePermissionsInput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AddRolePermissionsInput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddRolePermissionsInput" /> class.
        /// </summary>
        /// <param name="tenantId">租户Id tenant id.</param>
        /// <param name="roles">角色:admin,oper roles.</param>
        /// <param name="regular">角色下的权限规则 role permission regular (required).</param>
        /// <param name="isCarryAuth">是否携带Auth if carry authentication (required).</param>
        /// <param name="serviceKey">微服务标识 micro service key.</param>
        /// <param name="priority">优先级 priority.</param>
        public AddRolePermissionsInput(Guid? tenantId = default(Guid?), List<string> roles = default(List<string>), string regular = default(string), bool isCarryAuth = default(bool), string serviceKey = default(string), int priority = default(int))
        {
            // to ensure "regular" is required (not null)
            this.Regular = regular ?? throw new ArgumentNullException("regular is a required property for AddRolePermissionsInput and cannot be null");
            this.IsCarryAuth = isCarryAuth;
            this.TenantId = tenantId;
            this.Roles = roles;
            this.ServiceKey = serviceKey;
            this.Priority = priority;
        }
        
        /// <summary>
        /// 租户Id tenant id
        /// </summary>
        /// <value>租户Id tenant id</value>
        [DataMember(Name="tenantId", EmitDefaultValue=true)]
        public Guid? TenantId { get; set; }

        /// <summary>
        /// 角色:admin,oper roles
        /// </summary>
        /// <value>角色:admin,oper roles</value>
        [DataMember(Name="roles", EmitDefaultValue=true)]
        public List<string> Roles { get; set; }

        /// <summary>
        /// 角色下的权限规则 role permission regular
        /// </summary>
        /// <value>角色下的权限规则 role permission regular</value>
        [DataMember(Name="regular", EmitDefaultValue=false)]
        public string Regular { get; set; }

        /// <summary>
        /// 是否携带Auth if carry authentication
        /// </summary>
        /// <value>是否携带Auth if carry authentication</value>
        [DataMember(Name="isCarryAuth", EmitDefaultValue=false)]
        public bool IsCarryAuth { get; set; }

        /// <summary>
        /// 微服务标识 micro service key
        /// </summary>
        /// <value>微服务标识 micro service key</value>
        [DataMember(Name="serviceKey", EmitDefaultValue=true)]
        public string ServiceKey { get; set; }

        /// <summary>
        /// 优先级 priority
        /// </summary>
        /// <value>优先级 priority</value>
        [DataMember(Name="priority", EmitDefaultValue=false)]
        public int Priority { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddRolePermissionsInput {\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  Roles: ").Append(Roles).Append("\n");
            sb.Append("  Regular: ").Append(Regular).Append("\n");
            sb.Append("  IsCarryAuth: ").Append(IsCarryAuth).Append("\n");
            sb.Append("  ServiceKey: ").Append(ServiceKey).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
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
            return this.Equals(input as AddRolePermissionsInput);
        }

        /// <summary>
        /// Returns true if AddRolePermissionsInput instances are equal
        /// </summary>
        /// <param name="input">Instance of AddRolePermissionsInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddRolePermissionsInput input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
                ) && 
                (
                    this.Roles == input.Roles ||
                    this.Roles != null &&
                    input.Roles != null &&
                    this.Roles.SequenceEqual(input.Roles)
                ) && 
                (
                    this.Regular == input.Regular ||
                    (this.Regular != null &&
                    this.Regular.Equals(input.Regular))
                ) && 
                (
                    this.IsCarryAuth == input.IsCarryAuth ||
                    this.IsCarryAuth.Equals(input.IsCarryAuth)
                ) && 
                (
                    this.ServiceKey == input.ServiceKey ||
                    (this.ServiceKey != null &&
                    this.ServiceKey.Equals(input.ServiceKey))
                ) && 
                (
                    this.Priority == input.Priority ||
                    this.Priority.Equals(input.Priority)
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
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.Roles != null)
                    hashCode = hashCode * 59 + this.Roles.GetHashCode();
                if (this.Regular != null)
                    hashCode = hashCode * 59 + this.Regular.GetHashCode();
                hashCode = hashCode * 59 + this.IsCarryAuth.GetHashCode();
                if (this.ServiceKey != null)
                    hashCode = hashCode * 59 + this.ServiceKey.GetHashCode();
                hashCode = hashCode * 59 + this.Priority.GetHashCode();
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
