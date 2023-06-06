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
    /// CreateProjectGenericInput
    /// </summary>
    [DataContract]
    public partial class CreateProjectGenericInput :  IEquatable<CreateProjectGenericInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectGenericInput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateProjectGenericInput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectGenericInput" /> class.
        /// </summary>
        /// <param name="systemId">系统ID system id (required).</param>
        /// <param name="name">项目名称 project name (required).</param>
        /// <param name="adminUserName">管理员账户 administrator of the project (required).</param>
        /// <param name="attributes">项目自定义属性 project customized attributes.</param>
        public CreateProjectGenericInput(Guid systemId = default(Guid), string name = default(string), string adminUserName = default(string), List<StringStringKeyValue> attributes = default(List<StringStringKeyValue>))
        {
            this.SystemId = systemId;
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for CreateProjectGenericInput and cannot be null");
            // to ensure "adminUserName" is required (not null)
            this.AdminUserName = adminUserName ?? throw new ArgumentNullException("adminUserName is a required property for CreateProjectGenericInput and cannot be null");
            this.Attributes = attributes;
        }
        
        /// <summary>
        /// 系统ID system id
        /// </summary>
        /// <value>系统ID system id</value>
        [DataMember(Name="systemId", EmitDefaultValue=false)]
        public Guid SystemId { get; set; }

        /// <summary>
        /// 项目名称 project name
        /// </summary>
        /// <value>项目名称 project name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// 管理员账户 administrator of the project
        /// </summary>
        /// <value>管理员账户 administrator of the project</value>
        [DataMember(Name="adminUserName", EmitDefaultValue=false)]
        public string AdminUserName { get; set; }

        /// <summary>
        /// 项目自定义属性 project customized attributes
        /// </summary>
        /// <value>项目自定义属性 project customized attributes</value>
        [DataMember(Name="attributes", EmitDefaultValue=true)]
        public List<StringStringKeyValue> Attributes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateProjectGenericInput {\n");
            sb.Append("  SystemId: ").Append(SystemId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  AdminUserName: ").Append(AdminUserName).Append("\n");
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
            return this.Equals(input as CreateProjectGenericInput);
        }

        /// <summary>
        /// Returns true if CreateProjectGenericInput instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateProjectGenericInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateProjectGenericInput input)
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
