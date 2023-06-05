/* 
 * scenario-manager-service
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
using OpenAPIDateConverter = DHI.DSS.ScenarioManagerServiceSDK.Client.OpenAPIDateConverter;

namespace DHI.DSS.ScenarioManagerServiceSDK.Model
{
    /// <summary>
    /// Scenario
    /// </summary>
    [DataContract]
    public partial class Scenario :  IEquatable<Scenario>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Scenario" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Scenario() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Scenario" /> class.
        /// </summary>
        /// <param name="id">方案ID scenario Id (required).</param>
        /// <param name="scenarioCode">方案代码 scenario code (required).</param>
        /// <param name="scenarioName">方案名称 scenario name.</param>
        /// <param name="modelType">模型类型，包括但不限于 model type, including but not limited to:  0-MIKE11Model(MIKE 11 model),  2-MIKE21Model(MIKE 21 model),  3-MIKE21FMModel(MIKE 21FM model),  4-MIKE3FMModel(MIKE 3FM model),  5-MIKEFloodModel(MIKE Flood model),  7-MIKEUrbanCSModel(MIKE Urban CS model),  8-MIKEUrbanWDModel(MIKE Urban WD model),  9-HydroBasinModel(MIKE HYDRO Basin model),  12-FeflowModel(MIKE Feflow model),  13-WestModel(West model),  20-HammerModel(Hammer model of WD),  21-MIKEPlusFloodModel(MIKE Plus Flood model),  22-MIKEPlusWDModel(MIKE Plus WD model),  99-Unknown(Unknown),.</param>
        /// <param name="modelSubType">方案子类型，包括但不限于 scenario subtype, including but not limited to:  0-ManualSchedule(Manual schedule),  2-OptimizeSchedule(Optimization schedule),  5-EmerResponse(Emergency response),  6-Forecast(Forecast and warning),  8-Scenario(Scenario simulation),  9-Incident(Accident),  12-WQEvaluation(Water quality evaluation),  14-Planning(Planning),  15-OilSpill(Oil spill accident),  19-PumpShutdown(Pump shut down scenario),  20-PipeBurst(Pipe burst scenario),  99-Unknown(Unknown),.</param>
        /// <param name="template">1表示模板方案，0表示非模板方案 1 or 0, indicating if the scenario is a template or not.</param>
        /// <param name="inheritedScenario">父方案ID parent scenario Id.</param>
        /// <param name="readOnly">1表示只读，0表示可读写 1 for readonly, 0 for not readonly.</param>
        /// <param name="enabled">1表示启用，0表示不启用 1 for enabled, 0 for disabled.</param>
        /// <param name="relativeFolder">方案文件夹相对于WorkFolder的路径 scenario&#39;s relative path to WorkFolder.</param>
        /// <param name="projectFile">模型文件名称 model file name.</param>
        /// <param name="currentTime">模型预报时刻 model current time or forecast time.</param>
        /// <param name="startTime">模型开始时刻 model start time.</param>
        /// <param name="endTime">模型结束时刻 model end time.</param>
        /// <param name="createTime">方案创建时刻 scenario create time.</param>
        /// <param name="autoCalculate">1表示自动计算，0表示非自动计算 1 for auto calculate, 0 for not auto calculate.</param>
        /// <param name="modified">1表示修改过，0表示没有修改过 1 for modified, 0 for not modified.</param>
        /// <param name="_checked">1表示被选中，0表示未被选中 1 for checked, 0 for unchecked.</param>
        /// <param name="calculated">1表示计算完成，0表示未计算完成 1 for calculated, 0 for not calculated.</param>
        /// <param name="published">1表示已发布，0表示未发布 1 for published, 0 for not published.</param>
        /// <param name="onlineFirst">1表示优先使用在线数据，0表示非优先使用在线数据 1 for online first, 0 for not online first.</param>
        /// <param name="autoAmend">1表示进行自动修改，0表示不进行自动修正 1 for auto amend, 0 for not auto amend.</param>
        /// <param name="state">方案的状态 scenario&#39;s status.</param>
        /// <param name="description">方案的描述 scenario description.</param>
        /// <param name="version">版本 version.</param>
        /// <param name="tenantId">租户ID tenant Id.</param>
        /// <param name="minIOPath">在分布式文件系统上的存储路径 store path on distributed file system.</param>
        /// <param name="minIOBucket">在分布式文件系统上的存储桶 store bucket on distributed file system.</param>
        /// <param name="creatorName">creatorName.</param>
        /// <param name="name">name.</param>
        public Scenario(Guid id = default(Guid), string scenarioCode = default(string), string scenarioName = default(string), string modelType = default(string), string modelSubType = default(string), int template = default(int), Guid inheritedScenario = default(Guid), int readOnly = default(int), int enabled = default(int), string relativeFolder = default(string), string projectFile = default(string), DateTime currentTime = default(DateTime), DateTime startTime = default(DateTime), DateTime endTime = default(DateTime), DateTime createTime = default(DateTime), int autoCalculate = default(int), int modified = default(int), int _checked = default(int), int calculated = default(int), int published = default(int), int onlineFirst = default(int), int autoAmend = default(int), string state = default(string), string description = default(string), Guid version = default(Guid), string tenantId = default(string), string minIOPath = default(string), string minIOBucket = default(string), string creatorName = default(string), string name = default(string))
        {
            this.Id = id;
            // to ensure "scenarioCode" is required (not null)
            this.ScenarioCode = scenarioCode ?? throw new ArgumentNullException("scenarioCode is a required property for Scenario and cannot be null");
            this.ScenarioName = scenarioName;
            this.ModelType = modelType;
            this.ModelSubType = modelSubType;
            this.Template = template;
            this.InheritedScenario = inheritedScenario;
            this.ReadOnly = readOnly;
            this.Enabled = enabled;
            this.RelativeFolder = relativeFolder;
            this.ProjectFile = projectFile;
            this.CurrentTime = currentTime;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.CreateTime = createTime;
            this.AutoCalculate = autoCalculate;
            this.Modified = modified;
            this.Checked = _checked;
            this.Calculated = calculated;
            this.Published = published;
            this.OnlineFirst = onlineFirst;
            this.AutoAmend = autoAmend;
            this.State = state;
            this.Description = description;
            this.Version = version;
            this.TenantId = tenantId;
            this.MinIOPath = minIOPath;
            this.MinIOBucket = minIOBucket;
            this.CreatorName = creatorName;
            this.Name = name;
        }
        
        /// <summary>
        /// 方案ID scenario Id
        /// </summary>
        /// <value>方案ID scenario Id</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid Id { get; set; }

        /// <summary>
        /// 方案代码 scenario code
        /// </summary>
        /// <value>方案代码 scenario code</value>
        [DataMember(Name="scenarioCode", EmitDefaultValue=false)]
        public string ScenarioCode { get; set; }

        /// <summary>
        /// 方案名称 scenario name
        /// </summary>
        /// <value>方案名称 scenario name</value>
        [DataMember(Name="scenarioName", EmitDefaultValue=true)]
        public string ScenarioName { get; set; }

        /// <summary>
        /// 模型类型，包括但不限于 model type, including but not limited to:  0-MIKE11Model(MIKE 11 model),  2-MIKE21Model(MIKE 21 model),  3-MIKE21FMModel(MIKE 21FM model),  4-MIKE3FMModel(MIKE 3FM model),  5-MIKEFloodModel(MIKE Flood model),  7-MIKEUrbanCSModel(MIKE Urban CS model),  8-MIKEUrbanWDModel(MIKE Urban WD model),  9-HydroBasinModel(MIKE HYDRO Basin model),  12-FeflowModel(MIKE Feflow model),  13-WestModel(West model),  20-HammerModel(Hammer model of WD),  21-MIKEPlusFloodModel(MIKE Plus Flood model),  22-MIKEPlusWDModel(MIKE Plus WD model),  99-Unknown(Unknown),
        /// </summary>
        /// <value>模型类型，包括但不限于 model type, including but not limited to:  0-MIKE11Model(MIKE 11 model),  2-MIKE21Model(MIKE 21 model),  3-MIKE21FMModel(MIKE 21FM model),  4-MIKE3FMModel(MIKE 3FM model),  5-MIKEFloodModel(MIKE Flood model),  7-MIKEUrbanCSModel(MIKE Urban CS model),  8-MIKEUrbanWDModel(MIKE Urban WD model),  9-HydroBasinModel(MIKE HYDRO Basin model),  12-FeflowModel(MIKE Feflow model),  13-WestModel(West model),  20-HammerModel(Hammer model of WD),  21-MIKEPlusFloodModel(MIKE Plus Flood model),  22-MIKEPlusWDModel(MIKE Plus WD model),  99-Unknown(Unknown),</value>
        [DataMember(Name="modelType", EmitDefaultValue=true)]
        public string ModelType { get; set; }

        /// <summary>
        /// 方案子类型，包括但不限于 scenario subtype, including but not limited to:  0-ManualSchedule(Manual schedule),  2-OptimizeSchedule(Optimization schedule),  5-EmerResponse(Emergency response),  6-Forecast(Forecast and warning),  8-Scenario(Scenario simulation),  9-Incident(Accident),  12-WQEvaluation(Water quality evaluation),  14-Planning(Planning),  15-OilSpill(Oil spill accident),  19-PumpShutdown(Pump shut down scenario),  20-PipeBurst(Pipe burst scenario),  99-Unknown(Unknown),
        /// </summary>
        /// <value>方案子类型，包括但不限于 scenario subtype, including but not limited to:  0-ManualSchedule(Manual schedule),  2-OptimizeSchedule(Optimization schedule),  5-EmerResponse(Emergency response),  6-Forecast(Forecast and warning),  8-Scenario(Scenario simulation),  9-Incident(Accident),  12-WQEvaluation(Water quality evaluation),  14-Planning(Planning),  15-OilSpill(Oil spill accident),  19-PumpShutdown(Pump shut down scenario),  20-PipeBurst(Pipe burst scenario),  99-Unknown(Unknown),</value>
        [DataMember(Name="modelSubType", EmitDefaultValue=true)]
        public string ModelSubType { get; set; }

        /// <summary>
        /// 1表示模板方案，0表示非模板方案 1 or 0, indicating if the scenario is a template or not
        /// </summary>
        /// <value>1表示模板方案，0表示非模板方案 1 or 0, indicating if the scenario is a template or not</value>
        [DataMember(Name="template", EmitDefaultValue=false)]
        public int Template { get; set; }

        /// <summary>
        /// 父方案ID parent scenario Id
        /// </summary>
        /// <value>父方案ID parent scenario Id</value>
        [DataMember(Name="inheritedScenario", EmitDefaultValue=false)]
        public Guid InheritedScenario { get; set; }

        /// <summary>
        /// 1表示只读，0表示可读写 1 for readonly, 0 for not readonly
        /// </summary>
        /// <value>1表示只读，0表示可读写 1 for readonly, 0 for not readonly</value>
        [DataMember(Name="readOnly", EmitDefaultValue=false)]
        public int ReadOnly { get; set; }

        /// <summary>
        /// 1表示启用，0表示不启用 1 for enabled, 0 for disabled
        /// </summary>
        /// <value>1表示启用，0表示不启用 1 for enabled, 0 for disabled</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public int Enabled { get; set; }

        /// <summary>
        /// 方案文件夹相对于WorkFolder的路径 scenario&#39;s relative path to WorkFolder
        /// </summary>
        /// <value>方案文件夹相对于WorkFolder的路径 scenario&#39;s relative path to WorkFolder</value>
        [DataMember(Name="relativeFolder", EmitDefaultValue=true)]
        public string RelativeFolder { get; set; }

        /// <summary>
        /// 模型文件名称 model file name
        /// </summary>
        /// <value>模型文件名称 model file name</value>
        [DataMember(Name="projectFile", EmitDefaultValue=true)]
        public string ProjectFile { get; set; }

        /// <summary>
        /// 模型预报时刻 model current time or forecast time
        /// </summary>
        /// <value>模型预报时刻 model current time or forecast time</value>
        [DataMember(Name="currentTime", EmitDefaultValue=false)]
        public DateTime CurrentTime { get; set; }

        /// <summary>
        /// 模型开始时刻 model start time
        /// </summary>
        /// <value>模型开始时刻 model start time</value>
        [DataMember(Name="startTime", EmitDefaultValue=false)]
        public DateTime StartTime { get; set; }

        /// <summary>
        /// 模型结束时刻 model end time
        /// </summary>
        /// <value>模型结束时刻 model end time</value>
        [DataMember(Name="endTime", EmitDefaultValue=false)]
        public DateTime EndTime { get; set; }

        /// <summary>
        /// 方案创建时刻 scenario create time
        /// </summary>
        /// <value>方案创建时刻 scenario create time</value>
        [DataMember(Name="createTime", EmitDefaultValue=false)]
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 1表示自动计算，0表示非自动计算 1 for auto calculate, 0 for not auto calculate
        /// </summary>
        /// <value>1表示自动计算，0表示非自动计算 1 for auto calculate, 0 for not auto calculate</value>
        [DataMember(Name="autoCalculate", EmitDefaultValue=false)]
        public int AutoCalculate { get; set; }

        /// <summary>
        /// 1表示修改过，0表示没有修改过 1 for modified, 0 for not modified
        /// </summary>
        /// <value>1表示修改过，0表示没有修改过 1 for modified, 0 for not modified</value>
        [DataMember(Name="modified", EmitDefaultValue=false)]
        public int Modified { get; set; }

        /// <summary>
        /// 1表示被选中，0表示未被选中 1 for checked, 0 for unchecked
        /// </summary>
        /// <value>1表示被选中，0表示未被选中 1 for checked, 0 for unchecked</value>
        [DataMember(Name="checked", EmitDefaultValue=false)]
        public int Checked { get; set; }

        /// <summary>
        /// 1表示计算完成，0表示未计算完成 1 for calculated, 0 for not calculated
        /// </summary>
        /// <value>1表示计算完成，0表示未计算完成 1 for calculated, 0 for not calculated</value>
        [DataMember(Name="calculated", EmitDefaultValue=false)]
        public int Calculated { get; set; }

        /// <summary>
        /// 1表示已发布，0表示未发布 1 for published, 0 for not published
        /// </summary>
        /// <value>1表示已发布，0表示未发布 1 for published, 0 for not published</value>
        [DataMember(Name="published", EmitDefaultValue=false)]
        public int Published { get; set; }

        /// <summary>
        /// 1表示优先使用在线数据，0表示非优先使用在线数据 1 for online first, 0 for not online first
        /// </summary>
        /// <value>1表示优先使用在线数据，0表示非优先使用在线数据 1 for online first, 0 for not online first</value>
        [DataMember(Name="onlineFirst", EmitDefaultValue=false)]
        public int OnlineFirst { get; set; }

        /// <summary>
        /// 1表示进行自动修改，0表示不进行自动修正 1 for auto amend, 0 for not auto amend
        /// </summary>
        /// <value>1表示进行自动修改，0表示不进行自动修正 1 for auto amend, 0 for not auto amend</value>
        [DataMember(Name="autoAmend", EmitDefaultValue=false)]
        public int AutoAmend { get; set; }

        /// <summary>
        /// 方案的状态 scenario&#39;s status
        /// </summary>
        /// <value>方案的状态 scenario&#39;s status</value>
        [DataMember(Name="state", EmitDefaultValue=true)]
        public string State { get; set; }

        /// <summary>
        /// 方案的描述 scenario description
        /// </summary>
        /// <value>方案的描述 scenario description</value>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// 版本 version
        /// </summary>
        /// <value>版本 version</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public Guid Version { get; set; }

        /// <summary>
        /// 租户ID tenant Id
        /// </summary>
        /// <value>租户ID tenant Id</value>
        [DataMember(Name="tenantId", EmitDefaultValue=true)]
        public string TenantId { get; set; }

        /// <summary>
        /// 在分布式文件系统上的存储路径 store path on distributed file system
        /// </summary>
        /// <value>在分布式文件系统上的存储路径 store path on distributed file system</value>
        [DataMember(Name="minIOPath", EmitDefaultValue=true)]
        public string MinIOPath { get; set; }

        /// <summary>
        /// 在分布式文件系统上的存储桶 store bucket on distributed file system
        /// </summary>
        /// <value>在分布式文件系统上的存储桶 store bucket on distributed file system</value>
        [DataMember(Name="minIOBucket", EmitDefaultValue=true)]
        public string MinIOBucket { get; set; }

        /// <summary>
        /// Gets or Sets CreatorName
        /// </summary>
        [DataMember(Name="creatorName", EmitDefaultValue=true)]
        public string CreatorName { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Scenario {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ScenarioCode: ").Append(ScenarioCode).Append("\n");
            sb.Append("  ScenarioName: ").Append(ScenarioName).Append("\n");
            sb.Append("  ModelType: ").Append(ModelType).Append("\n");
            sb.Append("  ModelSubType: ").Append(ModelSubType).Append("\n");
            sb.Append("  Template: ").Append(Template).Append("\n");
            sb.Append("  InheritedScenario: ").Append(InheritedScenario).Append("\n");
            sb.Append("  ReadOnly: ").Append(ReadOnly).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  RelativeFolder: ").Append(RelativeFolder).Append("\n");
            sb.Append("  ProjectFile: ").Append(ProjectFile).Append("\n");
            sb.Append("  CurrentTime: ").Append(CurrentTime).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  CreateTime: ").Append(CreateTime).Append("\n");
            sb.Append("  AutoCalculate: ").Append(AutoCalculate).Append("\n");
            sb.Append("  Modified: ").Append(Modified).Append("\n");
            sb.Append("  Checked: ").Append(Checked).Append("\n");
            sb.Append("  Calculated: ").Append(Calculated).Append("\n");
            sb.Append("  Published: ").Append(Published).Append("\n");
            sb.Append("  OnlineFirst: ").Append(OnlineFirst).Append("\n");
            sb.Append("  AutoAmend: ").Append(AutoAmend).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  MinIOPath: ").Append(MinIOPath).Append("\n");
            sb.Append("  MinIOBucket: ").Append(MinIOBucket).Append("\n");
            sb.Append("  CreatorName: ").Append(CreatorName).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as Scenario);
        }

        /// <summary>
        /// Returns true if Scenario instances are equal
        /// </summary>
        /// <param name="input">Instance of Scenario to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Scenario input)
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
                    this.ScenarioCode == input.ScenarioCode ||
                    (this.ScenarioCode != null &&
                    this.ScenarioCode.Equals(input.ScenarioCode))
                ) && 
                (
                    this.ScenarioName == input.ScenarioName ||
                    (this.ScenarioName != null &&
                    this.ScenarioName.Equals(input.ScenarioName))
                ) && 
                (
                    this.ModelType == input.ModelType ||
                    (this.ModelType != null &&
                    this.ModelType.Equals(input.ModelType))
                ) && 
                (
                    this.ModelSubType == input.ModelSubType ||
                    (this.ModelSubType != null &&
                    this.ModelSubType.Equals(input.ModelSubType))
                ) && 
                (
                    this.Template == input.Template ||
                    this.Template.Equals(input.Template)
                ) && 
                (
                    this.InheritedScenario == input.InheritedScenario ||
                    (this.InheritedScenario != null &&
                    this.InheritedScenario.Equals(input.InheritedScenario))
                ) && 
                (
                    this.ReadOnly == input.ReadOnly ||
                    this.ReadOnly.Equals(input.ReadOnly)
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    this.Enabled.Equals(input.Enabled)
                ) && 
                (
                    this.RelativeFolder == input.RelativeFolder ||
                    (this.RelativeFolder != null &&
                    this.RelativeFolder.Equals(input.RelativeFolder))
                ) && 
                (
                    this.ProjectFile == input.ProjectFile ||
                    (this.ProjectFile != null &&
                    this.ProjectFile.Equals(input.ProjectFile))
                ) && 
                (
                    this.CurrentTime == input.CurrentTime ||
                    (this.CurrentTime != null &&
                    this.CurrentTime.Equals(input.CurrentTime))
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.CreateTime == input.CreateTime ||
                    (this.CreateTime != null &&
                    this.CreateTime.Equals(input.CreateTime))
                ) && 
                (
                    this.AutoCalculate == input.AutoCalculate ||
                    this.AutoCalculate.Equals(input.AutoCalculate)
                ) && 
                (
                    this.Modified == input.Modified ||
                    this.Modified.Equals(input.Modified)
                ) && 
                (
                    this.Checked == input.Checked ||
                    this.Checked.Equals(input.Checked)
                ) && 
                (
                    this.Calculated == input.Calculated ||
                    this.Calculated.Equals(input.Calculated)
                ) && 
                (
                    this.Published == input.Published ||
                    this.Published.Equals(input.Published)
                ) && 
                (
                    this.OnlineFirst == input.OnlineFirst ||
                    this.OnlineFirst.Equals(input.OnlineFirst)
                ) && 
                (
                    this.AutoAmend == input.AutoAmend ||
                    this.AutoAmend.Equals(input.AutoAmend)
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
                ) && 
                (
                    this.MinIOPath == input.MinIOPath ||
                    (this.MinIOPath != null &&
                    this.MinIOPath.Equals(input.MinIOPath))
                ) && 
                (
                    this.MinIOBucket == input.MinIOBucket ||
                    (this.MinIOBucket != null &&
                    this.MinIOBucket.Equals(input.MinIOBucket))
                ) && 
                (
                    this.CreatorName == input.CreatorName ||
                    (this.CreatorName != null &&
                    this.CreatorName.Equals(input.CreatorName))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.ScenarioCode != null)
                    hashCode = hashCode * 59 + this.ScenarioCode.GetHashCode();
                if (this.ScenarioName != null)
                    hashCode = hashCode * 59 + this.ScenarioName.GetHashCode();
                if (this.ModelType != null)
                    hashCode = hashCode * 59 + this.ModelType.GetHashCode();
                if (this.ModelSubType != null)
                    hashCode = hashCode * 59 + this.ModelSubType.GetHashCode();
                hashCode = hashCode * 59 + this.Template.GetHashCode();
                if (this.InheritedScenario != null)
                    hashCode = hashCode * 59 + this.InheritedScenario.GetHashCode();
                hashCode = hashCode * 59 + this.ReadOnly.GetHashCode();
                hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.RelativeFolder != null)
                    hashCode = hashCode * 59 + this.RelativeFolder.GetHashCode();
                if (this.ProjectFile != null)
                    hashCode = hashCode * 59 + this.ProjectFile.GetHashCode();
                if (this.CurrentTime != null)
                    hashCode = hashCode * 59 + this.CurrentTime.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.CreateTime != null)
                    hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                hashCode = hashCode * 59 + this.AutoCalculate.GetHashCode();
                hashCode = hashCode * 59 + this.Modified.GetHashCode();
                hashCode = hashCode * 59 + this.Checked.GetHashCode();
                hashCode = hashCode * 59 + this.Calculated.GetHashCode();
                hashCode = hashCode * 59 + this.Published.GetHashCode();
                hashCode = hashCode * 59 + this.OnlineFirst.GetHashCode();
                hashCode = hashCode * 59 + this.AutoAmend.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.MinIOPath != null)
                    hashCode = hashCode * 59 + this.MinIOPath.GetHashCode();
                if (this.MinIOBucket != null)
                    hashCode = hashCode * 59 + this.MinIOBucket.GetHashCode();
                if (this.CreatorName != null)
                    hashCode = hashCode * 59 + this.CreatorName.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
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
            // ScenarioCode (string) maxLength
            if(this.ScenarioCode != null && this.ScenarioCode.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ScenarioCode, length must be less than 100.", new [] { "ScenarioCode" });
            }

            // ScenarioCode (string) minLength
            if(this.ScenarioCode != null && this.ScenarioCode.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ScenarioCode, length must be greater than 0.", new [] { "ScenarioCode" });
            }

  
            // ScenarioName (string) maxLength
            if(this.ScenarioName != null && this.ScenarioName.Length > 200)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ScenarioName, length must be less than 200.", new [] { "ScenarioName" });
            }

            // ScenarioName (string) minLength
            if(this.ScenarioName != null && this.ScenarioName.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ScenarioName, length must be greater than 0.", new [] { "ScenarioName" });
            }

  
            // ModelType (string) maxLength
            if(this.ModelType != null && this.ModelType.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ModelType, length must be less than 100.", new [] { "ModelType" });
            }

            // ModelType (string) minLength
            if(this.ModelType != null && this.ModelType.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ModelType, length must be greater than 0.", new [] { "ModelType" });
            }

  
            // ModelSubType (string) maxLength
            if(this.ModelSubType != null && this.ModelSubType.Length > 200)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ModelSubType, length must be less than 200.", new [] { "ModelSubType" });
            }

            // ModelSubType (string) minLength
            if(this.ModelSubType != null && this.ModelSubType.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ModelSubType, length must be greater than 0.", new [] { "ModelSubType" });
            }

  
            // RelativeFolder (string) maxLength
            if(this.RelativeFolder != null && this.RelativeFolder.Length > 1000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RelativeFolder, length must be less than 1000.", new [] { "RelativeFolder" });
            }

            // RelativeFolder (string) minLength
            if(this.RelativeFolder != null && this.RelativeFolder.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RelativeFolder, length must be greater than 0.", new [] { "RelativeFolder" });
            }

  
            // ProjectFile (string) maxLength
            if(this.ProjectFile != null && this.ProjectFile.Length > 200)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ProjectFile, length must be less than 200.", new [] { "ProjectFile" });
            }

            // ProjectFile (string) minLength
            if(this.ProjectFile != null && this.ProjectFile.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ProjectFile, length must be greater than 0.", new [] { "ProjectFile" });
            }

  
            // State (string) maxLength
            if(this.State != null && this.State.Length > 200)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for State, length must be less than 200.", new [] { "State" });
            }

            // State (string) minLength
            if(this.State != null && this.State.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for State, length must be greater than 0.", new [] { "State" });
            }

  
            // Description (string) maxLength
            if(this.Description != null && this.Description.Length > 2000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be less than 2000.", new [] { "Description" });
            }

            // Description (string) minLength
            if(this.Description != null && this.Description.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be greater than 0.", new [] { "Description" });
            }

  
            // MinIOPath (string) maxLength
            if(this.MinIOPath != null && this.MinIOPath.Length > 1000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MinIOPath, length must be less than 1000.", new [] { "MinIOPath" });
            }

            // MinIOPath (string) minLength
            if(this.MinIOPath != null && this.MinIOPath.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MinIOPath, length must be greater than 0.", new [] { "MinIOPath" });
            }

  
            // MinIOBucket (string) maxLength
            if(this.MinIOBucket != null && this.MinIOBucket.Length > 200)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MinIOBucket, length must be less than 200.", new [] { "MinIOBucket" });
            }

            // MinIOBucket (string) minLength
            if(this.MinIOBucket != null && this.MinIOBucket.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MinIOBucket, length must be greater than 0.", new [] { "MinIOBucket" });
            }

  
            yield break;
        }
    }

}
