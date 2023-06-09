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
    /// OnlinePointConfig
    /// </summary>
    [DataContract]
    public partial class OnlinePointConfig :  IEquatable<OnlinePointConfig>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OnlinePointConfig" /> class.
        /// </summary>
        /// <param name="tenantId">tenantId.</param>
        /// <param name="pointCode">pointCode.</param>
        /// <param name="position">position.</param>
        /// <param name="pointName">pointName.</param>
        /// <param name="stationCode">stationCode.</param>
        /// <param name="unit">unit.</param>
        /// <param name="isKeyPoint">isKeyPoint.</param>
        /// <param name="isInput">isInput.</param>
        /// <param name="isUse">isUse.</param>
        /// <param name="defaultValue">defaultValue.</param>
        public OnlinePointConfig(Guid? tenantId = default(Guid?), string pointCode = default(string), string position = default(string), string pointName = default(string), string stationCode = default(string), string unit = default(string), bool isKeyPoint = default(bool), bool isInput = default(bool), bool isUse = default(bool), double defaultValue = default(double))
        {
            this.TenantId = tenantId;
            this.PointCode = pointCode;
            this.Position = position;
            this.PointName = pointName;
            this.StationCode = stationCode;
            this.Unit = unit;
            this.IsKeyPoint = isKeyPoint;
            this.IsInput = isInput;
            this.IsUse = isUse;
            this.DefaultValue = defaultValue;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid Id { get; private set; }

        /// <summary>
        /// Gets or Sets TenantId
        /// </summary>
        [DataMember(Name="tenantId", EmitDefaultValue=true)]
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Gets or Sets PointCode
        /// </summary>
        [DataMember(Name="pointCode", EmitDefaultValue=true)]
        public string PointCode { get; set; }

        /// <summary>
        /// Gets or Sets Position
        /// </summary>
        [DataMember(Name="position", EmitDefaultValue=true)]
        public string Position { get; set; }

        /// <summary>
        /// Gets or Sets PointName
        /// </summary>
        [DataMember(Name="pointName", EmitDefaultValue=true)]
        public string PointName { get; set; }

        /// <summary>
        /// Gets or Sets StationCode
        /// </summary>
        [DataMember(Name="stationCode", EmitDefaultValue=true)]
        public string StationCode { get; set; }

        /// <summary>
        /// Gets or Sets Unit
        /// </summary>
        [DataMember(Name="unit", EmitDefaultValue=true)]
        public string Unit { get; set; }

        /// <summary>
        /// Gets or Sets IsKeyPoint
        /// </summary>
        [DataMember(Name="isKeyPoint", EmitDefaultValue=false)]
        public bool IsKeyPoint { get; set; }

        /// <summary>
        /// Gets or Sets IsInput
        /// </summary>
        [DataMember(Name="isInput", EmitDefaultValue=false)]
        public bool IsInput { get; set; }

        /// <summary>
        /// Gets or Sets IsUse
        /// </summary>
        [DataMember(Name="isUse", EmitDefaultValue=false)]
        public bool IsUse { get; set; }

        /// <summary>
        /// Gets or Sets DefaultValue
        /// </summary>
        [DataMember(Name="defaultValue", EmitDefaultValue=false)]
        public double DefaultValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OnlinePointConfig {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  PointCode: ").Append(PointCode).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  PointName: ").Append(PointName).Append("\n");
            sb.Append("  StationCode: ").Append(StationCode).Append("\n");
            sb.Append("  Unit: ").Append(Unit).Append("\n");
            sb.Append("  IsKeyPoint: ").Append(IsKeyPoint).Append("\n");
            sb.Append("  IsInput: ").Append(IsInput).Append("\n");
            sb.Append("  IsUse: ").Append(IsUse).Append("\n");
            sb.Append("  DefaultValue: ").Append(DefaultValue).Append("\n");
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
            return this.Equals(input as OnlinePointConfig);
        }

        /// <summary>
        /// Returns true if OnlinePointConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of OnlinePointConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OnlinePointConfig input)
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
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
                ) && 
                (
                    this.PointCode == input.PointCode ||
                    (this.PointCode != null &&
                    this.PointCode.Equals(input.PointCode))
                ) && 
                (
                    this.Position == input.Position ||
                    (this.Position != null &&
                    this.Position.Equals(input.Position))
                ) && 
                (
                    this.PointName == input.PointName ||
                    (this.PointName != null &&
                    this.PointName.Equals(input.PointName))
                ) && 
                (
                    this.StationCode == input.StationCode ||
                    (this.StationCode != null &&
                    this.StationCode.Equals(input.StationCode))
                ) && 
                (
                    this.Unit == input.Unit ||
                    (this.Unit != null &&
                    this.Unit.Equals(input.Unit))
                ) && 
                (
                    this.IsKeyPoint == input.IsKeyPoint ||
                    this.IsKeyPoint.Equals(input.IsKeyPoint)
                ) && 
                (
                    this.IsInput == input.IsInput ||
                    this.IsInput.Equals(input.IsInput)
                ) && 
                (
                    this.IsUse == input.IsUse ||
                    this.IsUse.Equals(input.IsUse)
                ) && 
                (
                    this.DefaultValue == input.DefaultValue ||
                    this.DefaultValue.Equals(input.DefaultValue)
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
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.PointCode != null)
                    hashCode = hashCode * 59 + this.PointCode.GetHashCode();
                if (this.Position != null)
                    hashCode = hashCode * 59 + this.Position.GetHashCode();
                if (this.PointName != null)
                    hashCode = hashCode * 59 + this.PointName.GetHashCode();
                if (this.StationCode != null)
                    hashCode = hashCode * 59 + this.StationCode.GetHashCode();
                if (this.Unit != null)
                    hashCode = hashCode * 59 + this.Unit.GetHashCode();
                hashCode = hashCode * 59 + this.IsKeyPoint.GetHashCode();
                hashCode = hashCode * 59 + this.IsInput.GetHashCode();
                hashCode = hashCode * 59 + this.IsUse.GetHashCode();
                hashCode = hashCode * 59 + this.DefaultValue.GetHashCode();
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
