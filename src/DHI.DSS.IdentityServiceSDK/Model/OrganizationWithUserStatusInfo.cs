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
    /// OrganizationWithUserStatusInfo
    /// </summary>
    [DataContract]
    public partial class OrganizationWithUserStatusInfo :  IEquatable<OrganizationWithUserStatusInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationWithUserStatusInfo" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="levelCode">levelCode.</param>
        /// <param name="parentLevelCode">parentLevelCode.</param>
        /// <param name="users">users.</param>
        /// <param name="isHasChildren">isHasChildren.</param>
        /// <param name="children">children.</param>
        public OrganizationWithUserStatusInfo(Guid id = default(Guid), string name = default(string), string levelCode = default(string), string parentLevelCode = default(string), List<UserInfoWithStatus> users = default(List<UserInfoWithStatus>), bool isHasChildren = default(bool), List<OrganizationWithUserStatusInfo> children = default(List<OrganizationWithUserStatusInfo>))
        {
            this.Id = id;
            this.Name = name;
            this.LevelCode = levelCode;
            this.ParentLevelCode = parentLevelCode;
            this.Users = users;
            this.IsHasChildren = isHasChildren;
            this.Children = children;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets LevelCode
        /// </summary>
        [DataMember(Name="levelCode", EmitDefaultValue=true)]
        public string LevelCode { get; set; }

        /// <summary>
        /// Gets or Sets ParentLevelCode
        /// </summary>
        [DataMember(Name="parentLevelCode", EmitDefaultValue=true)]
        public string ParentLevelCode { get; set; }

        /// <summary>
        /// Gets or Sets Users
        /// </summary>
        [DataMember(Name="users", EmitDefaultValue=true)]
        public List<UserInfoWithStatus> Users { get; set; }

        /// <summary>
        /// Gets or Sets IsHasChildren
        /// </summary>
        [DataMember(Name="isHasChildren", EmitDefaultValue=false)]
        public bool IsHasChildren { get; set; }

        /// <summary>
        /// Gets or Sets Children
        /// </summary>
        [DataMember(Name="children", EmitDefaultValue=true)]
        public List<OrganizationWithUserStatusInfo> Children { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrganizationWithUserStatusInfo {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  LevelCode: ").Append(LevelCode).Append("\n");
            sb.Append("  ParentLevelCode: ").Append(ParentLevelCode).Append("\n");
            sb.Append("  Users: ").Append(Users).Append("\n");
            sb.Append("  IsHasChildren: ").Append(IsHasChildren).Append("\n");
            sb.Append("  Children: ").Append(Children).Append("\n");
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
            return this.Equals(input as OrganizationWithUserStatusInfo);
        }

        /// <summary>
        /// Returns true if OrganizationWithUserStatusInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of OrganizationWithUserStatusInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrganizationWithUserStatusInfo input)
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
                    this.LevelCode == input.LevelCode ||
                    (this.LevelCode != null &&
                    this.LevelCode.Equals(input.LevelCode))
                ) && 
                (
                    this.ParentLevelCode == input.ParentLevelCode ||
                    (this.ParentLevelCode != null &&
                    this.ParentLevelCode.Equals(input.ParentLevelCode))
                ) && 
                (
                    this.Users == input.Users ||
                    this.Users != null &&
                    input.Users != null &&
                    this.Users.SequenceEqual(input.Users)
                ) && 
                (
                    this.IsHasChildren == input.IsHasChildren ||
                    this.IsHasChildren.Equals(input.IsHasChildren)
                ) && 
                (
                    this.Children == input.Children ||
                    this.Children != null &&
                    input.Children != null &&
                    this.Children.SequenceEqual(input.Children)
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
                if (this.LevelCode != null)
                    hashCode = hashCode * 59 + this.LevelCode.GetHashCode();
                if (this.ParentLevelCode != null)
                    hashCode = hashCode * 59 + this.ParentLevelCode.GetHashCode();
                if (this.Users != null)
                    hashCode = hashCode * 59 + this.Users.GetHashCode();
                hashCode = hashCode * 59 + this.IsHasChildren.GetHashCode();
                if (this.Children != null)
                    hashCode = hashCode * 59 + this.Children.GetHashCode();
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
