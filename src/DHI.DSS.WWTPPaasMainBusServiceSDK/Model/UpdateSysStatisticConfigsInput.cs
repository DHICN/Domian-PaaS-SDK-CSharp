/* 
 * wwtp-paas-main-bus-service
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
using OpenAPIDateConverter = DHI.DSS.WWTPPaasMainBusServiceSDK.Client.OpenAPIDateConverter;

namespace DHI.DSS.WWTPPaasMainBusServiceSDK.Model
{
    /// <summary>
    /// UpdateSysStatisticConfigsInput
    /// </summary>
    [DataContract]
    public partial class UpdateSysStatisticConfigsInput :  IEquatable<UpdateSysStatisticConfigsInput>, IValidatableObject
    {
        /// <summary>
        /// 统计类型 statistic type
        /// </summary>
        /// <value>统计类型 statistic type</value>
        public enum StatisticTypeEnum
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
            NUMBER_2 = 2

        }

        /// <summary>
        /// 统计类型 statistic type
        /// </summary>
        /// <value>统计类型 statistic type</value>
        [DataMember(Name="statisticType", EmitDefaultValue=false)]
        public StatisticTypeEnum StatisticType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSysStatisticConfigsInput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateSysStatisticConfigsInput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSysStatisticConfigsInput" /> class.
        /// </summary>
        /// <param name="statisticCode">统计编码 statistic code (required).</param>
        /// <param name="statisticName">统计名称 statistic name (required).</param>
        /// <param name="statisticType">统计类型 statistic type (required).</param>
        /// <param name="statisticVarRefInfo">statisticVarRefInfo (required).</param>
        /// <param name="isDisplay">是否展示该条统计信息 if display on the front end (required).</param>
        /// <param name="unit">单位 unit.</param>
        /// <param name="groupName">统计分组 statistic group.</param>
        /// <param name="id">配置ID config id (required).</param>
        public UpdateSysStatisticConfigsInput(string statisticCode = default(string), string statisticName = default(string), StatisticTypeEnum statisticType = default(StatisticTypeEnum), StatisticVarRefDto statisticVarRefInfo = default(StatisticVarRefDto), bool isDisplay = default(bool), string unit = default(string), string groupName = default(string), Guid id = default(Guid))
        {
            // to ensure "statisticCode" is required (not null)
            this.StatisticCode = statisticCode ?? throw new ArgumentNullException("statisticCode is a required property for UpdateSysStatisticConfigsInput and cannot be null");
            // to ensure "statisticName" is required (not null)
            this.StatisticName = statisticName ?? throw new ArgumentNullException("statisticName is a required property for UpdateSysStatisticConfigsInput and cannot be null");
            this.StatisticType = statisticType;
            // to ensure "statisticVarRefInfo" is required (not null)
            this.StatisticVarRefInfo = statisticVarRefInfo ?? throw new ArgumentNullException("statisticVarRefInfo is a required property for UpdateSysStatisticConfigsInput and cannot be null");
            this.IsDisplay = isDisplay;
            this.Id = id;
            this.Unit = unit;
            this.GroupName = groupName;
        }
        
        /// <summary>
        /// 统计编码 statistic code
        /// </summary>
        /// <value>统计编码 statistic code</value>
        [DataMember(Name="statisticCode", EmitDefaultValue=false)]
        public string StatisticCode { get; set; }

        /// <summary>
        /// 统计名称 statistic name
        /// </summary>
        /// <value>统计名称 statistic name</value>
        [DataMember(Name="statisticName", EmitDefaultValue=false)]
        public string StatisticName { get; set; }

        /// <summary>
        /// Gets or Sets StatisticVarRefInfo
        /// </summary>
        [DataMember(Name="statisticVarRefInfo", EmitDefaultValue=false)]
        public StatisticVarRefDto StatisticVarRefInfo { get; set; }

        /// <summary>
        /// 是否展示该条统计信息 if display on the front end
        /// </summary>
        /// <value>是否展示该条统计信息 if display on the front end</value>
        [DataMember(Name="isDisplay", EmitDefaultValue=false)]
        public bool IsDisplay { get; set; }

        /// <summary>
        /// 单位 unit
        /// </summary>
        /// <value>单位 unit</value>
        [DataMember(Name="unit", EmitDefaultValue=true)]
        public string Unit { get; set; }

        /// <summary>
        /// 统计分组 statistic group
        /// </summary>
        /// <value>统计分组 statistic group</value>
        [DataMember(Name="groupName", EmitDefaultValue=true)]
        public string GroupName { get; set; }

        /// <summary>
        /// 配置ID config id
        /// </summary>
        /// <value>配置ID config id</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateSysStatisticConfigsInput {\n");
            sb.Append("  StatisticCode: ").Append(StatisticCode).Append("\n");
            sb.Append("  StatisticName: ").Append(StatisticName).Append("\n");
            sb.Append("  StatisticType: ").Append(StatisticType).Append("\n");
            sb.Append("  StatisticVarRefInfo: ").Append(StatisticVarRefInfo).Append("\n");
            sb.Append("  IsDisplay: ").Append(IsDisplay).Append("\n");
            sb.Append("  Unit: ").Append(Unit).Append("\n");
            sb.Append("  GroupName: ").Append(GroupName).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(input as UpdateSysStatisticConfigsInput);
        }

        /// <summary>
        /// Returns true if UpdateSysStatisticConfigsInput instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateSysStatisticConfigsInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateSysStatisticConfigsInput input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StatisticCode == input.StatisticCode ||
                    (this.StatisticCode != null &&
                    this.StatisticCode.Equals(input.StatisticCode))
                ) && 
                (
                    this.StatisticName == input.StatisticName ||
                    (this.StatisticName != null &&
                    this.StatisticName.Equals(input.StatisticName))
                ) && 
                (
                    this.StatisticType == input.StatisticType ||
                    this.StatisticType.Equals(input.StatisticType)
                ) && 
                (
                    this.StatisticVarRefInfo == input.StatisticVarRefInfo ||
                    (this.StatisticVarRefInfo != null &&
                    this.StatisticVarRefInfo.Equals(input.StatisticVarRefInfo))
                ) && 
                (
                    this.IsDisplay == input.IsDisplay ||
                    this.IsDisplay.Equals(input.IsDisplay)
                ) && 
                (
                    this.Unit == input.Unit ||
                    (this.Unit != null &&
                    this.Unit.Equals(input.Unit))
                ) && 
                (
                    this.GroupName == input.GroupName ||
                    (this.GroupName != null &&
                    this.GroupName.Equals(input.GroupName))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                if (this.StatisticCode != null)
                    hashCode = hashCode * 59 + this.StatisticCode.GetHashCode();
                if (this.StatisticName != null)
                    hashCode = hashCode * 59 + this.StatisticName.GetHashCode();
                hashCode = hashCode * 59 + this.StatisticType.GetHashCode();
                if (this.StatisticVarRefInfo != null)
                    hashCode = hashCode * 59 + this.StatisticVarRefInfo.GetHashCode();
                hashCode = hashCode * 59 + this.IsDisplay.GetHashCode();
                if (this.Unit != null)
                    hashCode = hashCode * 59 + this.Unit.GetHashCode();
                if (this.GroupName != null)
                    hashCode = hashCode * 59 + this.GroupName.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
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
