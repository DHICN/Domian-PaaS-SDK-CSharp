/* 
 * wwtp-paas-infrastructure-service
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
using OpenAPIDateConverter = DHICN.PAAS.SDK.WWTP.Infrastrcuture.Client.OpenAPIDateConverter;

namespace DHICN.PAAS.SDK.WWTP.Infrastrcuture.Model
{
    /// <summary>
    /// InsertOnlineProcessedDatasInput
    /// </summary>
    [DataContract]
    public partial class InsertOnlineProcessedDatasInput :  IEquatable<InsertOnlineProcessedDatasInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InsertOnlineProcessedDatasInput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InsertOnlineProcessedDatasInput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InsertOnlineProcessedDatasInput" /> class.
        /// </summary>
        /// <param name="time">时间 time (required).</param>
        /// <param name="pointCode">在线点位代码 online point code (required).</param>
        /// <param name="value">清洗后的值 cleaned value (required).</param>
        /// <param name="tag">清洗标签 clean tag.</param>
        /// <param name="tenantId">租户ID tenant id.</param>
        public InsertOnlineProcessedDatasInput(string time = default(string), string pointCode = default(string), double value = default(double), string tag = default(string), Guid? tenantId = default(Guid?))
        {
            // to ensure "time" is required (not null)
            this.Time = time ?? throw new ArgumentNullException("time is a required property for InsertOnlineProcessedDatasInput and cannot be null");
            // to ensure "pointCode" is required (not null)
            this.PointCode = pointCode ?? throw new ArgumentNullException("pointCode is a required property for InsertOnlineProcessedDatasInput and cannot be null");
            this.Value = value;
            this.Tag = tag;
            this.TenantId = tenantId;
        }
        
        /// <summary>
        /// 时间 time
        /// </summary>
        /// <value>时间 time</value>
        [DataMember(Name="time", EmitDefaultValue=false)]
        public string Time { get; set; }

        /// <summary>
        /// 在线点位代码 online point code
        /// </summary>
        /// <value>在线点位代码 online point code</value>
        [DataMember(Name="pointCode", EmitDefaultValue=false)]
        public string PointCode { get; set; }

        /// <summary>
        /// 清洗后的值 cleaned value
        /// </summary>
        /// <value>清洗后的值 cleaned value</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public double Value { get; set; }

        /// <summary>
        /// 清洗标签 clean tag
        /// </summary>
        /// <value>清洗标签 clean tag</value>
        [DataMember(Name="tag", EmitDefaultValue=true)]
        public string Tag { get; set; }

        /// <summary>
        /// 租户ID tenant id
        /// </summary>
        /// <value>租户ID tenant id</value>
        [DataMember(Name="tenantId", EmitDefaultValue=true)]
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InsertOnlineProcessedDatasInput {\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  PointCode: ").Append(PointCode).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Tag: ").Append(Tag).Append("\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
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
            return this.Equals(input as InsertOnlineProcessedDatasInput);
        }

        /// <summary>
        /// Returns true if InsertOnlineProcessedDatasInput instances are equal
        /// </summary>
        /// <param name="input">Instance of InsertOnlineProcessedDatasInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InsertOnlineProcessedDatasInput input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Time == input.Time ||
                    (this.Time != null &&
                    this.Time.Equals(input.Time))
                ) && 
                (
                    this.PointCode == input.PointCode ||
                    (this.PointCode != null &&
                    this.PointCode.Equals(input.PointCode))
                ) && 
                (
                    this.Value == input.Value ||
                    this.Value.Equals(input.Value)
                ) && 
                (
                    this.Tag == input.Tag ||
                    (this.Tag != null &&
                    this.Tag.Equals(input.Tag))
                ) && 
                (
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
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
                if (this.Time != null)
                    hashCode = hashCode * 59 + this.Time.GetHashCode();
                if (this.PointCode != null)
                    hashCode = hashCode * 59 + this.PointCode.GetHashCode();
                hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.Tag != null)
                    hashCode = hashCode * 59 + this.Tag.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
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
