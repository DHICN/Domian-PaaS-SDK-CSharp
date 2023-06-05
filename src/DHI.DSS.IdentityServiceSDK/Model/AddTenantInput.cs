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
    /// AddTenantInput
    /// </summary>
    [DataContract]
    public partial class AddTenantInput :  IEquatable<AddTenantInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddTenantInput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AddTenantInput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddTenantInput" /> class.
        /// </summary>
        /// <param name="systemId">分组Id/系统Id group/system id (required).</param>
        /// <param name="name">租户名称 tenant name (required).</param>
        /// <param name="adminUserName">租户管理员账号 administrator name of the tenant (required).</param>
        /// <param name="isOpenIOT">是否开通IOT功能 if open IoT function.</param>
        /// <param name="attributes">自定义属性:K-V自定义列-值 customized attributes in key-value pairs.</param>
        public AddTenantInput(Guid systemId = default(Guid), string name = default(string), string adminUserName = default(string), bool? isOpenIOT = default(bool?), List<StringStringKeyValue> attributes = default(List<StringStringKeyValue>))
        {
            this.SystemId = systemId;
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for AddTenantInput and cannot be null");
            // to ensure "adminUserName" is required (not null)
            this.AdminUserName = adminUserName ?? throw new ArgumentNullException("adminUserName is a required property for AddTenantInput and cannot be null");
            this.IsOpenIOT = isOpenIOT;
            this.Attributes = attributes;
        }
        
        /// <summary>
        /// 分组Id/系统Id group/system id
        /// </summary>
        /// <value>分组Id/系统Id group/system id</value>
        [DataMember(Name="systemId", EmitDefaultValue=false)]
        public Guid SystemId { get; set; }

        /// <summary>
        /// 租户名称 tenant name
        /// </summary>
        /// <value>租户名称 tenant name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// 租户管理员账号 administrator name of the tenant
        /// </summary>
        /// <value>租户管理员账号 administrator name of the tenant</value>
        [DataMember(Name="adminUserName", EmitDefaultValue=false)]
        public string AdminUserName { get; set; }

        /// <summary>
        /// 是否开通IOT功能 if open IoT function
        /// </summary>
        /// <value>是否开通IOT功能 if open IoT function</value>
        [DataMember(Name="isOpenIOT", EmitDefaultValue=true)]
        public bool? IsOpenIOT { get; set; }

        /// <summary>
        /// 自定义属性:K-V自定义列-值 customized attributes in key-value pairs
        /// </summary>
        /// <value>自定义属性:K-V自定义列-值 customized attributes in key-value pairs</value>
        [DataMember(Name="attributes", EmitDefaultValue=true)]
        public List<StringStringKeyValue> Attributes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddTenantInput {\n");
            sb.Append("  SystemId: ").Append(SystemId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  AdminUserName: ").Append(AdminUserName).Append("\n");
            sb.Append("  IsOpenIOT: ").Append(IsOpenIOT).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
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
            return this.Equals(input as AddTenantInput);
        }

        /// <summary>
        /// Returns true if AddTenantInput instances are equal
        /// </summary>
        /// <param name="input">Instance of AddTenantInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddTenantInput input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SystemId == input.SystemId ||
                    (this.SystemId != null &&
                    this.SystemId.Equals(input.SystemId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.AdminUserName == input.AdminUserName ||
                    (this.AdminUserName != null &&
                    this.AdminUserName.Equals(input.AdminUserName))
                ) && 
                (
                    this.IsOpenIOT == input.IsOpenIOT ||
                    (this.IsOpenIOT != null &&
                    this.IsOpenIOT.Equals(input.IsOpenIOT))
                ) && 
                (
                    this.Attributes == input.Attributes ||
                    this.Attributes != null &&
                    input.Attributes != null &&
                    this.Attributes.SequenceEqual(input.Attributes)
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
                if (this.SystemId != null)
                    hashCode = hashCode * 59 + this.SystemId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.AdminUserName != null)
                    hashCode = hashCode * 59 + this.AdminUserName.GetHashCode();
                if (this.IsOpenIOT != null)
                    hashCode = hashCode * 59 + this.IsOpenIOT.GetHashCode();
                if (this.Attributes != null)
                    hashCode = hashCode * 59 + this.Attributes.GetHashCode();
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
