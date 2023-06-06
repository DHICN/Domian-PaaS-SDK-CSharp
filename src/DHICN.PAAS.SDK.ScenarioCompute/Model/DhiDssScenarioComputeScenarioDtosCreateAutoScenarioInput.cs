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
    /// DhiDssScenarioComputeScenarioDtosCreateAutoScenarioInput
    /// </summary>
    [DataContract]
    public partial class DhiDssScenarioComputeScenarioDtosCreateAutoScenarioInput :  IEquatable<DhiDssScenarioComputeScenarioDtosCreateAutoScenarioInput>, IValidatableObject
    {
        /// <summary>
        /// 0-Undefined(Undefined) 1-AutoForecast(Auto forecast library) 2-ManualForecast(Manual forecast library) 3-Forecast(Forecast library) 4-Schedule(Schedule library) 5-Experience(Experience library) 6-ScenarioSimulation(Scenario simulation library) 7-WQAccident(Water quality accident library) 8-OnlineHD(WD Hydrodynamic library) 9-WaterHammer(WD water hammer library) 10-Filling(WD pipe filling library) 11-PipeBurst(WD pipe burst library) 12-WQResponse(Water quality accident response library) 13-Planning(WD planning library) 14-Flushing(WD flushing library) 15-OnlineWQAccident(Online Water quality accident library) 16-CloseValve(WD close valve library) 
        /// </summary>
        /// <value>0-Undefined(Undefined) 1-AutoForecast(Auto forecast library) 2-ManualForecast(Manual forecast library) 3-Forecast(Forecast library) 4-Schedule(Schedule library) 5-Experience(Experience library) 6-ScenarioSimulation(Scenario simulation library) 7-WQAccident(Water quality accident library) 8-OnlineHD(WD Hydrodynamic library) 9-WaterHammer(WD water hammer library) 10-Filling(WD pipe filling library) 11-PipeBurst(WD pipe burst library) 12-WQResponse(Water quality accident response library) 13-Planning(WD planning library) 14-Flushing(WD flushing library) 15-OnlineWQAccident(Online Water quality accident library) 16-CloseValve(WD close valve library) </value>
        public enum LibraryTypeEnum
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
            NUMBER_2 = 2,

            /// <summary>
            /// Enum NUMBER_3 for value: 3
            /// </summary>
            NUMBER_3 = 3,

            /// <summary>
            /// Enum NUMBER_4 for value: 4
            /// </summary>
            NUMBER_4 = 4,

            /// <summary>
            /// Enum NUMBER_5 for value: 5
            /// </summary>
            NUMBER_5 = 5,

            /// <summary>
            /// Enum NUMBER_6 for value: 6
            /// </summary>
            NUMBER_6 = 6,

            /// <summary>
            /// Enum NUMBER_7 for value: 7
            /// </summary>
            NUMBER_7 = 7,

            /// <summary>
            /// Enum NUMBER_8 for value: 8
            /// </summary>
            NUMBER_8 = 8,

            /// <summary>
            /// Enum NUMBER_9 for value: 9
            /// </summary>
            NUMBER_9 = 9,

            /// <summary>
            /// Enum NUMBER_10 for value: 10
            /// </summary>
            NUMBER_10 = 10,

            /// <summary>
            /// Enum NUMBER_11 for value: 11
            /// </summary>
            NUMBER_11 = 11,

            /// <summary>
            /// Enum NUMBER_12 for value: 12
            /// </summary>
            NUMBER_12 = 12,

            /// <summary>
            /// Enum NUMBER_13 for value: 13
            /// </summary>
            NUMBER_13 = 13,

            /// <summary>
            /// Enum NUMBER_14 for value: 14
            /// </summary>
            NUMBER_14 = 14,

            /// <summary>
            /// Enum NUMBER_15 for value: 15
            /// </summary>
            NUMBER_15 = 15,

            /// <summary>
            /// Enum NUMBER_16 for value: 16
            /// </summary>
            NUMBER_16 = 16

        }

        /// <summary>
        /// 0-Undefined(Undefined) 1-AutoForecast(Auto forecast library) 2-ManualForecast(Manual forecast library) 3-Forecast(Forecast library) 4-Schedule(Schedule library) 5-Experience(Experience library) 6-ScenarioSimulation(Scenario simulation library) 7-WQAccident(Water quality accident library) 8-OnlineHD(WD Hydrodynamic library) 9-WaterHammer(WD water hammer library) 10-Filling(WD pipe filling library) 11-PipeBurst(WD pipe burst library) 12-WQResponse(Water quality accident response library) 13-Planning(WD planning library) 14-Flushing(WD flushing library) 15-OnlineWQAccident(Online Water quality accident library) 16-CloseValve(WD close valve library) 
        /// </summary>
        /// <value>0-Undefined(Undefined) 1-AutoForecast(Auto forecast library) 2-ManualForecast(Manual forecast library) 3-Forecast(Forecast library) 4-Schedule(Schedule library) 5-Experience(Experience library) 6-ScenarioSimulation(Scenario simulation library) 7-WQAccident(Water quality accident library) 8-OnlineHD(WD Hydrodynamic library) 9-WaterHammer(WD water hammer library) 10-Filling(WD pipe filling library) 11-PipeBurst(WD pipe burst library) 12-WQResponse(Water quality accident response library) 13-Planning(WD planning library) 14-Flushing(WD flushing library) 15-OnlineWQAccident(Online Water quality accident library) 16-CloseValve(WD close valve library) </value>
        [DataMember(Name="libraryType", EmitDefaultValue=false)]
        public LibraryTypeEnum? LibraryType { get; set; }
        /// <summary>
        /// 0-Undefined(Undefined) 1-WaterEnvironment(Water environment) 2-UrbanFlooding(Urban flooding) 3-UrbanWD(Water distribution) 4-RiverFlood(River flood) 
        /// </summary>
        /// <value>0-Undefined(Undefined) 1-WaterEnvironment(Water environment) 2-UrbanFlooding(Urban flooding) 3-UrbanWD(Water distribution) 4-RiverFlood(River flood) </value>
        public enum BusinessTypeEnum
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
            NUMBER_2 = 2,

            /// <summary>
            /// Enum NUMBER_3 for value: 3
            /// </summary>
            NUMBER_3 = 3,

            /// <summary>
            /// Enum NUMBER_4 for value: 4
            /// </summary>
            NUMBER_4 = 4

        }

        /// <summary>
        /// 0-Undefined(Undefined) 1-WaterEnvironment(Water environment) 2-UrbanFlooding(Urban flooding) 3-UrbanWD(Water distribution) 4-RiverFlood(River flood) 
        /// </summary>
        /// <value>0-Undefined(Undefined) 1-WaterEnvironment(Water environment) 2-UrbanFlooding(Urban flooding) 3-UrbanWD(Water distribution) 4-RiverFlood(River flood) </value>
        [DataMember(Name="businessType", EmitDefaultValue=false)]
        public BusinessTypeEnum? BusinessType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DhiDssScenarioComputeScenarioDtosCreateAutoScenarioInput" /> class.
        /// </summary>
        /// <param name="libraryType">0-Undefined(Undefined) 1-AutoForecast(Auto forecast library) 2-ManualForecast(Manual forecast library) 3-Forecast(Forecast library) 4-Schedule(Schedule library) 5-Experience(Experience library) 6-ScenarioSimulation(Scenario simulation library) 7-WQAccident(Water quality accident library) 8-OnlineHD(WD Hydrodynamic library) 9-WaterHammer(WD water hammer library) 10-Filling(WD pipe filling library) 11-PipeBurst(WD pipe burst library) 12-WQResponse(Water quality accident response library) 13-Planning(WD planning library) 14-Flushing(WD flushing library) 15-OnlineWQAccident(Online Water quality accident library) 16-CloseValve(WD close valve library) .</param>
        /// <param name="businessType">0-Undefined(Undefined) 1-WaterEnvironment(Water environment) 2-UrbanFlooding(Urban flooding) 3-UrbanWD(Water distribution) 4-RiverFlood(River flood) .</param>
        public DhiDssScenarioComputeScenarioDtosCreateAutoScenarioInput(LibraryTypeEnum? libraryType = default(LibraryTypeEnum?), BusinessTypeEnum? businessType = default(BusinessTypeEnum?))
        {
            this.LibraryType = libraryType;
            this.BusinessType = businessType;
        }
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DhiDssScenarioComputeScenarioDtosCreateAutoScenarioInput {\n");
            sb.Append("  LibraryType: ").Append(LibraryType).Append("\n");
            sb.Append("  BusinessType: ").Append(BusinessType).Append("\n");
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
            return this.Equals(input as DhiDssScenarioComputeScenarioDtosCreateAutoScenarioInput);
        }

        /// <summary>
        /// Returns true if DhiDssScenarioComputeScenarioDtosCreateAutoScenarioInput instances are equal
        /// </summary>
        /// <param name="input">Instance of DhiDssScenarioComputeScenarioDtosCreateAutoScenarioInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DhiDssScenarioComputeScenarioDtosCreateAutoScenarioInput input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LibraryType == input.LibraryType ||
                    this.LibraryType.Equals(input.LibraryType)
                ) && 
                (
                    this.BusinessType == input.BusinessType ||
                    this.BusinessType.Equals(input.BusinessType)
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
                hashCode = hashCode * 59 + this.LibraryType.GetHashCode();
                hashCode = hashCode * 59 + this.BusinessType.GetHashCode();
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
