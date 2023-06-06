/* 
 * message-center-service
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
using OpenAPIDateConverter = DHICN.PAAS.SDK.Message.Center.Client.OpenAPIDateConverter;

namespace DHICN.PAAS.SDK.Message.Center.Model
{
    /// <summary>
    /// SaveClientInput
    /// </summary>
    [DataContract]
    public partial class SaveClientInput :  IEquatable<SaveClientInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SaveClientInput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SaveClientInput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SaveClientInput" /> class.
        /// </summary>
        /// <param name="appId">应用Id (required).</param>
        /// <param name="clientId">客户端Id (required).</param>
        /// <param name="deviceId">设备Id.</param>
        /// <param name="deviceType">设备类型.</param>
        /// <param name="romName">系统.</param>
        public SaveClientInput(string appId = default(string), string clientId = default(string), string deviceId = default(string), string deviceType = default(string), string romName = default(string))
        {
            // to ensure "appId" is required (not null)
            this.AppId = appId ?? throw new ArgumentNullException("appId is a required property for SaveClientInput and cannot be null");
            // to ensure "clientId" is required (not null)
            this.ClientId = clientId ?? throw new ArgumentNullException("clientId is a required property for SaveClientInput and cannot be null");
            this.DeviceId = deviceId;
            this.DeviceType = deviceType;
            this.RomName = romName;
        }
        
        /// <summary>
        /// 应用Id
        /// </summary>
        /// <value>应用Id</value>
        [DataMember(Name="appId", EmitDefaultValue=false)]
        public string AppId { get; set; }

        /// <summary>
        /// 客户端Id
        /// </summary>
        /// <value>客户端Id</value>
        [DataMember(Name="clientId", EmitDefaultValue=false)]
        public string ClientId { get; set; }

        /// <summary>
        /// 设备Id
        /// </summary>
        /// <value>设备Id</value>
        [DataMember(Name="deviceId", EmitDefaultValue=true)]
        public string DeviceId { get; set; }

        /// <summary>
        /// 设备类型
        /// </summary>
        /// <value>设备类型</value>
        [DataMember(Name="deviceType", EmitDefaultValue=true)]
        public string DeviceType { get; set; }

        /// <summary>
        /// 系统
        /// </summary>
        /// <value>系统</value>
        [DataMember(Name="romName", EmitDefaultValue=true)]
        public string RomName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SaveClientInput {\n");
            sb.Append("  AppId: ").Append(AppId).Append("\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  DeviceId: ").Append(DeviceId).Append("\n");
            sb.Append("  DeviceType: ").Append(DeviceType).Append("\n");
            sb.Append("  RomName: ").Append(RomName).Append("\n");
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
            return this.Equals(input as SaveClientInput);
        }

        /// <summary>
        /// Returns true if SaveClientInput instances are equal
        /// </summary>
        /// <param name="input">Instance of SaveClientInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SaveClientInput input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AppId == input.AppId ||
                    (this.AppId != null &&
                    this.AppId.Equals(input.AppId))
                ) && 
                (
                    this.ClientId == input.ClientId ||
                    (this.ClientId != null &&
                    this.ClientId.Equals(input.ClientId))
                ) && 
                (
                    this.DeviceId == input.DeviceId ||
                    (this.DeviceId != null &&
                    this.DeviceId.Equals(input.DeviceId))
                ) && 
                (
                    this.DeviceType == input.DeviceType ||
                    (this.DeviceType != null &&
                    this.DeviceType.Equals(input.DeviceType))
                ) && 
                (
                    this.RomName == input.RomName ||
                    (this.RomName != null &&
                    this.RomName.Equals(input.RomName))
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
                if (this.AppId != null)
                    hashCode = hashCode * 59 + this.AppId.GetHashCode();
                if (this.ClientId != null)
                    hashCode = hashCode * 59 + this.ClientId.GetHashCode();
                if (this.DeviceId != null)
                    hashCode = hashCode * 59 + this.DeviceId.GetHashCode();
                if (this.DeviceType != null)
                    hashCode = hashCode * 59 + this.DeviceType.GetHashCode();
                if (this.RomName != null)
                    hashCode = hashCode * 59 + this.RomName.GetHashCode();
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
            // AppId (string) minLength
            if(this.AppId != null && this.AppId.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AppId, length must be greater than 1.", new [] { "AppId" });
            }

  
            // ClientId (string) minLength
            if(this.ClientId != null && this.ClientId.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ClientId, length must be greater than 1.", new [] { "ClientId" });
            }

  
            yield break;
        }
    }

}
