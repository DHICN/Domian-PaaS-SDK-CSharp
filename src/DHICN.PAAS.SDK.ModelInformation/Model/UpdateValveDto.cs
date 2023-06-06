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
    /// UpdateValveDto
    /// </summary>
    [DataContract]
    public partial class UpdateValveDto :  IEquatable<UpdateValveDto>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets SettingNo
        /// </summary>
        [DataMember(Name="settingNo", EmitDefaultValue=false)]
        public WdValveSettingNo? SettingNo { get; set; }
        /// <summary>
        /// Gets or Sets ValveType
        /// </summary>
        [DataMember(Name="valveType", EmitDefaultValue=false)]
        public WdValveTypeNo? ValveType { get; set; }
        /// <summary>
        /// Gets or Sets ValveStatus
        /// </summary>
        [DataMember(Name="valveStatus", EmitDefaultValue=false)]
        public WdValveStatusNo? ValveStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateValveDto" /> class.
        /// </summary>
        /// <param name="muid">模型中阀门的ID valve muid.</param>
        /// <param name="setting">设置的数值 setting valve.</param>
        /// <param name="settingNo">settingNo.</param>
        /// <param name="valveType">valveType.</param>
        /// <param name="valveStatus">valveStatus.</param>
        /// <param name="geomWKT">阀门空间信息 valve geometry in wkt format.</param>
        /// <param name="toY">终止节点坐标值Y coordinate y of to-node.</param>
        /// <param name="toX">终止节点坐标值X coordinate x of to-node.</param>
        /// <param name="fromY">起始节点坐标值Y coordinate y of from-node.</param>
        /// <param name="fromX">起始节点坐标值X coordinate x of from-node.</param>
        /// <param name="coorStr">坐标信息 coordinate.</param>
        /// <param name="streetName">街道名称 street name.</param>
        /// <param name="description">描述 description.</param>
        /// <param name="note">备注 note.</param>
        /// <param name="dataSource">数据源 data source.</param>
        /// <param name="zoneID">分区ID zone id.</param>
        /// <param name="lossCoeff">损失系数 loss coefficient.</param>
        /// <param name="diameter">直径 diameter.</param>
        /// <param name="toNode">终止节点 to node.</param>
        /// <param name="fromNode">起始节点 from node.</param>
        /// <param name="operCurveID">调度曲线ID operation schedule curve id.</param>
        /// <param name="valveCurveID">阀门曲线ID valve characteristic curve id.</param>
        /// <param name="createTime">创建时间 create time.</param>
        /// <param name="id">阀门ID valve id.</param>
        public UpdateValveDto(string muid = default(string), double setting = default(double), WdValveSettingNo? settingNo = default(WdValveSettingNo?), WdValveTypeNo? valveType = default(WdValveTypeNo?), WdValveStatusNo? valveStatus = default(WdValveStatusNo?), string geomWKT = default(string), double toY = default(double), double toX = default(double), double fromY = default(double), double fromX = default(double), string coorStr = default(string), string streetName = default(string), string description = default(string), string note = default(string), string dataSource = default(string), string zoneID = default(string), double lossCoeff = default(double), double diameter = default(double), string toNode = default(string), string fromNode = default(string), string operCurveID = default(string), string valveCurveID = default(string), DateTime createTime = default(DateTime), Guid id = default(Guid))
        {
            this.Muid = muid;
            this.Setting = setting;
            this.SettingNo = settingNo;
            this.ValveType = valveType;
            this.ValveStatus = valveStatus;
            this.GeomWKT = geomWKT;
            this.ToY = toY;
            this.ToX = toX;
            this.FromY = fromY;
            this.FromX = fromX;
            this.CoorStr = coorStr;
            this.StreetName = streetName;
            this.Description = description;
            this.Note = note;
            this.DataSource = dataSource;
            this.ZoneID = zoneID;
            this.LossCoeff = lossCoeff;
            this.Diameter = diameter;
            this.ToNode = toNode;
            this.FromNode = fromNode;
            this.OperCurveID = operCurveID;
            this.ValveCurveID = valveCurveID;
            this.CreateTime = createTime;
            this.Id = id;
        }
        
        /// <summary>
        /// 模型中阀门的ID valve muid
        /// </summary>
        /// <value>模型中阀门的ID valve muid</value>
        [DataMember(Name="muid", EmitDefaultValue=true)]
        public string Muid { get; set; }

        /// <summary>
        /// 设置的数值 setting valve
        /// </summary>
        /// <value>设置的数值 setting valve</value>
        [DataMember(Name="setting", EmitDefaultValue=false)]
        public double Setting { get; set; }

        /// <summary>
        /// 阀门空间信息 valve geometry in wkt format
        /// </summary>
        /// <value>阀门空间信息 valve geometry in wkt format</value>
        [DataMember(Name="geomWKT", EmitDefaultValue=true)]
        public string GeomWKT { get; set; }

        /// <summary>
        /// 终止节点坐标值Y coordinate y of to-node
        /// </summary>
        /// <value>终止节点坐标值Y coordinate y of to-node</value>
        [DataMember(Name="toY", EmitDefaultValue=false)]
        public double ToY { get; set; }

        /// <summary>
        /// 终止节点坐标值X coordinate x of to-node
        /// </summary>
        /// <value>终止节点坐标值X coordinate x of to-node</value>
        [DataMember(Name="toX", EmitDefaultValue=false)]
        public double ToX { get; set; }

        /// <summary>
        /// 起始节点坐标值Y coordinate y of from-node
        /// </summary>
        /// <value>起始节点坐标值Y coordinate y of from-node</value>
        [DataMember(Name="fromY", EmitDefaultValue=false)]
        public double FromY { get; set; }

        /// <summary>
        /// 起始节点坐标值X coordinate x of from-node
        /// </summary>
        /// <value>起始节点坐标值X coordinate x of from-node</value>
        [DataMember(Name="fromX", EmitDefaultValue=false)]
        public double FromX { get; set; }

        /// <summary>
        /// 坐标信息 coordinate
        /// </summary>
        /// <value>坐标信息 coordinate</value>
        [DataMember(Name="coorStr", EmitDefaultValue=true)]
        public string CoorStr { get; set; }

        /// <summary>
        /// 街道名称 street name
        /// </summary>
        /// <value>街道名称 street name</value>
        [DataMember(Name="streetName", EmitDefaultValue=true)]
        public string StreetName { get; set; }

        /// <summary>
        /// 描述 description
        /// </summary>
        /// <value>描述 description</value>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// 备注 note
        /// </summary>
        /// <value>备注 note</value>
        [DataMember(Name="note", EmitDefaultValue=true)]
        public string Note { get; set; }

        /// <summary>
        /// 数据源 data source
        /// </summary>
        /// <value>数据源 data source</value>
        [DataMember(Name="dataSource", EmitDefaultValue=true)]
        public string DataSource { get; set; }

        /// <summary>
        /// 分区ID zone id
        /// </summary>
        /// <value>分区ID zone id</value>
        [DataMember(Name="zoneID", EmitDefaultValue=true)]
        public string ZoneID { get; set; }

        /// <summary>
        /// 损失系数 loss coefficient
        /// </summary>
        /// <value>损失系数 loss coefficient</value>
        [DataMember(Name="lossCoeff", EmitDefaultValue=false)]
        public double LossCoeff { get; set; }

        /// <summary>
        /// 直径 diameter
        /// </summary>
        /// <value>直径 diameter</value>
        [DataMember(Name="diameter", EmitDefaultValue=false)]
        public double Diameter { get; set; }

        /// <summary>
        /// 终止节点 to node
        /// </summary>
        /// <value>终止节点 to node</value>
        [DataMember(Name="toNode", EmitDefaultValue=true)]
        public string ToNode { get; set; }

        /// <summary>
        /// 起始节点 from node
        /// </summary>
        /// <value>起始节点 from node</value>
        [DataMember(Name="fromNode", EmitDefaultValue=true)]
        public string FromNode { get; set; }

        /// <summary>
        /// 调度曲线ID operation schedule curve id
        /// </summary>
        /// <value>调度曲线ID operation schedule curve id</value>
        [DataMember(Name="operCurveID", EmitDefaultValue=true)]
        public string OperCurveID { get; set; }

        /// <summary>
        /// 阀门曲线ID valve characteristic curve id
        /// </summary>
        /// <value>阀门曲线ID valve characteristic curve id</value>
        [DataMember(Name="valveCurveID", EmitDefaultValue=true)]
        public string ValveCurveID { get; set; }

        /// <summary>
        /// 创建时间 create time
        /// </summary>
        /// <value>创建时间 create time</value>
        [DataMember(Name="createTime", EmitDefaultValue=false)]
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 阀门ID valve id
        /// </summary>
        /// <value>阀门ID valve id</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateValveDto {\n");
            sb.Append("  Muid: ").Append(Muid).Append("\n");
            sb.Append("  Setting: ").Append(Setting).Append("\n");
            sb.Append("  SettingNo: ").Append(SettingNo).Append("\n");
            sb.Append("  ValveType: ").Append(ValveType).Append("\n");
            sb.Append("  ValveStatus: ").Append(ValveStatus).Append("\n");
            sb.Append("  GeomWKT: ").Append(GeomWKT).Append("\n");
            sb.Append("  ToY: ").Append(ToY).Append("\n");
            sb.Append("  ToX: ").Append(ToX).Append("\n");
            sb.Append("  FromY: ").Append(FromY).Append("\n");
            sb.Append("  FromX: ").Append(FromX).Append("\n");
            sb.Append("  CoorStr: ").Append(CoorStr).Append("\n");
            sb.Append("  StreetName: ").Append(StreetName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
            sb.Append("  DataSource: ").Append(DataSource).Append("\n");
            sb.Append("  ZoneID: ").Append(ZoneID).Append("\n");
            sb.Append("  LossCoeff: ").Append(LossCoeff).Append("\n");
            sb.Append("  Diameter: ").Append(Diameter).Append("\n");
            sb.Append("  ToNode: ").Append(ToNode).Append("\n");
            sb.Append("  FromNode: ").Append(FromNode).Append("\n");
            sb.Append("  OperCurveID: ").Append(OperCurveID).Append("\n");
            sb.Append("  ValveCurveID: ").Append(ValveCurveID).Append("\n");
            sb.Append("  CreateTime: ").Append(CreateTime).Append("\n");
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
            return this.Equals(input as UpdateValveDto);
        }

        /// <summary>
        /// Returns true if UpdateValveDto instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateValveDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateValveDto input)
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
                    this.Setting == input.Setting ||
                    this.Setting.Equals(input.Setting)
                ) && 
                (
                    this.SettingNo == input.SettingNo ||
                    this.SettingNo.Equals(input.SettingNo)
                ) && 
                (
                    this.ValveType == input.ValveType ||
                    this.ValveType.Equals(input.ValveType)
                ) && 
                (
                    this.ValveStatus == input.ValveStatus ||
                    this.ValveStatus.Equals(input.ValveStatus)
                ) && 
                (
                    this.GeomWKT == input.GeomWKT ||
                    (this.GeomWKT != null &&
                    this.GeomWKT.Equals(input.GeomWKT))
                ) && 
                (
                    this.ToY == input.ToY ||
                    this.ToY.Equals(input.ToY)
                ) && 
                (
                    this.ToX == input.ToX ||
                    this.ToX.Equals(input.ToX)
                ) && 
                (
                    this.FromY == input.FromY ||
                    this.FromY.Equals(input.FromY)
                ) && 
                (
                    this.FromX == input.FromX ||
                    this.FromX.Equals(input.FromX)
                ) && 
                (
                    this.CoorStr == input.CoorStr ||
                    (this.CoorStr != null &&
                    this.CoorStr.Equals(input.CoorStr))
                ) && 
                (
                    this.StreetName == input.StreetName ||
                    (this.StreetName != null &&
                    this.StreetName.Equals(input.StreetName))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Note == input.Note ||
                    (this.Note != null &&
                    this.Note.Equals(input.Note))
                ) && 
                (
                    this.DataSource == input.DataSource ||
                    (this.DataSource != null &&
                    this.DataSource.Equals(input.DataSource))
                ) && 
                (
                    this.ZoneID == input.ZoneID ||
                    (this.ZoneID != null &&
                    this.ZoneID.Equals(input.ZoneID))
                ) && 
                (
                    this.LossCoeff == input.LossCoeff ||
                    this.LossCoeff.Equals(input.LossCoeff)
                ) && 
                (
                    this.Diameter == input.Diameter ||
                    this.Diameter.Equals(input.Diameter)
                ) && 
                (
                    this.ToNode == input.ToNode ||
                    (this.ToNode != null &&
                    this.ToNode.Equals(input.ToNode))
                ) && 
                (
                    this.FromNode == input.FromNode ||
                    (this.FromNode != null &&
                    this.FromNode.Equals(input.FromNode))
                ) && 
                (
                    this.OperCurveID == input.OperCurveID ||
                    (this.OperCurveID != null &&
                    this.OperCurveID.Equals(input.OperCurveID))
                ) && 
                (
                    this.ValveCurveID == input.ValveCurveID ||
                    (this.ValveCurveID != null &&
                    this.ValveCurveID.Equals(input.ValveCurveID))
                ) && 
                (
                    this.CreateTime == input.CreateTime ||
                    (this.CreateTime != null &&
                    this.CreateTime.Equals(input.CreateTime))
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
                hashCode = hashCode * 59 + this.Setting.GetHashCode();
                hashCode = hashCode * 59 + this.SettingNo.GetHashCode();
                hashCode = hashCode * 59 + this.ValveType.GetHashCode();
                hashCode = hashCode * 59 + this.ValveStatus.GetHashCode();
                if (this.GeomWKT != null)
                    hashCode = hashCode * 59 + this.GeomWKT.GetHashCode();
                hashCode = hashCode * 59 + this.ToY.GetHashCode();
                hashCode = hashCode * 59 + this.ToX.GetHashCode();
                hashCode = hashCode * 59 + this.FromY.GetHashCode();
                hashCode = hashCode * 59 + this.FromX.GetHashCode();
                if (this.CoorStr != null)
                    hashCode = hashCode * 59 + this.CoorStr.GetHashCode();
                if (this.StreetName != null)
                    hashCode = hashCode * 59 + this.StreetName.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Note != null)
                    hashCode = hashCode * 59 + this.Note.GetHashCode();
                if (this.DataSource != null)
                    hashCode = hashCode * 59 + this.DataSource.GetHashCode();
                if (this.ZoneID != null)
                    hashCode = hashCode * 59 + this.ZoneID.GetHashCode();
                hashCode = hashCode * 59 + this.LossCoeff.GetHashCode();
                hashCode = hashCode * 59 + this.Diameter.GetHashCode();
                if (this.ToNode != null)
                    hashCode = hashCode * 59 + this.ToNode.GetHashCode();
                if (this.FromNode != null)
                    hashCode = hashCode * 59 + this.FromNode.GetHashCode();
                if (this.OperCurveID != null)
                    hashCode = hashCode * 59 + this.OperCurveID.GetHashCode();
                if (this.ValveCurveID != null)
                    hashCode = hashCode * 59 + this.ValveCurveID.GetHashCode();
                if (this.CreateTime != null)
                    hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
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
