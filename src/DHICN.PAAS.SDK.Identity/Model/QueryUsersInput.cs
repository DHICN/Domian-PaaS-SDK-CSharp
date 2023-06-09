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
    /// QueryUsersInput
    /// </summary>
    [DataContract]
    public partial class QueryUsersInput :  IEquatable<QueryUsersInput>, IValidatableObject
    {
        /// <summary>
        /// 用户状态 user status
        /// </summary>
        /// <value>用户状态 user status</value>
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
        /// 用户状态 user status
        /// </summary>
        /// <value>用户状态 user status</value>
        [DataMember(Name="status", EmitDefaultValue=true)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryUsersInput" /> class.
        /// </summary>
        /// <param name="keyWords">keyWords.</param>
        /// <param name="pageIndex">pageIndex.</param>
        /// <param name="pageSize">pageSize.</param>
        /// <param name="status">用户状态 user status.</param>
        /// <param name="isTrialUser">是否试用用户 if it is a trial user.</param>
        public QueryUsersInput(string keyWords = default(string), int pageIndex = default(int), int pageSize = default(int), StatusEnum? status = default(StatusEnum?), bool? isTrialUser = default(bool?))
        {
            this.KeyWords = keyWords;
            this.PageIndex = pageIndex;
            this.PageSize = pageSize;
            this.Status = status;
            this.IsTrialUser = isTrialUser;
        }
        
        /// <summary>
        /// Gets or Sets KeyWords
        /// </summary>
        [DataMember(Name="keyWords", EmitDefaultValue=true)]
        public string KeyWords { get; set; }

        /// <summary>
        /// Gets or Sets PageIndex
        /// </summary>
        [DataMember(Name="pageIndex", EmitDefaultValue=false)]
        public int PageIndex { get; set; }

        /// <summary>
        /// Gets or Sets PageSize
        /// </summary>
        [DataMember(Name="pageSize", EmitDefaultValue=false)]
        public int PageSize { get; set; }

        /// <summary>
        /// 是否试用用户 if it is a trial user
        /// </summary>
        /// <value>是否试用用户 if it is a trial user</value>
        [DataMember(Name="isTrialUser", EmitDefaultValue=true)]
        public bool? IsTrialUser { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryUsersInput {\n");
            sb.Append("  KeyWords: ").Append(KeyWords).Append("\n");
            sb.Append("  PageIndex: ").Append(PageIndex).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  IsTrialUser: ").Append(IsTrialUser).Append("\n");
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
            return this.Equals(input as QueryUsersInput);
        }

        /// <summary>
        /// Returns true if QueryUsersInput instances are equal
        /// </summary>
        /// <param name="input">Instance of QueryUsersInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueryUsersInput input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.KeyWords == input.KeyWords ||
                    (this.KeyWords != null &&
                    this.KeyWords.Equals(input.KeyWords))
                ) && 
                (
                    this.PageIndex == input.PageIndex ||
                    this.PageIndex.Equals(input.PageIndex)
                ) && 
                (
                    this.PageSize == input.PageSize ||
                    this.PageSize.Equals(input.PageSize)
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.IsTrialUser == input.IsTrialUser ||
                    (this.IsTrialUser != null &&
                    this.IsTrialUser.Equals(input.IsTrialUser))
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
                if (this.KeyWords != null)
                    hashCode = hashCode * 59 + this.KeyWords.GetHashCode();
                hashCode = hashCode * 59 + this.PageIndex.GetHashCode();
                hashCode = hashCode * 59 + this.PageSize.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.IsTrialUser != null)
                    hashCode = hashCode * 59 + this.IsTrialUser.GetHashCode();
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
