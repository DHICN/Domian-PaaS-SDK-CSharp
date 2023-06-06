/* 
 * scenario-compute-service
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
using OpenAPIDateConverter = DHICN.PAAS.SDK.ScenarioCompute.Client.OpenAPIDateConverter;

namespace DHICN.PAAS.SDK.ScenarioCompute.Model
{
    /// <summary>
    /// DhiDssScenarioComputeRfDtosCreateFloodStorageAreaScenarioInput
    /// </summary>
    [DataContract]
    public partial class DhiDssScenarioComputeRfDtosCreateFloodStorageAreaScenarioInput :  IEquatable<DhiDssScenarioComputeRfDtosCreateFloodStorageAreaScenarioInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DhiDssScenarioComputeRfDtosCreateFloodStorageAreaScenarioInput" /> class.
        /// </summary>
        /// <param name="scheduleScenarioId">River flood schedule scenario id.</param>
        /// <param name="floodStorageAreaId">Flood storage area id.</param>
        /// <param name="name">Scenario name.</param>
        /// <param name="initialWL">Initial water level of the flood storage area.</param>
        /// <param name="description">Scenario description.</param>
        public DhiDssScenarioComputeRfDtosCreateFloodStorageAreaScenarioInput(Guid scheduleScenarioId = default(Guid), Guid floodStorageAreaId = default(Guid), string name = default(string), double initialWL = default(double), string description = default(string))
        {
            this.ScheduleScenarioId = scheduleScenarioId;
            this.FloodStorageAreaId = floodStorageAreaId;
            this.Name = name;
            this.InitialWL = initialWL;
            this.Description = description;
        }
        
        /// <summary>
        /// River flood schedule scenario id
        /// </summary>
        /// <value>River flood schedule scenario id</value>
        [DataMember(Name="scheduleScenarioId", EmitDefaultValue=false)]
        public Guid ScheduleScenarioId { get; set; }

        /// <summary>
        /// Flood storage area id
        /// </summary>
        /// <value>Flood storage area id</value>
        [DataMember(Name="floodStorageAreaId", EmitDefaultValue=false)]
        public Guid FloodStorageAreaId { get; set; }

        /// <summary>
        /// Scenario name
        /// </summary>
        /// <value>Scenario name</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Initial water level of the flood storage area
        /// </summary>
        /// <value>Initial water level of the flood storage area</value>
        [DataMember(Name="initialWL", EmitDefaultValue=false)]
        public double InitialWL { get; set; }

        /// <summary>
        /// Scenario description
        /// </summary>
        /// <value>Scenario description</value>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DhiDssScenarioComputeRfDtosCreateFloodStorageAreaScenarioInput {\n");
            sb.Append("  ScheduleScenarioId: ").Append(ScheduleScenarioId).Append("\n");
            sb.Append("  FloodStorageAreaId: ").Append(FloodStorageAreaId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  InitialWL: ").Append(InitialWL).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return this.Equals(input as DhiDssScenarioComputeRfDtosCreateFloodStorageAreaScenarioInput);
        }

        /// <summary>
        /// Returns true if DhiDssScenarioComputeRfDtosCreateFloodStorageAreaScenarioInput instances are equal
        /// </summary>
        /// <param name="input">Instance of DhiDssScenarioComputeRfDtosCreateFloodStorageAreaScenarioInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DhiDssScenarioComputeRfDtosCreateFloodStorageAreaScenarioInput input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ScheduleScenarioId == input.ScheduleScenarioId ||
                    (this.ScheduleScenarioId != null &&
                    this.ScheduleScenarioId.Equals(input.ScheduleScenarioId))
                ) && 
                (
                    this.FloodStorageAreaId == input.FloodStorageAreaId ||
                    (this.FloodStorageAreaId != null &&
                    this.FloodStorageAreaId.Equals(input.FloodStorageAreaId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.InitialWL == input.InitialWL ||
                    this.InitialWL.Equals(input.InitialWL)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                if (this.ScheduleScenarioId != null)
                    hashCode = hashCode * 59 + this.ScheduleScenarioId.GetHashCode();
                if (this.FloodStorageAreaId != null)
                    hashCode = hashCode * 59 + this.FloodStorageAreaId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.InitialWL.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
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
