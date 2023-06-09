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
    /// UpdateButtonPerInput
    /// </summary>
    [DataContract]
    public partial class UpdateButtonPerInput :  IEquatable<UpdateButtonPerInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateButtonPerInput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateButtonPerInput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateButtonPerInput" /> class.
        /// </summary>
        /// <param name="id">按钮ID button id (required).</param>
        /// <param name="name">按钮名称 button name (required).</param>
        /// <param name="regular">按钮权限规则-正则 button permission regular.</param>
        /// <param name="apiRegular">后端API权限规则.</param>
        public UpdateButtonPerInput(Guid id = default(Guid), string name = default(string), string regular = default(string), string apiRegular = default(string))
        {
            this.Id = id;
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for UpdateButtonPerInput and cannot be null");
            this.Regular = regular;
            this.ApiRegular = apiRegular;
        }
        
        /// <summary>
        /// 按钮ID button id
        /// </summary>
        /// <value>按钮ID button id</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid Id { get; set; }

        /// <summary>
        /// 按钮名称 button name
        /// </summary>
        /// <value>按钮名称 button name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// 按钮权限规则-正则 button permission regular
        /// </summary>
        /// <value>按钮权限规则-正则 button permission regular</value>
        [DataMember(Name="regular", EmitDefaultValue=true)]
        public string Regular { get; set; }

        /// <summary>
        /// 后端API权限规则
        /// </summary>
        /// <value>后端API权限规则</value>
        [DataMember(Name="apiRegular", EmitDefaultValue=true)]
        public string ApiRegular { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateButtonPerInput {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Regular: ").Append(Regular).Append("\n");
            sb.Append("  ApiRegular: ").Append(ApiRegular).Append("\n");
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
            return this.Equals(input as UpdateButtonPerInput);
        }

        /// <summary>
        /// Returns true if UpdateButtonPerInput instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateButtonPerInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateButtonPerInput input)
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
                    this.Regular == input.Regular ||
                    (this.Regular != null &&
                    this.Regular.Equals(input.Regular))
                ) && 
                (
                    this.ApiRegular == input.ApiRegular ||
                    (this.ApiRegular != null &&
                    this.ApiRegular.Equals(input.ApiRegular))
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
                if (this.Regular != null)
                    hashCode = hashCode * 59 + this.Regular.GetHashCode();
                if (this.ApiRegular != null)
                    hashCode = hashCode * 59 + this.ApiRegular.GetHashCode();
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
