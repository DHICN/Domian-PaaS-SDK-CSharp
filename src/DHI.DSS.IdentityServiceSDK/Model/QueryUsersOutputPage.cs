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
    /// QueryUsersOutputPage
    /// </summary>
    [DataContract]
    public partial class QueryUsersOutputPage :  IEquatable<QueryUsersOutputPage>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryUsersOutputPage" /> class.
        /// </summary>
        /// <param name="pageIndex">pageIndex.</param>
        /// <param name="pageSize">pageSize.</param>
        /// <param name="list">list.</param>
        /// <param name="totalCount">totalCount.</param>
        public QueryUsersOutputPage(int pageIndex = default(int), int pageSize = default(int), List<QueryUsersOutput> list = default(List<QueryUsersOutput>), long totalCount = default(long))
        {
            this.PageIndex = pageIndex;
            this.PageSize = pageSize;
            this.List = list;
            this.TotalCount = totalCount;
        }
        
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
        /// Gets or Sets List
        /// </summary>
        [DataMember(Name="list", EmitDefaultValue=true)]
        public List<QueryUsersOutput> List { get; set; }

        /// <summary>
        /// Gets or Sets TotalCount
        /// </summary>
        [DataMember(Name="totalCount", EmitDefaultValue=false)]
        public long TotalCount { get; set; }

        /// <summary>
        /// Gets or Sets TotalPages
        /// </summary>
        [DataMember(Name="totalPages", EmitDefaultValue=false)]
        public long TotalPages { get; private set; }

        /// <summary>
        /// Gets or Sets HaveNextPage
        /// </summary>
        [DataMember(Name="haveNextPage", EmitDefaultValue=false)]
        public bool HaveNextPage { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryUsersOutputPage {\n");
            sb.Append("  PageIndex: ").Append(PageIndex).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  List: ").Append(List).Append("\n");
            sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  TotalPages: ").Append(TotalPages).Append("\n");
            sb.Append("  HaveNextPage: ").Append(HaveNextPage).Append("\n");
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
            return this.Equals(input as QueryUsersOutputPage);
        }

        /// <summary>
        /// Returns true if QueryUsersOutputPage instances are equal
        /// </summary>
        /// <param name="input">Instance of QueryUsersOutputPage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueryUsersOutputPage input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PageIndex == input.PageIndex ||
                    this.PageIndex.Equals(input.PageIndex)
                ) && 
                (
                    this.PageSize == input.PageSize ||
                    this.PageSize.Equals(input.PageSize)
                ) && 
                (
                    this.List == input.List ||
                    this.List != null &&
                    input.List != null &&
                    this.List.SequenceEqual(input.List)
                ) && 
                (
                    this.TotalCount == input.TotalCount ||
                    this.TotalCount.Equals(input.TotalCount)
                ) && 
                (
                    this.TotalPages == input.TotalPages ||
                    this.TotalPages.Equals(input.TotalPages)
                ) && 
                (
                    this.HaveNextPage == input.HaveNextPage ||
                    this.HaveNextPage.Equals(input.HaveNextPage)
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
                hashCode = hashCode * 59 + this.PageIndex.GetHashCode();
                hashCode = hashCode * 59 + this.PageSize.GetHashCode();
                if (this.List != null)
                    hashCode = hashCode * 59 + this.List.GetHashCode();
                hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                hashCode = hashCode * 59 + this.TotalPages.GetHashCode();
                hashCode = hashCode * 59 + this.HaveNextPage.GetHashCode();
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
