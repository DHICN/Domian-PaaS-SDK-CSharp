/* 
 * model-information-service
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
using OpenAPIDateConverter = DHICN.PAAS.SDK.ModelInformation.Client.OpenAPIDateConverter;

namespace DHICN.PAAS.SDK.ModelInformation.Model
{
    /// <summary>
    /// ModelProcessBoundaryConditionDocument
    /// </summary>
    [DataContract]
    public partial class ModelProcessBoundaryConditionDocument :  IEquatable<ModelProcessBoundaryConditionDocument>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelProcessBoundaryConditionDocument" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="scenarioID">scenarioID.</param>
        /// <param name="tenantId">tenantId.</param>
        /// <param name="boundaryCondition">boundaryCondition.</param>
        public ModelProcessBoundaryConditionDocument(Guid id = default(Guid), Guid scenarioID = default(Guid), Guid tenantId = default(Guid), BoundaryConditionJson boundaryCondition = default(BoundaryConditionJson))
        {
            this.Id = id;
            this.ScenarioID = scenarioID;
            this.TenantId = tenantId;
            this.BoundaryCondition = boundaryCondition;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets ScenarioID
        /// </summary>
        [DataMember(Name="scenarioID", EmitDefaultValue=false)]
        public Guid ScenarioID { get; set; }

        /// <summary>
        /// Gets or Sets TenantId
        /// </summary>
        [DataMember(Name="tenantId", EmitDefaultValue=false)]
        public Guid TenantId { get; set; }

        /// <summary>
        /// Gets or Sets BoundaryCondition
        /// </summary>
        [DataMember(Name="boundaryCondition", EmitDefaultValue=false)]
        public BoundaryConditionJson BoundaryCondition { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModelProcessBoundaryConditionDocument {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ScenarioID: ").Append(ScenarioID).Append("\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  BoundaryCondition: ").Append(BoundaryCondition).Append("\n");
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
            return this.Equals(input as ModelProcessBoundaryConditionDocument);
        }

        /// <summary>
        /// Returns true if ModelProcessBoundaryConditionDocument instances are equal
        /// </summary>
        /// <param name="input">Instance of ModelProcessBoundaryConditionDocument to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModelProcessBoundaryConditionDocument input)
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
                    this.ScenarioID == input.ScenarioID ||
                    (this.ScenarioID != null &&
                    this.ScenarioID.Equals(input.ScenarioID))
                ) && 
                (
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
                ) && 
                (
                    this.BoundaryCondition == input.BoundaryCondition ||
                    (this.BoundaryCondition != null &&
                    this.BoundaryCondition.Equals(input.BoundaryCondition))
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
                if (this.ScenarioID != null)
                    hashCode = hashCode * 59 + this.ScenarioID.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.BoundaryCondition != null)
                    hashCode = hashCode * 59 + this.BoundaryCondition.GetHashCode();
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
