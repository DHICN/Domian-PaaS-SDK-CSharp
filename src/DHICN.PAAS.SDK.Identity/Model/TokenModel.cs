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
    /// TokenModel
    /// </summary>
    [DataContract]
    public partial class TokenModel :  IEquatable<TokenModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TokenModel" /> class.
        /// </summary>
        /// <param name="idToken">idToken.</param>
        /// <param name="accessToken">accessToken.</param>
        /// <param name="expiresIn">expiresIn.</param>
        /// <param name="refreshToken">refreshToken.</param>
        /// <param name="scope">scope.</param>
        /// <param name="error">error.</param>
        /// <param name="errorDescription">errorDescription.</param>
        /// <param name="tokenType">tokenType.</param>
        public TokenModel(string idToken = default(string), string accessToken = default(string), long expiresIn = default(long), string refreshToken = default(string), string scope = default(string), string error = default(string), string errorDescription = default(string), string tokenType = default(string))
        {
            this.IdToken = idToken;
            this.AccessToken = accessToken;
            this.ExpiresIn = expiresIn;
            this.RefreshToken = refreshToken;
            this.Scope = scope;
            this.Error = error;
            this.ErrorDescription = errorDescription;
            this.TokenType = tokenType;
        }
        
        /// <summary>
        /// Gets or Sets IdToken
        /// </summary>
        [DataMember(Name="id_token", EmitDefaultValue=true)]
        public string IdToken { get; set; }

        /// <summary>
        /// Gets or Sets AccessToken
        /// </summary>
        [DataMember(Name="access_token", EmitDefaultValue=true)]
        public string AccessToken { get; set; }

        /// <summary>
        /// Gets or Sets ExpiresIn
        /// </summary>
        [DataMember(Name="expires_in", EmitDefaultValue=false)]
        public long ExpiresIn { get; set; }

        /// <summary>
        /// Gets or Sets RefreshToken
        /// </summary>
        [DataMember(Name="refresh_token", EmitDefaultValue=true)]
        public string RefreshToken { get; set; }

        /// <summary>
        /// Gets or Sets Scope
        /// </summary>
        [DataMember(Name="scope", EmitDefaultValue=true)]
        public string Scope { get; set; }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name="error", EmitDefaultValue=true)]
        public string Error { get; set; }

        /// <summary>
        /// Gets or Sets ErrorDescription
        /// </summary>
        [DataMember(Name="error_description", EmitDefaultValue=true)]
        public string ErrorDescription { get; set; }

        /// <summary>
        /// Gets or Sets TokenType
        /// </summary>
        [DataMember(Name="token_type", EmitDefaultValue=true)]
        public string TokenType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TokenModel {\n");
            sb.Append("  IdToken: ").Append(IdToken).Append("\n");
            sb.Append("  AccessToken: ").Append(AccessToken).Append("\n");
            sb.Append("  ExpiresIn: ").Append(ExpiresIn).Append("\n");
            sb.Append("  RefreshToken: ").Append(RefreshToken).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  ErrorDescription: ").Append(ErrorDescription).Append("\n");
            sb.Append("  TokenType: ").Append(TokenType).Append("\n");
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
            return this.Equals(input as TokenModel);
        }

        /// <summary>
        /// Returns true if TokenModel instances are equal
        /// </summary>
        /// <param name="input">Instance of TokenModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TokenModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IdToken == input.IdToken ||
                    (this.IdToken != null &&
                    this.IdToken.Equals(input.IdToken))
                ) && 
                (
                    this.AccessToken == input.AccessToken ||
                    (this.AccessToken != null &&
                    this.AccessToken.Equals(input.AccessToken))
                ) && 
                (
                    this.ExpiresIn == input.ExpiresIn ||
                    this.ExpiresIn.Equals(input.ExpiresIn)
                ) && 
                (
                    this.RefreshToken == input.RefreshToken ||
                    (this.RefreshToken != null &&
                    this.RefreshToken.Equals(input.RefreshToken))
                ) && 
                (
                    this.Scope == input.Scope ||
                    (this.Scope != null &&
                    this.Scope.Equals(input.Scope))
                ) && 
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
                ) && 
                (
                    this.ErrorDescription == input.ErrorDescription ||
                    (this.ErrorDescription != null &&
                    this.ErrorDescription.Equals(input.ErrorDescription))
                ) && 
                (
                    this.TokenType == input.TokenType ||
                    (this.TokenType != null &&
                    this.TokenType.Equals(input.TokenType))
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
                if (this.IdToken != null)
                    hashCode = hashCode * 59 + this.IdToken.GetHashCode();
                if (this.AccessToken != null)
                    hashCode = hashCode * 59 + this.AccessToken.GetHashCode();
                hashCode = hashCode * 59 + this.ExpiresIn.GetHashCode();
                if (this.RefreshToken != null)
                    hashCode = hashCode * 59 + this.RefreshToken.GetHashCode();
                if (this.Scope != null)
                    hashCode = hashCode * 59 + this.Scope.GetHashCode();
                if (this.Error != null)
                    hashCode = hashCode * 59 + this.Error.GetHashCode();
                if (this.ErrorDescription != null)
                    hashCode = hashCode * 59 + this.ErrorDescription.GetHashCode();
                if (this.TokenType != null)
                    hashCode = hashCode * 59 + this.TokenType.GetHashCode();
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