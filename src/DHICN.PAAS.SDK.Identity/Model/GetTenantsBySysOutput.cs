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
    /// GetTenantsBySysOutput
    /// </summary>
    [DataContract]
    public partial class GetTenantsBySysOutput :  IEquatable<GetTenantsBySysOutput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTenantsBySysOutput" /> class.
        /// </summary>
        /// <param name="id">租户ID tenant id.</param>
        /// <param name="systemId">系统ID system id.</param>
        /// <param name="name">租户名称 tenant name.</param>
        public GetTenantsBySysOutput(Guid id = default(Guid), Guid systemId = default(Guid), string name = default(string))
        {
            this.Id = id;
            this.SystemId = systemId;
            this.Name = name;
        }
        
        /// <summary>
        /// 租户ID tenant id
        /// </summary>
        /// <value>租户ID tenant id</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid Id { get; set; }

        /// <summary>
        /// 系统ID system id
        /// </summary>
        /// <value>系统ID system id</value>
        [DataMember(Name="systemId", EmitDefaultValue=false)]
        public Guid SystemId { get; set; }

        /// <summary>
        /// 租户名称 tenant name
        /// </summary>
        /// <value>租户名称 tenant name</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetTenantsBySysOutput {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  SystemId: ").Append(SystemId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as GetTenantsBySysOutput);
        }

        /// <summary>
        /// Returns true if GetTenantsBySysOutput instances are equal
        /// </summary>
        /// <param name="input">Instance of GetTenantsBySysOutput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetTenantsBySysOutput input)
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
                    this.SystemId == input.SystemId ||
                    (this.SystemId != null &&
                    this.SystemId.Equals(input.SystemId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.SystemId != null)
                    hashCode = hashCode * 59 + this.SystemId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
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
