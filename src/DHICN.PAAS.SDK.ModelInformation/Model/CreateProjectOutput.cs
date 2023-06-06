/* 
 * model-configuration-service
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
using OpenAPIDateConverter = DHICN.PAAS.SDK.ModelInformation.Client.OpenAPIDateConverter;

namespace DHICN.PAAS.SDK.ModelInformation.Model
{
    /// <summary>
    /// CreateProjectOutput
    /// </summary>
    [DataContract]
    public partial class CreateProjectOutput :  IEquatable<CreateProjectOutput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectOutput" /> class.
        /// </summary>
        /// <param name="adminUserName">项目管理员账户 project administrator name.</param>
        /// <param name="tenantId">租户ID tenant id.</param>
        public CreateProjectOutput(string adminUserName = default(string), Guid tenantId = default(Guid))
        {
            this.AdminUserName = adminUserName;
            this.TenantId = tenantId;
        }
        
        /// <summary>
        /// 项目管理员账户 project administrator name
        /// </summary>
        /// <value>项目管理员账户 project administrator name</value>
        [DataMember(Name="adminUserName", EmitDefaultValue=true)]
        public string AdminUserName { get; set; }

        /// <summary>
        /// 租户ID tenant id
        /// </summary>
        /// <value>租户ID tenant id</value>
        [DataMember(Name="tenantId", EmitDefaultValue=false)]
        public Guid TenantId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateProjectOutput {\n");
            sb.Append("  AdminUserName: ").Append(AdminUserName).Append("\n");
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
            return this.Equals(input as CreateProjectOutput);
        }

        /// <summary>
        /// Returns true if CreateProjectOutput instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateProjectOutput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateProjectOutput input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AdminUserName == input.AdminUserName ||
                    (this.AdminUserName != null &&
                    this.AdminUserName.Equals(input.AdminUserName))
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
                if (this.AdminUserName != null)
                    hashCode = hashCode * 59 + this.AdminUserName.GetHashCode();
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
