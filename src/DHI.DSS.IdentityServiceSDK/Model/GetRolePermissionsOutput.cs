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
using OpenAPIDateConverter = DHI.DSS.IdentityServiceSDK.Client.OpenAPIDateConverter;

namespace DHI.DSS.IdentityServiceSDK.Model
{
    /// <summary>
    /// GetRolePermissionsOutput
    /// </summary>
    [DataContract]
    public partial class GetRolePermissionsOutput :  IEquatable<GetRolePermissionsOutput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetRolePermissionsOutput" /> class.
        /// </summary>
        /// <param name="id">角色ID role id.</param>
        /// <param name="tenantId">租户Id tenant id.</param>
        /// <param name="tenantName">租户名称 tenant name.</param>
        /// <param name="roles">角色,[\&quot;admin\&quot;,\&quot;oper\&quot;] roles.</param>
        /// <param name="regular">角色下的权限规则 role permission regular.</param>
        /// <param name="isCarryAuth">是否携带Auth if carry authentication.</param>
        /// <param name="priority">优先级 priority.</param>
        /// <param name="serviceKey">微服务标识 micro service key.</param>
        /// <param name="creationTime">创建时间 create time.</param>
        public GetRolePermissionsOutput(Guid id = default(Guid), Guid? tenantId = default(Guid?), string tenantName = default(string), List<string> roles = default(List<string>), string regular = default(string), bool isCarryAuth = default(bool), int priority = default(int), string serviceKey = default(string), DateTime creationTime = default(DateTime))
        {
            this.Id = id;
            this.TenantId = tenantId;
            this.TenantName = tenantName;
            this.Roles = roles;
            this.Regular = regular;
            this.IsCarryAuth = isCarryAuth;
            this.Priority = priority;
            this.ServiceKey = serviceKey;
            this.CreationTime = creationTime;
        }
        
        /// <summary>
        /// 角色ID role id
        /// </summary>
        /// <value>角色ID role id</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid Id { get; set; }

        /// <summary>
        /// 租户Id tenant id
        /// </summary>
        /// <value>租户Id tenant id</value>
        [DataMember(Name="tenantId", EmitDefaultValue=true)]
        public Guid? TenantId { get; set; }

        /// <summary>
        /// 租户名称 tenant name
        /// </summary>
        /// <value>租户名称 tenant name</value>
        [DataMember(Name="tenantName", EmitDefaultValue=true)]
        public string TenantName { get; set; }

        /// <summary>
        /// 角色,[\&quot;admin\&quot;,\&quot;oper\&quot;] roles
        /// </summary>
        /// <value>角色,[\&quot;admin\&quot;,\&quot;oper\&quot;] roles</value>
        [DataMember(Name="roles", EmitDefaultValue=true)]
        public List<string> Roles { get; set; }

        /// <summary>
        /// 角色下的权限规则 role permission regular
        /// </summary>
        /// <value>角色下的权限规则 role permission regular</value>
        [DataMember(Name="regular", EmitDefaultValue=true)]
        public string Regular { get; set; }

        /// <summary>
        /// 是否携带Auth if carry authentication
        /// </summary>
        /// <value>是否携带Auth if carry authentication</value>
        [DataMember(Name="isCarryAuth", EmitDefaultValue=false)]
        public bool IsCarryAuth { get; set; }

        /// <summary>
        /// 优先级 priority
        /// </summary>
        /// <value>优先级 priority</value>
        [DataMember(Name="priority", EmitDefaultValue=false)]
        public int Priority { get; set; }

        /// <summary>
        /// 微服务标识 micro service key
        /// </summary>
        /// <value>微服务标识 micro service key</value>
        [DataMember(Name="serviceKey", EmitDefaultValue=true)]
        public string ServiceKey { get; set; }

        /// <summary>
        /// 创建时间 create time
        /// </summary>
        /// <value>创建时间 create time</value>
        [DataMember(Name="creationTime", EmitDefaultValue=false)]
        public DateTime CreationTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetRolePermissionsOutput {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  TenantName: ").Append(TenantName).Append("\n");
            sb.Append("  Roles: ").Append(Roles).Append("\n");
            sb.Append("  Regular: ").Append(Regular).Append("\n");
            sb.Append("  IsCarryAuth: ").Append(IsCarryAuth).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  ServiceKey: ").Append(ServiceKey).Append("\n");
            sb.Append("  CreationTime: ").Append(CreationTime).Append("\n");
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
            return this.Equals(input as GetRolePermissionsOutput);
        }

        /// <summary>
        /// Returns true if GetRolePermissionsOutput instances are equal
        /// </summary>
        /// <param name="input">Instance of GetRolePermissionsOutput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetRolePermissionsOutput input)
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
                    this.TenantName == input.TenantName ||
                    (this.TenantName != null &&
                    this.TenantName.Equals(input.TenantName))
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
                    this.Priority == input.Priority ||
                    this.Priority.Equals(input.Priority)
                ) && 
                (
                    this.ServiceKey == input.ServiceKey ||
                    (this.ServiceKey != null &&
                    this.ServiceKey.Equals(input.ServiceKey))
                ) && 
                (
                    this.CreationTime == input.CreationTime ||
                    (this.CreationTime != null &&
                    this.CreationTime.Equals(input.CreationTime))
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
                if (this.TenantName != null)
                    hashCode = hashCode * 59 + this.TenantName.GetHashCode();
                if (this.Roles != null)
                    hashCode = hashCode * 59 + this.Roles.GetHashCode();
                if (this.Regular != null)
                    hashCode = hashCode * 59 + this.Regular.GetHashCode();
                hashCode = hashCode * 59 + this.IsCarryAuth.GetHashCode();
                hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.ServiceKey != null)
                    hashCode = hashCode * 59 + this.ServiceKey.GetHashCode();
                if (this.CreationTime != null)
                    hashCode = hashCode * 59 + this.CreationTime.GetHashCode();
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
