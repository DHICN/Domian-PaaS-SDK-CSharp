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
    /// AddTankDto
    /// </summary>
    [DataContract]
    public partial class AddTankDto :  IEquatable<AddTankDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddTankDto" /> class.
        /// </summary>
        /// <param name="deviceId">设备ID device id.</param>
        /// <param name="muid">模型中水池ID tank muid.</param>
        /// <param name="elev">底高程 base elevation.</param>
        /// <param name="hgl">水头固定值 fixed HGL.</param>
        /// <param name="zoneID">分区ID zone id.</param>
        /// <param name="dataSource">数据源 data source.</param>
        /// <param name="description">描述 description.</param>
        /// <param name="wdTankHGLType">水池水头类型 HGL level type.</param>
        /// <param name="patternID">水头模式ID HGL pattern id.</param>
        /// <param name="wdTankMixing">水池混合的类型 tank mixing type.</param>
        /// <param name="initQualityConcentration">初始污染物浓度 initial chemical concentration.</param>
        /// <param name="reactionCoefficient">降解系数 reaction coefficient.</param>
        /// <param name="initQualityPercentage">初始污染物占比 initial source percentage.</param>
        /// <param name="iniQualityHour">初始水龄 initial water age.</param>
        /// <param name="componentValue">污染物体积 component volume.</param>
        /// <param name="coorStr">坐标值 coordinate.</param>
        /// <param name="createTime">创建时间 create time.</param>
        public AddTankDto(Guid deviceId = default(Guid), string muid = default(string), double elev = default(double), double hgl = default(double), string zoneID = default(string), string dataSource = default(string), string description = default(string), int wdTankHGLType = default(int), string patternID = default(string), int wdTankMixing = default(int), double initQualityConcentration = default(double), double reactionCoefficient = default(double), double initQualityPercentage = default(double), double iniQualityHour = default(double), double componentValue = default(double), string coorStr = default(string), DateTime createTime = default(DateTime))
        {
            this.DeviceId = deviceId;
            this.Muid = muid;
            this.Elev = elev;
            this.Hgl = hgl;
            this.ZoneID = zoneID;
            this.DataSource = dataSource;
            this.Description = description;
            this.WdTankHGLType = wdTankHGLType;
            this.PatternID = patternID;
            this.WdTankMixing = wdTankMixing;
            this.InitQualityConcentration = initQualityConcentration;
            this.ReactionCoefficient = reactionCoefficient;
            this.InitQualityPercentage = initQualityPercentage;
            this.IniQualityHour = iniQualityHour;
            this.ComponentValue = componentValue;
            this.CoorStr = coorStr;
            this.CreateTime = createTime;
        }
        
        /// <summary>
        /// 设备ID device id
        /// </summary>
        /// <value>设备ID device id</value>
        [DataMember(Name="deviceId", EmitDefaultValue=false)]
        public Guid DeviceId { get; set; }

        /// <summary>
        /// 模型中水池ID tank muid
        /// </summary>
        /// <value>模型中水池ID tank muid</value>
        [DataMember(Name="muid", EmitDefaultValue=true)]
        public string Muid { get; set; }

        /// <summary>
        /// 底高程 base elevation
        /// </summary>
        /// <value>底高程 base elevation</value>
        [DataMember(Name="elev", EmitDefaultValue=false)]
        public double Elev { get; set; }

        /// <summary>
        /// 水头固定值 fixed HGL
        /// </summary>
        /// <value>水头固定值 fixed HGL</value>
        [DataMember(Name="hgl", EmitDefaultValue=false)]
        public double Hgl { get; set; }

        /// <summary>
        /// 分区ID zone id
        /// </summary>
        /// <value>分区ID zone id</value>
        [DataMember(Name="zoneID", EmitDefaultValue=true)]
        public string ZoneID { get; set; }

        /// <summary>
        /// 数据源 data source
        /// </summary>
        /// <value>数据源 data source</value>
        [DataMember(Name="dataSource", EmitDefaultValue=true)]
        public string DataSource { get; set; }

        /// <summary>
        /// 描述 description
        /// </summary>
        /// <value>描述 description</value>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// 水池水头类型 HGL level type
        /// </summary>
        /// <value>水池水头类型 HGL level type</value>
        [DataMember(Name="wdTankHGLType", EmitDefaultValue=false)]
        public int WdTankHGLType { get; set; }

        /// <summary>
        /// 水头模式ID HGL pattern id
        /// </summary>
        /// <value>水头模式ID HGL pattern id</value>
        [DataMember(Name="patternID", EmitDefaultValue=true)]
        public string PatternID { get; set; }

        /// <summary>
        /// 水池混合的类型 tank mixing type
        /// </summary>
        /// <value>水池混合的类型 tank mixing type</value>
        [DataMember(Name="wdTankMixing", EmitDefaultValue=false)]
        public int WdTankMixing { get; set; }

        /// <summary>
        /// 初始污染物浓度 initial chemical concentration
        /// </summary>
        /// <value>初始污染物浓度 initial chemical concentration</value>
        [DataMember(Name="initQualityConcentration", EmitDefaultValue=false)]
        public double InitQualityConcentration { get; set; }

        /// <summary>
        /// 降解系数 reaction coefficient
        /// </summary>
        /// <value>降解系数 reaction coefficient</value>
        [DataMember(Name="reactionCoefficient", EmitDefaultValue=false)]
        public double ReactionCoefficient { get; set; }

        /// <summary>
        /// 初始污染物占比 initial source percentage
        /// </summary>
        /// <value>初始污染物占比 initial source percentage</value>
        [DataMember(Name="initQualityPercentage", EmitDefaultValue=false)]
        public double InitQualityPercentage { get; set; }

        /// <summary>
        /// 初始水龄 initial water age
        /// </summary>
        /// <value>初始水龄 initial water age</value>
        [DataMember(Name="iniQualityHour", EmitDefaultValue=false)]
        public double IniQualityHour { get; set; }

        /// <summary>
        /// 污染物体积 component volume
        /// </summary>
        /// <value>污染物体积 component volume</value>
        [DataMember(Name="componentValue", EmitDefaultValue=false)]
        public double ComponentValue { get; set; }

        /// <summary>
        /// 坐标值 coordinate
        /// </summary>
        /// <value>坐标值 coordinate</value>
        [DataMember(Name="coorStr", EmitDefaultValue=true)]
        public string CoorStr { get; set; }

        /// <summary>
        /// 创建时间 create time
        /// </summary>
        /// <value>创建时间 create time</value>
        [DataMember(Name="createTime", EmitDefaultValue=false)]
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddTankDto {\n");
            sb.Append("  DeviceId: ").Append(DeviceId).Append("\n");
            sb.Append("  Muid: ").Append(Muid).Append("\n");
            sb.Append("  Elev: ").Append(Elev).Append("\n");
            sb.Append("  Hgl: ").Append(Hgl).Append("\n");
            sb.Append("  ZoneID: ").Append(ZoneID).Append("\n");
            sb.Append("  DataSource: ").Append(DataSource).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  WdTankHGLType: ").Append(WdTankHGLType).Append("\n");
            sb.Append("  PatternID: ").Append(PatternID).Append("\n");
            sb.Append("  WdTankMixing: ").Append(WdTankMixing).Append("\n");
            sb.Append("  InitQualityConcentration: ").Append(InitQualityConcentration).Append("\n");
            sb.Append("  ReactionCoefficient: ").Append(ReactionCoefficient).Append("\n");
            sb.Append("  InitQualityPercentage: ").Append(InitQualityPercentage).Append("\n");
            sb.Append("  IniQualityHour: ").Append(IniQualityHour).Append("\n");
            sb.Append("  ComponentValue: ").Append(ComponentValue).Append("\n");
            sb.Append("  CoorStr: ").Append(CoorStr).Append("\n");
            sb.Append("  CreateTime: ").Append(CreateTime).Append("\n");
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
            return this.Equals(input as AddTankDto);
        }

        /// <summary>
        /// Returns true if AddTankDto instances are equal
        /// </summary>
        /// <param name="input">Instance of AddTankDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddTankDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DeviceId == input.DeviceId ||
                    (this.DeviceId != null &&
                    this.DeviceId.Equals(input.DeviceId))
                ) && 
                (
                    this.Muid == input.Muid ||
                    (this.Muid != null &&
                    this.Muid.Equals(input.Muid))
                ) && 
                (
                    this.Elev == input.Elev ||
                    this.Elev.Equals(input.Elev)
                ) && 
                (
                    this.Hgl == input.Hgl ||
                    this.Hgl.Equals(input.Hgl)
                ) && 
                (
                    this.ZoneID == input.ZoneID ||
                    (this.ZoneID != null &&
                    this.ZoneID.Equals(input.ZoneID))
                ) && 
                (
                    this.DataSource == input.DataSource ||
                    (this.DataSource != null &&
                    this.DataSource.Equals(input.DataSource))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.WdTankHGLType == input.WdTankHGLType ||
                    this.WdTankHGLType.Equals(input.WdTankHGLType)
                ) && 
                (
                    this.PatternID == input.PatternID ||
                    (this.PatternID != null &&
                    this.PatternID.Equals(input.PatternID))
                ) && 
                (
                    this.WdTankMixing == input.WdTankMixing ||
                    this.WdTankMixing.Equals(input.WdTankMixing)
                ) && 
                (
                    this.InitQualityConcentration == input.InitQualityConcentration ||
                    this.InitQualityConcentration.Equals(input.InitQualityConcentration)
                ) && 
                (
                    this.ReactionCoefficient == input.ReactionCoefficient ||
                    this.ReactionCoefficient.Equals(input.ReactionCoefficient)
                ) && 
                (
                    this.InitQualityPercentage == input.InitQualityPercentage ||
                    this.InitQualityPercentage.Equals(input.InitQualityPercentage)
                ) && 
                (
                    this.IniQualityHour == input.IniQualityHour ||
                    this.IniQualityHour.Equals(input.IniQualityHour)
                ) && 
                (
                    this.ComponentValue == input.ComponentValue ||
                    this.ComponentValue.Equals(input.ComponentValue)
                ) && 
                (
                    this.CoorStr == input.CoorStr ||
                    (this.CoorStr != null &&
                    this.CoorStr.Equals(input.CoorStr))
                ) && 
                (
                    this.CreateTime == input.CreateTime ||
                    (this.CreateTime != null &&
                    this.CreateTime.Equals(input.CreateTime))
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
                if (this.DeviceId != null)
                    hashCode = hashCode * 59 + this.DeviceId.GetHashCode();
                if (this.Muid != null)
                    hashCode = hashCode * 59 + this.Muid.GetHashCode();
                hashCode = hashCode * 59 + this.Elev.GetHashCode();
                hashCode = hashCode * 59 + this.Hgl.GetHashCode();
                if (this.ZoneID != null)
                    hashCode = hashCode * 59 + this.ZoneID.GetHashCode();
                if (this.DataSource != null)
                    hashCode = hashCode * 59 + this.DataSource.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                hashCode = hashCode * 59 + this.WdTankHGLType.GetHashCode();
                if (this.PatternID != null)
                    hashCode = hashCode * 59 + this.PatternID.GetHashCode();
                hashCode = hashCode * 59 + this.WdTankMixing.GetHashCode();
                hashCode = hashCode * 59 + this.InitQualityConcentration.GetHashCode();
                hashCode = hashCode * 59 + this.ReactionCoefficient.GetHashCode();
                hashCode = hashCode * 59 + this.InitQualityPercentage.GetHashCode();
                hashCode = hashCode * 59 + this.IniQualityHour.GetHashCode();
                hashCode = hashCode * 59 + this.ComponentValue.GetHashCode();
                if (this.CoorStr != null)
                    hashCode = hashCode * 59 + this.CoorStr.GetHashCode();
                if (this.CreateTime != null)
                    hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
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
