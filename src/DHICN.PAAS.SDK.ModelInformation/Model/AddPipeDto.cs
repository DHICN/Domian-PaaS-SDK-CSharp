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
    /// AddPipeDto
    /// </summary>
    [DataContract]
    public partial class AddPipeDto :  IEquatable<AddPipeDto>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Operate
        /// </summary>
        [DataMember(Name="operate", EmitDefaultValue=false)]
        public OperateEnum? Operate { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddPipeDto" /> class.
        /// </summary>
        /// <param name="muid">模型中管段ID pipe muid.</param>
        /// <param name="fromNode">起始节点 from node.</param>
        /// <param name="toNode">终止节点 to node.</param>
        /// <param name="length">管长 pipe length.</param>
        /// <param name="diameter">管径 pipe diameter.</param>
        /// <param name="thickness">管壁厚度 pipe wall thickness.</param>
        /// <param name="pipeStatus">管道状态 pipe status.</param>
        /// <param name="zoneID">分区ID zone id.</param>
        /// <param name="roughness">粗糙度 pipe roughness.</param>
        /// <param name="lossCoeff">损失系数 loss coefficient.</param>
        /// <param name="material">管材 pipe material.</param>
        /// <param name="constructionYear">建设时间 construction time.</param>
        /// <param name="description">描述 description.</param>
        /// <param name="dataSource">数据源 data source.</param>
        /// <param name="assetName">资产名称 asset name.</param>
        /// <param name="streetName">街道名称 street name.</param>
        /// <param name="fromX">起始节点坐标X coordinate x of from-node.</param>
        /// <param name="fromY">起始节点坐标Y coordinate y of from-node.</param>
        /// <param name="toX">终止节点坐标X coordinate x of to-node.</param>
        /// <param name="toY">终止节点坐标Y coordinate y of to-node.</param>
        /// <param name="operate">operate.</param>
        public AddPipeDto(string muid = default(string), string fromNode = default(string), string toNode = default(string), double length = default(double), double diameter = default(double), double thickness = default(double), int pipeStatus = default(int), string zoneID = default(string), double roughness = default(double), double lossCoeff = default(double), string material = default(string), DateTime constructionYear = default(DateTime), string description = default(string), string dataSource = default(string), string assetName = default(string), string streetName = default(string), double fromX = default(double), double fromY = default(double), double toX = default(double), double toY = default(double), OperateEnum? operate = default(OperateEnum?))
        {
            this.Muid = muid;
            this.FromNode = fromNode;
            this.ToNode = toNode;
            this.Length = length;
            this.Diameter = diameter;
            this.Thickness = thickness;
            this.PipeStatus = pipeStatus;
            this.ZoneID = zoneID;
            this.Roughness = roughness;
            this.LossCoeff = lossCoeff;
            this.Material = material;
            this.ConstructionYear = constructionYear;
            this.Description = description;
            this.DataSource = dataSource;
            this.AssetName = assetName;
            this.StreetName = streetName;
            this.FromX = fromX;
            this.FromY = fromY;
            this.ToX = toX;
            this.ToY = toY;
            this.Operate = operate;
        }
        
        /// <summary>
        /// 模型中管段ID pipe muid
        /// </summary>
        /// <value>模型中管段ID pipe muid</value>
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
        /// 管长 pipe length
        /// </summary>
        /// <value>管长 pipe length</value>
        [DataMember(Name="length", EmitDefaultValue=false)]
        public double Length { get; set; }

        /// <summary>
        /// 管径 pipe diameter
        /// </summary>
        /// <value>管径 pipe diameter</value>
        [DataMember(Name="diameter", EmitDefaultValue=false)]
        public double Diameter { get; set; }

        /// <summary>
        /// 管壁厚度 pipe wall thickness
        /// </summary>
        /// <value>管壁厚度 pipe wall thickness</value>
        [DataMember(Name="thickness", EmitDefaultValue=false)]
        public double Thickness { get; set; }

        /// <summary>
        /// 管道状态 pipe status
        /// </summary>
        /// <value>管道状态 pipe status</value>
        [DataMember(Name="pipeStatus", EmitDefaultValue=false)]
        public int PipeStatus { get; set; }

        /// <summary>
        /// 分区ID zone id
        /// </summary>
        /// <value>分区ID zone id</value>
        [DataMember(Name="zoneID", EmitDefaultValue=true)]
        public string ZoneID { get; set; }

        /// <summary>
        /// 粗糙度 pipe roughness
        /// </summary>
        /// <value>粗糙度 pipe roughness</value>
        [DataMember(Name="roughness", EmitDefaultValue=false)]
        public double Roughness { get; set; }

        /// <summary>
        /// 损失系数 loss coefficient
        /// </summary>
        /// <value>损失系数 loss coefficient</value>
        [DataMember(Name="lossCoeff", EmitDefaultValue=false)]
        public double LossCoeff { get; set; }

        /// <summary>
        /// 管材 pipe material
        /// </summary>
        /// <value>管材 pipe material</value>
        [DataMember(Name="material", EmitDefaultValue=true)]
        public string Material { get; set; }

        /// <summary>
        /// 建设时间 construction time
        /// </summary>
        /// <value>建设时间 construction time</value>
        [DataMember(Name="constructionYear", EmitDefaultValue=false)]
        public DateTime ConstructionYear { get; set; }

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
        /// 街道名称 street name
        /// </summary>
        /// <value>街道名称 street name</value>
        [DataMember(Name="streetName", EmitDefaultValue=true)]
        public string StreetName { get; set; }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddPipeDto {\n");
            sb.Append("  Muid: ").Append(Muid).Append("\n");
            sb.Append("  FromNode: ").Append(FromNode).Append("\n");
            sb.Append("  ToNode: ").Append(ToNode).Append("\n");
            sb.Append("  Length: ").Append(Length).Append("\n");
            sb.Append("  Diameter: ").Append(Diameter).Append("\n");
            sb.Append("  Thickness: ").Append(Thickness).Append("\n");
            sb.Append("  PipeStatus: ").Append(PipeStatus).Append("\n");
            sb.Append("  ZoneID: ").Append(ZoneID).Append("\n");
            sb.Append("  Roughness: ").Append(Roughness).Append("\n");
            sb.Append("  LossCoeff: ").Append(LossCoeff).Append("\n");
            sb.Append("  Material: ").Append(Material).Append("\n");
            sb.Append("  ConstructionYear: ").Append(ConstructionYear).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DataSource: ").Append(DataSource).Append("\n");
            sb.Append("  AssetName: ").Append(AssetName).Append("\n");
            sb.Append("  StreetName: ").Append(StreetName).Append("\n");
            sb.Append("  FromX: ").Append(FromX).Append("\n");
            sb.Append("  FromY: ").Append(FromY).Append("\n");
            sb.Append("  ToX: ").Append(ToX).Append("\n");
            sb.Append("  ToY: ").Append(ToY).Append("\n");
            sb.Append("  Operate: ").Append(Operate).Append("\n");
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
            return this.Equals(input as AddPipeDto);
        }

        /// <summary>
        /// Returns true if AddPipeDto instances are equal
        /// </summary>
        /// <param name="input">Instance of AddPipeDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddPipeDto input)
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
                    this.Length == input.Length ||
                    this.Length.Equals(input.Length)
                ) && 
                (
                    this.Diameter == input.Diameter ||
                    this.Diameter.Equals(input.Diameter)
                ) && 
                (
                    this.Thickness == input.Thickness ||
                    this.Thickness.Equals(input.Thickness)
                ) && 
                (
                    this.PipeStatus == input.PipeStatus ||
                    this.PipeStatus.Equals(input.PipeStatus)
                ) && 
                (
                    this.ZoneID == input.ZoneID ||
                    (this.ZoneID != null &&
                    this.ZoneID.Equals(input.ZoneID))
                ) && 
                (
                    this.Roughness == input.Roughness ||
                    this.Roughness.Equals(input.Roughness)
                ) && 
                (
                    this.LossCoeff == input.LossCoeff ||
                    this.LossCoeff.Equals(input.LossCoeff)
                ) && 
                (
                    this.Material == input.Material ||
                    (this.Material != null &&
                    this.Material.Equals(input.Material))
                ) && 
                (
                    this.ConstructionYear == input.ConstructionYear ||
                    (this.ConstructionYear != null &&
                    this.ConstructionYear.Equals(input.ConstructionYear))
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
                    this.StreetName == input.StreetName ||
                    (this.StreetName != null &&
                    this.StreetName.Equals(input.StreetName))
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
                    this.Operate == input.Operate ||
                    this.Operate.Equals(input.Operate)
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
                hashCode = hashCode * 59 + this.Length.GetHashCode();
                hashCode = hashCode * 59 + this.Diameter.GetHashCode();
                hashCode = hashCode * 59 + this.Thickness.GetHashCode();
                hashCode = hashCode * 59 + this.PipeStatus.GetHashCode();
                if (this.ZoneID != null)
                    hashCode = hashCode * 59 + this.ZoneID.GetHashCode();
                hashCode = hashCode * 59 + this.Roughness.GetHashCode();
                hashCode = hashCode * 59 + this.LossCoeff.GetHashCode();
                if (this.Material != null)
                    hashCode = hashCode * 59 + this.Material.GetHashCode();
                if (this.ConstructionYear != null)
                    hashCode = hashCode * 59 + this.ConstructionYear.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DataSource != null)
                    hashCode = hashCode * 59 + this.DataSource.GetHashCode();
                if (this.AssetName != null)
                    hashCode = hashCode * 59 + this.AssetName.GetHashCode();
                if (this.StreetName != null)
                    hashCode = hashCode * 59 + this.StreetName.GetHashCode();
                hashCode = hashCode * 59 + this.FromX.GetHashCode();
                hashCode = hashCode * 59 + this.FromY.GetHashCode();
                hashCode = hashCode * 59 + this.ToX.GetHashCode();
                hashCode = hashCode * 59 + this.ToY.GetHashCode();
                hashCode = hashCode * 59 + this.Operate.GetHashCode();
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
