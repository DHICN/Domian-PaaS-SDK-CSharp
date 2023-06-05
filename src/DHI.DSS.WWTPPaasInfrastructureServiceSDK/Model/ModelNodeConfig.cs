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
using OpenAPIDateConverter = DHI.DSS.WWTPPaasInfrastructureServiceSDK.Client.OpenAPIDateConverter;

namespace DHI.DSS.WWTPPaasInfrastructureServiceSDK.Model
{
    /// <summary>
    /// ModelNodeConfig
    /// </summary>
    [DataContract]
    public partial class ModelNodeConfig :  IEquatable<ModelNodeConfig>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelNodeConfig" /> class.
        /// </summary>
        /// <param name="tenantId">tenantId.</param>
        /// <param name="nodeCode">nodeCode.</param>
        /// <param name="nodeName">nodeName.</param>
        /// <param name="unit">unit.</param>
        /// <param name="dataType">dataType.</param>
        /// <param name="modelName">modelName.</param>
        public ModelNodeConfig(Guid? tenantId = default(Guid?), string nodeCode = default(string), string nodeName = default(string), string unit = default(string), string dataType = default(string), string modelName = default(string))
        {
            this.TenantId = tenantId;
            this.NodeCode = nodeCode;
            this.NodeName = nodeName;
            this.Unit = unit;
            this.DataType = dataType;
            this.ModelName = modelName;
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
        /// Gets or Sets NodeCode
        /// </summary>
        [DataMember(Name="nodeCode", EmitDefaultValue=true)]
        public string NodeCode { get; set; }

        /// <summary>
        /// Gets or Sets NodeName
        /// </summary>
        [DataMember(Name="nodeName", EmitDefaultValue=true)]
        public string NodeName { get; set; }

        /// <summary>
        /// Gets or Sets Unit
        /// </summary>
        [DataMember(Name="unit", EmitDefaultValue=true)]
        public string Unit { get; set; }

        /// <summary>
        /// Gets or Sets DataType
        /// </summary>
        [DataMember(Name="dataType", EmitDefaultValue=true)]
        public string DataType { get; set; }

        /// <summary>
        /// Gets or Sets ModelName
        /// </summary>
        [DataMember(Name="modelName", EmitDefaultValue=true)]
        public string ModelName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModelNodeConfig {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  NodeCode: ").Append(NodeCode).Append("\n");
            sb.Append("  NodeName: ").Append(NodeName).Append("\n");
            sb.Append("  Unit: ").Append(Unit).Append("\n");
            sb.Append("  DataType: ").Append(DataType).Append("\n");
            sb.Append("  ModelName: ").Append(ModelName).Append("\n");
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
            return this.Equals(input as ModelNodeConfig);
        }

        /// <summary>
        /// Returns true if ModelNodeConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of ModelNodeConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModelNodeConfig input)
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
                    this.NodeCode == input.NodeCode ||
                    (this.NodeCode != null &&
                    this.NodeCode.Equals(input.NodeCode))
                ) && 
                (
                    this.NodeName == input.NodeName ||
                    (this.NodeName != null &&
                    this.NodeName.Equals(input.NodeName))
                ) && 
                (
                    this.Unit == input.Unit ||
                    (this.Unit != null &&
                    this.Unit.Equals(input.Unit))
                ) && 
                (
                    this.DataType == input.DataType ||
                    (this.DataType != null &&
                    this.DataType.Equals(input.DataType))
                ) && 
                (
                    this.ModelName == input.ModelName ||
                    (this.ModelName != null &&
                    this.ModelName.Equals(input.ModelName))
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
                if (this.NodeCode != null)
                    hashCode = hashCode * 59 + this.NodeCode.GetHashCode();
                if (this.NodeName != null)
                    hashCode = hashCode * 59 + this.NodeName.GetHashCode();
                if (this.Unit != null)
                    hashCode = hashCode * 59 + this.Unit.GetHashCode();
                if (this.DataType != null)
                    hashCode = hashCode * 59 + this.DataType.GetHashCode();
                if (this.ModelName != null)
                    hashCode = hashCode * 59 + this.ModelName.GetHashCode();
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
