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
    /// SaveBasicSettingsInput
    /// </summary>
    [DataContract]
    public partial class SaveBasicSettingsInput :  IEquatable<SaveBasicSettingsInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SaveBasicSettingsInput" /> class.
        /// </summary>
        /// <param name="surname">真实姓名 real name.</param>
        /// <param name="department">所属部门 working department.</param>
        /// <param name="profile">个人简介 personal profile.</param>
        /// <param name="phoneNumber">电话号码 phone number.</param>
        public SaveBasicSettingsInput(string surname = default(string), string department = default(string), string profile = default(string), string phoneNumber = default(string))
        {
            this.Surname = surname;
            this.Department = department;
            this.Profile = profile;
            this.PhoneNumber = phoneNumber;
        }
        
        /// <summary>
        /// 真实姓名 real name
        /// </summary>
        /// <value>真实姓名 real name</value>
        [DataMember(Name="surname", EmitDefaultValue=true)]
        public string Surname { get; set; }

        /// <summary>
        /// 所属部门 working department
        /// </summary>
        /// <value>所属部门 working department</value>
        [DataMember(Name="department", EmitDefaultValue=true)]
        public string Department { get; set; }

        /// <summary>
        /// 个人简介 personal profile
        /// </summary>
        /// <value>个人简介 personal profile</value>
        [DataMember(Name="profile", EmitDefaultValue=true)]
        public string Profile { get; set; }

        /// <summary>
        /// 电话号码 phone number
        /// </summary>
        /// <value>电话号码 phone number</value>
        [DataMember(Name="phoneNumber", EmitDefaultValue=true)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SaveBasicSettingsInput {\n");
            sb.Append("  Surname: ").Append(Surname).Append("\n");
            sb.Append("  Department: ").Append(Department).Append("\n");
            sb.Append("  Profile: ").Append(Profile).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
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
            return this.Equals(input as SaveBasicSettingsInput);
        }

        /// <summary>
        /// Returns true if SaveBasicSettingsInput instances are equal
        /// </summary>
        /// <param name="input">Instance of SaveBasicSettingsInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SaveBasicSettingsInput input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Surname == input.Surname ||
                    (this.Surname != null &&
                    this.Surname.Equals(input.Surname))
                ) && 
                (
                    this.Department == input.Department ||
                    (this.Department != null &&
                    this.Department.Equals(input.Department))
                ) && 
                (
                    this.Profile == input.Profile ||
                    (this.Profile != null &&
                    this.Profile.Equals(input.Profile))
                ) && 
                (
                    this.PhoneNumber == input.PhoneNumber ||
                    (this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(input.PhoneNumber))
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
                if (this.Surname != null)
                    hashCode = hashCode * 59 + this.Surname.GetHashCode();
                if (this.Department != null)
                    hashCode = hashCode * 59 + this.Department.GetHashCode();
                if (this.Profile != null)
                    hashCode = hashCode * 59 + this.Profile.GetHashCode();
                if (this.PhoneNumber != null)
                    hashCode = hashCode * 59 + this.PhoneNumber.GetHashCode();
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
