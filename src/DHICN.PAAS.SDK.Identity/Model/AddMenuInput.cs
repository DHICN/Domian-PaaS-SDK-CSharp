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
    /// AddMenuInput
    /// </summary>
    [DataContract]
    public partial class AddMenuInput :  IEquatable<AddMenuInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddMenuInput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AddMenuInput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddMenuInput" /> class.
        /// </summary>
        /// <param name="pid">父级菜单Id parent menu id.</param>
        /// <param name="name">菜单名称 menu name (required).</param>
        /// <param name="menuRouter">菜单路由,前端的路由走向 menu router.</param>
        /// <param name="systemId">所属系统Id system id (required).</param>
        public AddMenuInput(Guid? pid = default(Guid?), string name = default(string), string menuRouter = default(string), Guid systemId = default(Guid))
        {
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for AddMenuInput and cannot be null");
            this.SystemId = systemId;
            this.Pid = pid;
            this.MenuRouter = menuRouter;
        }
        
        /// <summary>
        /// 父级菜单Id parent menu id
        /// </summary>
        /// <value>父级菜单Id parent menu id</value>
        [DataMember(Name="pid", EmitDefaultValue=true)]
        public Guid? Pid { get; set; }

        /// <summary>
        /// 菜单名称 menu name
        /// </summary>
        /// <value>菜单名称 menu name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// 菜单路由,前端的路由走向 menu router
        /// </summary>
        /// <value>菜单路由,前端的路由走向 menu router</value>
        [DataMember(Name="menuRouter", EmitDefaultValue=true)]
        public string MenuRouter { get; set; }

        /// <summary>
        /// 所属系统Id system id
        /// </summary>
        /// <value>所属系统Id system id</value>
        [DataMember(Name="systemId", EmitDefaultValue=false)]
        public Guid SystemId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddMenuInput {\n");
            sb.Append("  Pid: ").Append(Pid).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  MenuRouter: ").Append(MenuRouter).Append("\n");
            sb.Append("  SystemId: ").Append(SystemId).Append("\n");
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
            return this.Equals(input as AddMenuInput);
        }

        /// <summary>
        /// Returns true if AddMenuInput instances are equal
        /// </summary>
        /// <param name="input">Instance of AddMenuInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddMenuInput input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Pid == input.Pid ||
                    (this.Pid != null &&
                    this.Pid.Equals(input.Pid))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.MenuRouter == input.MenuRouter ||
                    (this.MenuRouter != null &&
                    this.MenuRouter.Equals(input.MenuRouter))
                ) && 
                (
                    this.SystemId == input.SystemId ||
                    (this.SystemId != null &&
                    this.SystemId.Equals(input.SystemId))
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
                if (this.Pid != null)
                    hashCode = hashCode * 59 + this.Pid.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.MenuRouter != null)
                    hashCode = hashCode * 59 + this.MenuRouter.GetHashCode();
                if (this.SystemId != null)
                    hashCode = hashCode * 59 + this.SystemId.GetHashCode();
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