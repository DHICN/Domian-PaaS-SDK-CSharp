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
    /// UpdatePumpDto
    /// </summary>
    [DataContract]
    public partial class UpdatePumpDto :  IEquatable<UpdatePumpDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePumpDto" /> class.
        /// </summary>
        /// <param name="muid">模型中泵站ID pump muid.</param>
        /// <param name="fromNode">起始节点 from node.</param>
        /// <param name="toNode">终止节点 to node.</param>
        /// <param name="pumpType">泵站类型 pump type.</param>
        /// <param name="speed">泵站速度 pump speed.</param>
        /// <param name="patternID">模式ID pattern id.</param>
        /// <param name="constantPower">泵站功率 pump constant power.</param>
        /// <param name="zoneID">分区ID zone id.</param>
        /// <param name="description">描述 description.</param>
        /// <param name="dataSource">数据源 data source.</param>
        /// <param name="assetName">资产名称 asset name.</param>
        /// <param name="fromX">起始节点坐标X coordinate x of from-node.</param>
        /// <param name="fromY">起始节点坐标Y coordinate y of from-node.</param>
        /// <param name="toX">终止节点坐标X coordinate x of to-node.</param>
        /// <param name="toY">终止节点坐标Y coordinate y of to-node.</param>
        /// <param name="id">泵站ID pump id.</param>
        public UpdatePumpDto(string muid = default(string), string fromNode = default(string), string toNode = default(string), int pumpType = default(int), double speed = default(double), string patternID = default(string), double constantPower = default(double), string zoneID = default(string), string description = default(string), string dataSource = default(string), string assetName = default(string), double fromX = default(double), double fromY = default(double), double toX = default(double), double toY = default(double), Guid id = default(Guid))
        {
            this.Muid = muid;
            this.FromNode = fromNode;
            this.ToNode = toNode;
            this.PumpType = pumpType;
            this.Speed = speed;
            this.PatternID = patternID;
            this.ConstantPower = constantPower;
            this.ZoneID = zoneID;
            this.Description = description;
            this.DataSource = dataSource;
            this.AssetName = assetName;
            this.FromX = fromX;
            this.FromY = fromY;
            this.ToX = toX;
            this.ToY = toY;
            this.Id = id;
        }
        
        /// <summary>
        /// 模型中泵站ID pump muid
        /// </summary>
        /// <value>模型中泵站ID pump muid</value>
        [DataMember(Name="muid", EmitDefaultValue=true)]
        public string Muid { get; set; }

        /// <summary>
        /// 起始节点 from node
        /// </summary>
        /// <value>起始节点 from node</value>
        [DataMember(Name="fromNode", EmitDefaultValue=true)]
        public string FromNode { get; set; }

        /// <summary>
        /// 终止节点 to node
        /// </summary>
        /// <value>终止节点 to node</value>
        [DataMember(Name="toNode", EmitDefaultValue=true)]
        public string ToNode { get; set; }

        /// <summary>
        /// 泵站类型 pump type
        /// </summary>
        /// <value>泵站类型 pump type</value>
        [DataMember(Name="pumpType", EmitDefaultValue=false)]
        public int PumpType { get; set; }

        /// <summary>
        /// 泵站速度 pump speed
        /// </summary>
        /// <value>泵站速度 pump speed</value>
        [DataMember(Name="speed", EmitDefaultValue=false)]
        public double Speed { get; set; }

        /// <summary>
        /// 模式ID pattern id
        /// </summary>
        /// <value>模式ID pattern id</value>
        [DataMember(Name="patternID", EmitDefaultValue=true)]
        public string PatternID { get; set; }

        /// <summary>
        /// 泵站功率 pump constant power
        /// </summary>
        /// <value>泵站功率 pump constant power</value>
        [DataMember(Name="constantPower", EmitDefaultValue=false)]
        public double ConstantPower { get; set; }

        /// <summary>
        /// 分区ID zone id
        /// </summary>
        /// <value>分区ID zone id</value>
        [DataMember(Name="zoneID", EmitDefaultValue=true)]
        public string ZoneID { get; set; }

        /// <summary>
        /// 描述 description
        /// </summary>
        /// <value>描述 description</value>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// 数据源 data source
        /// </summary>
        /// <value>数据源 data source</value>
        [DataMember(Name="dataSource", EmitDefaultValue=true)]
        public string DataSource { get; set; }

        /// <summary>
        /// 资产名称 asset name
        /// </summary>
        /// <value>资产名称 asset name</value>
        [DataMember(Name="assetName", EmitDefaultValue=true)]
        public string AssetName { get; set; }

        /// <summary>
        /// 起始节点坐标X coordinate x of from-node
        /// </summary>
        /// <value>起始节点坐标X coordinate x of from-node</value>
        [DataMember(Name="fromX", EmitDefaultValue=false)]
        public double FromX { get; set; }

        /// <summary>
        /// 起始节点坐标Y coordinate y of from-node
        /// </summary>
        /// <value>起始节点坐标Y coordinate y of from-node</value>
        [DataMember(Name="fromY", EmitDefaultValue=false)]
        public double FromY { get; set; }

        /// <summary>
        /// 终止节点坐标X coordinate x of to-node
        /// </summary>
        /// <value>终止节点坐标X coordinate x of to-node</value>
        [DataMember(Name="toX", EmitDefaultValue=false)]
        public double ToX { get; set; }

        /// <summary>
        /// 终止节点坐标Y coordinate y of to-node
        /// </summary>
        /// <value>终止节点坐标Y coordinate y of to-node</value>
        [DataMember(Name="toY", EmitDefaultValue=false)]
        public double ToY { get; set; }

        /// <summary>
        /// 泵站ID pump id
        /// </summary>
        /// <value>泵站ID pump id</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdatePumpDto {\n");
            sb.Append("  Muid: ").Append(Muid).Append("\n");
            sb.Append("  FromNode: ").Append(FromNode).Append("\n");
            sb.Append("  ToNode: ").Append(ToNode).Append("\n");
            sb.Append("  PumpType: ").Append(PumpType).Append("\n");
            sb.Append("  Speed: ").Append(Speed).Append("\n");
            sb.Append("  PatternID: ").Append(PatternID).Append("\n");
            sb.Append("  ConstantPower: ").Append(ConstantPower).Append("\n");
            sb.Append("  ZoneID: ").Append(ZoneID).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DataSource: ").Append(DataSource).Append("\n");
            sb.Append("  AssetName: ").Append(AssetName).Append("\n");
            sb.Append("  FromX: ").Append(FromX).Append("\n");
            sb.Append("  FromY: ").Append(FromY).Append("\n");
            sb.Append("  ToX: ").Append(ToX).Append("\n");
            sb.Append("  ToY: ").Append(ToY).Append("\n");
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
            return this.Equals(input as UpdatePumpDto);
        }

        /// <summary>
        /// Returns true if UpdatePumpDto instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdatePumpDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdatePumpDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Muid == input.Muid ||
                    (this.Muid != null &&
                    this.Muid.Equals(input.Muid))
                ) && 
                (
                    this.FromNode == input.FromNode ||
                    (this.FromNode != null &&
                    this.FromNode.Equals(input.FromNode))
                ) && 
                (
                    this.ToNode == input.ToNode ||
                    (this.ToNode != null &&
                    this.ToNode.Equals(input.ToNode))
                ) && 
                (
                    this.PumpType == input.PumpType ||
                    this.PumpType.Equals(input.PumpType)
                ) && 
                (
                    this.Speed == input.Speed ||
                    this.Speed.Equals(input.Speed)
                ) && 
                (
                    this.PatternID == input.PatternID ||
                    (this.PatternID != null &&
                    this.PatternID.Equals(input.PatternID))
                ) && 
                (
                    this.ConstantPower == input.ConstantPower ||
                    this.ConstantPower.Equals(input.ConstantPower)
                ) && 
                (
                    this.ZoneID == input.ZoneID ||
                    (this.ZoneID != null &&
                    this.ZoneID.Equals(input.ZoneID))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.DataSource == input.DataSource ||
                    (this.DataSource != null &&
                    this.DataSource.Equals(input.DataSource))
                ) && 
                (
                    this.AssetName == input.AssetName ||
                    (this.AssetName != null &&
                    this.AssetName.Equals(input.AssetName))
                ) && 
                (
                    this.FromX == input.FromX ||
                    this.FromX.Equals(input.FromX)
                ) && 
                (
                    this.FromY == input.FromY ||
                    this.FromY.Equals(input.FromY)
                ) && 
                (
                    this.ToX == input.ToX ||
                    this.ToX.Equals(input.ToX)
                ) && 
                (
                    this.ToY == input.ToY ||
                    this.ToY.Equals(input.ToY)
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
                if (this.Muid != null)
                    hashCode = hashCode * 59 + this.Muid.GetHashCode();
                if (this.FromNode != null)
                    hashCode = hashCode * 59 + this.FromNode.GetHashCode();
                if (this.ToNode != null)
                    hashCode = hashCode * 59 + this.ToNode.GetHashCode();
                hashCode = hashCode * 59 + this.PumpType.GetHashCode();
                hashCode = hashCode * 59 + this.Speed.GetHashCode();
                if (this.PatternID != null)
                    hashCode = hashCode * 59 + this.PatternID.GetHashCode();
                hashCode = hashCode * 59 + this.ConstantPower.GetHashCode();
                if (this.ZoneID != null)
                    hashCode = hashCode * 59 + this.ZoneID.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DataSource != null)
                    hashCode = hashCode * 59 + this.DataSource.GetHashCode();
                if (this.AssetName != null)
                    hashCode = hashCode * 59 + this.AssetName.GetHashCode();
                hashCode = hashCode * 59 + this.FromX.GetHashCode();
                hashCode = hashCode * 59 + this.FromY.GetHashCode();
                hashCode = hashCode * 59 + this.ToX.GetHashCode();
                hashCode = hashCode * 59 + this.ToY.GetHashCode();
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
