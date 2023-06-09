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
    /// AddUserInput
    /// </summary>
    [DataContract]
    public partial class AddUserInput :  IEquatable<AddUserInput>, IValidatableObject
    {
        /// <summary>
        /// 0-Normal(normal user) 1-Frozen(frozen user) 2-Cancelled(cancelled user) 
        /// </summary>
        /// <value>0-Normal(normal user) 1-Frozen(frozen user) 2-Cancelled(cancelled user) </value>
        public enum StatusEnum
        {
            /// <summary>
            /// Enum NUMBER_0 for value: 0
            /// </summary>
            NUMBER_0 = 0,

            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            NUMBER_1 = 1,

            /// <summary>
            /// Enum NUMBER_2 for value: 2
            /// </summary>
            NUMBER_2 = 2

        }

        /// <summary>
        /// 0-Normal(normal user) 1-Frozen(frozen user) 2-Cancelled(cancelled user) 
        /// </summary>
        /// <value>0-Normal(normal user) 1-Frozen(frozen user) 2-Cancelled(cancelled user) </value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddUserInput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AddUserInput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddUserInput" /> class.
        /// </summary>
        /// <param name="userName">用户名 user name (required).</param>
        /// <param name="surname">姓氏 surname.</param>
        /// <param name="roles">角色ID列表 role ids.</param>
        /// <param name="phoneNumber">手机号码 phone number.</param>
        /// <param name="department">所属部门 working department.</param>
        /// <param name="status">0-Normal(normal user) 1-Frozen(frozen user) 2-Cancelled(cancelled user)  (required).</param>
        /// <param name="isTrialUser">是否试用用户 if it is a trial user.</param>
        /// <param name="trialDays">试用多少天 trial days.</param>
        /// <param name="email">邮件 email address.</param>
        public AddUserInput(string userName = default(string), string surname = default(string), List<Guid> roles = default(List<Guid>), string phoneNumber = default(string), string department = default(string), StatusEnum status = default(StatusEnum), bool isTrialUser = default(bool), int trialDays = default(int), string email = default(string))
        {
            // to ensure "userName" is required (not null)
            this.UserName = userName ?? throw new ArgumentNullException("userName is a required property for AddUserInput and cannot be null");
            this.Status = status;
            this.Surname = surname;
            this.Roles = roles;
            this.PhoneNumber = phoneNumber;
            this.Department = department;
            this.IsTrialUser = isTrialUser;
            this.TrialDays = trialDays;
            this.Email = email;
        }
        
        /// <summary>
        /// 用户名 user name
        /// </summary>
        /// <value>用户名 user name</value>
        [DataMember(Name="userName", EmitDefaultValue=false)]
        public string UserName { get; set; }

        /// <summary>
        /// 姓氏 surname
        /// </summary>
        /// <value>姓氏 surname</value>
        [DataMember(Name="surname", EmitDefaultValue=true)]
        public string Surname { get; set; }

        /// <summary>
        /// 角色ID列表 role ids
        /// </summary>
        /// <value>角色ID列表 role ids</value>
        [DataMember(Name="roles", EmitDefaultValue=true)]
        public List<Guid> Roles { get; set; }

        /// <summary>
        /// 手机号码 phone number
        /// </summary>
        /// <value>手机号码 phone number</value>
        [DataMember(Name="phoneNumber", EmitDefaultValue=true)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// 所属部门 working department
        /// </summary>
        /// <value>所属部门 working department</value>
        [DataMember(Name="department", EmitDefaultValue=true)]
        public string Department { get; set; }

        /// <summary>
        /// 是否试用用户 if it is a trial user
        /// </summary>
        /// <value>是否试用用户 if it is a trial user</value>
        [DataMember(Name="isTrialUser", EmitDefaultValue=false)]
        public bool IsTrialUser { get; set; }

        /// <summary>
        /// 试用多少天 trial days
        /// </summary>
        /// <value>试用多少天 trial days</value>
        [DataMember(Name="trialDays", EmitDefaultValue=false)]
        public int TrialDays { get; set; }

        /// <summary>
        /// 邮件 email address
        /// </summary>
        /// <value>邮件 email address</value>
        [DataMember(Name="email", EmitDefaultValue=true)]
        public string Email { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddUserInput {\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("  Surname: ").Append(Surname).Append("\n");
            sb.Append("  Roles: ").Append(Roles).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  Department: ").Append(Department).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  IsTrialUser: ").Append(IsTrialUser).Append("\n");
            sb.Append("  TrialDays: ").Append(TrialDays).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
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
            return this.Equals(input as AddUserInput);
        }

        /// <summary>
        /// Returns true if AddUserInput instances are equal
        /// </summary>
        /// <param name="input">Instance of AddUserInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddUserInput input)
        {
            if (input == null)
                return false;

            return 
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
                    this.Roles == input.Roles ||
                    this.Roles != null &&
                    input.Roles != null &&
                    this.Roles.SequenceEqual(input.Roles)
                ) && 
                (
                    this.PhoneNumber == input.PhoneNumber ||
                    (this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(input.PhoneNumber))
                ) && 
                (
                    this.Department == input.Department ||
                    (this.Department != null &&
                    this.Department.Equals(input.Department))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.IsTrialUser == input.IsTrialUser ||
                    this.IsTrialUser.Equals(input.IsTrialUser)
                ) && 
                (
                    this.TrialDays == input.TrialDays ||
                    this.TrialDays.Equals(input.TrialDays)
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
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
                if (this.UserName != null)
                    hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.Surname != null)
                    hashCode = hashCode * 59 + this.Surname.GetHashCode();
                if (this.Roles != null)
                    hashCode = hashCode * 59 + this.Roles.GetHashCode();
                if (this.PhoneNumber != null)
                    hashCode = hashCode * 59 + this.PhoneNumber.GetHashCode();
                if (this.Department != null)
                    hashCode = hashCode * 59 + this.Department.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                hashCode = hashCode * 59 + this.IsTrialUser.GetHashCode();
                hashCode = hashCode * 59 + this.TrialDays.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
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
