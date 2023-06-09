/* 
 * document-manager-service
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
using OpenAPIDateConverter = DHICN.PAAS.SDK.DocumentManager.Client.OpenAPIDateConverter;

namespace DHICN.PAAS.SDK.DocumentManager.Model
{
    /// <summary>
    /// HttpRequestMessage
    /// </summary>
    [DataContract]
    public partial class HttpRequestMessage :  IEquatable<HttpRequestMessage>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets VersionPolicy
        /// </summary>
        [DataMember(Name="versionPolicy", EmitDefaultValue=false)]
        public HttpVersionPolicy? VersionPolicy { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="HttpRequestMessage" /> class.
        /// </summary>
        /// <param name="version">version.</param>
        /// <param name="versionPolicy">versionPolicy.</param>
        /// <param name="content">content.</param>
        /// <param name="method">method.</param>
        /// <param name="requestUri">requestUri.</param>
        public HttpRequestMessage(Version version = default(Version), HttpVersionPolicy? versionPolicy = default(HttpVersionPolicy?), HttpContent content = default(HttpContent), HttpMethod method = default(HttpMethod), string requestUri = default(string))
        {
            this.Version = version;
            this.VersionPolicy = versionPolicy;
            this.Content = content;
            this.Method = method;
            this.RequestUri = requestUri;
        }
        
        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public Version Version { get; set; }

        /// <summary>
        /// Gets or Sets Content
        /// </summary>
        [DataMember(Name="content", EmitDefaultValue=false)]
        public HttpContent Content { get; set; }

        /// <summary>
        /// Gets or Sets Method
        /// </summary>
        [DataMember(Name="method", EmitDefaultValue=false)]
        public HttpMethod Method { get; set; }

        /// <summary>
        /// Gets or Sets RequestUri
        /// </summary>
        [DataMember(Name="requestUri", EmitDefaultValue=true)]
        public string RequestUri { get; set; }

        /// <summary>
        /// Gets or Sets Headers
        /// </summary>
        [DataMember(Name="headers", EmitDefaultValue=true)]
        public List<StringStringIEnumerableKeyValuePair> Headers { get; private set; }

        /// <summary>
        /// Gets or Sets Properties
        /// </summary>
        [DataMember(Name="properties", EmitDefaultValue=true)]
        public Dictionary<string, string> Properties { get; private set; }

        /// <summary>
        /// Gets or Sets Options
        /// </summary>
        [DataMember(Name="options", EmitDefaultValue=true)]
        public Dictionary<string, string> Options { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HttpRequestMessage {\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  VersionPolicy: ").Append(VersionPolicy).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  RequestUri: ").Append(RequestUri).Append("\n");
            sb.Append("  Headers: ").Append(Headers).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
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
            return this.Equals(input as HttpRequestMessage);
        }

        /// <summary>
        /// Returns true if HttpRequestMessage instances are equal
        /// </summary>
        /// <param name="input">Instance of HttpRequestMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HttpRequestMessage input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.VersionPolicy == input.VersionPolicy ||
                    this.VersionPolicy.Equals(input.VersionPolicy)
                ) && 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
                ) && 
                (
                    this.Method == input.Method ||
                    (this.Method != null &&
                    this.Method.Equals(input.Method))
                ) && 
                (
                    this.RequestUri == input.RequestUri ||
                    (this.RequestUri != null &&
                    this.RequestUri.Equals(input.RequestUri))
                ) && 
                (
                    this.Headers == input.Headers ||
                    this.Headers != null &&
                    input.Headers != null &&
                    this.Headers.SequenceEqual(input.Headers)
                ) && 
                (
                    this.Properties == input.Properties ||
                    this.Properties != null &&
                    input.Properties != null &&
                    this.Properties.SequenceEqual(input.Properties)
                ) && 
                (
                    this.Options == input.Options ||
                    this.Options != null &&
                    input.Options != null &&
                    this.Options.SequenceEqual(input.Options)
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
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                hashCode = hashCode * 59 + this.VersionPolicy.GetHashCode();
                if (this.Content != null)
                    hashCode = hashCode * 59 + this.Content.GetHashCode();
                if (this.Method != null)
                    hashCode = hashCode * 59 + this.Method.GetHashCode();
                if (this.RequestUri != null)
                    hashCode = hashCode * 59 + this.RequestUri.GetHashCode();
                if (this.Headers != null)
                    hashCode = hashCode * 59 + this.Headers.GetHashCode();
                if (this.Properties != null)
                    hashCode = hashCode * 59 + this.Properties.GetHashCode();
                if (this.Options != null)
                    hashCode = hashCode * 59 + this.Options.GetHashCode();
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
