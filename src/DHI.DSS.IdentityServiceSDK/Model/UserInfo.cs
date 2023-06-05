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
    /// UserInfo
    /// </summary>
    [DataContract]
    public partial class UserInfo :  IEquatable<UserInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserInfo" /> class.
        /// </summary>
        /// <param name="id">用户ID user id.</param>
        /// <param name="userName">用户名 user name.</param>
        /// <param name="surname">姓氏 surname.</param>
        /// <param name="email">邮箱 email address.</param>
        /// <param name="emailConfirmed">邮箱地址是否确认 if email address has been confirmed.</param>
        /// <param name="phoneNumber">手机号码 phone number.</param>
        /// <param name="phoneNumberConfirmed">手机号码是否确认 if phone number has been confirmed.</param>
        /// <param name="department">所属单位 working department.</param>
        /// <param name="roles">角色列表 roles.</param>
        public UserInfo(Guid id = default(Guid), string userName = default(string), string surname = default(string), string email = default(string), bool emailConfirmed = default(bool), string phoneNumber = default(string), bool phoneNumberConfirmed = default(bool), string department = default(string), List<string> roles = default(List<string>))
        {
            this.Id = id;
            this.UserName = userName;
            this.Surname = surname;
            this.Email = email;
            this.EmailConfirmed = emailConfirmed;
            this.PhoneNumber = phoneNumber;
            this.PhoneNumberConfirmed = phoneNumberConfirmed;
            this.Department = department;
            this.Roles = roles;
        }
        
        /// <summary>
        /// 用户ID user id
        /// </summary>
        /// <value>用户ID user id</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid Id { get; set; }

        /// <summary>
        /// 用户名 user name
        /// </summary>
        /// <value>用户名 user name</value>
        [DataMember(Name="userName", EmitDefaultValue=true)]
        public string UserName { get; set; }

        /// <summary>
        /// 姓氏 surname
        /// </summary>
        /// <value>姓氏 surname</value>
        [DataMember(Name="surname", EmitDefaultValue=true)]
        public string Surname { get; set; }

        /// <summary>
        /// 邮箱 email address
        /// </summary>
        /// <value>邮箱 email address</value>
        [DataMember(Name="email", EmitDefaultValue=true)]
        public string Email { get; set; }

        /// <summary>
        /// 邮箱地址是否确认 if email address has been confirmed
        /// </summary>
        /// <value>邮箱地址是否确认 if email address has been confirmed</value>
        [DataMember(Name="emailConfirmed", EmitDefaultValue=false)]
        public bool EmailConfirmed { get; set; }

        /// <summary>
        /// 手机号码 phone number
        /// </summary>
        /// <value>手机号码 phone number</value>
        [DataMember(Name="phoneNumber", EmitDefaultValue=true)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// 手机号码是否确认 if phone number has been confirmed
        /// </summary>
        /// <value>手机号码是否确认 if phone number has been confirmed</value>
        [DataMember(Name="phoneNumberConfirmed", EmitDefaultValue=false)]
        public bool PhoneNumberConfirmed { get; set; }

        /// <summary>
        /// 所属单位 working department
        /// </summary>
        /// <value>所属单位 working department</value>
        [DataMember(Name="department", EmitDefaultValue=true)]
        public string Department { get; set; }

        /// <summary>
        /// 角色列表 roles
        /// </summary>
        /// <value>角色列表 roles</value>
        [DataMember(Name="roles", EmitDefaultValue=true)]
        public List<string> Roles { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserInfo {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("  Surname: ").Append(Surname).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  EmailConfirmed: ").Append(EmailConfirmed).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  PhoneNumberConfirmed: ").Append(PhoneNumberConfirmed).Append("\n");
            sb.Append("  Department: ").Append(Department).Append("\n");
            sb.Append("  Roles: ").Append(Roles).Append("\n");
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
            return this.Equals(input as UserInfo);
        }

        /// <summary>
        /// Returns true if UserInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of UserInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserInfo input)
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
                    this.UserName == input.UserName ||
                    (this.UserName != null &&
                    this.UserName.Equals(input.UserName))
                ) && 
                (
                    this.Surname == input.Surname ||
                    (this.Surname != null &&
                    this.Surname.Equals(input.Surname))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.EmailConfirmed == input.EmailConfirmed ||
                    this.EmailConfirmed.Equals(input.EmailConfirmed)
                ) && 
                (
                    this.PhoneNumber == input.PhoneNumber ||
                    (this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(input.PhoneNumber))
                ) && 
                (
                    this.PhoneNumberConfirmed == input.PhoneNumberConfirmed ||
                    this.PhoneNumberConfirmed.Equals(input.PhoneNumberConfirmed)
                ) && 
                (
                    this.Department == input.Department ||
                    (this.Department != null &&
                    this.Department.Equals(input.Department))
                ) && 
                (
                    this.Roles == input.Roles ||
                    this.Roles != null &&
                    input.Roles != null &&
                    this.Roles.SequenceEqual(input.Roles)
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
                if (this.UserName != null)
                    hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.Surname != null)
                    hashCode = hashCode * 59 + this.Surname.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                hashCode = hashCode * 59 + this.EmailConfirmed.GetHashCode();
                if (this.PhoneNumber != null)
                    hashCode = hashCode * 59 + this.PhoneNumber.GetHashCode();
                hashCode = hashCode * 59 + this.PhoneNumberConfirmed.GetHashCode();
                if (this.Department != null)
                    hashCode = hashCode * 59 + this.Department.GetHashCode();
                if (this.Roles != null)
                    hashCode = hashCode * 59 + this.Roles.GetHashCode();
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
