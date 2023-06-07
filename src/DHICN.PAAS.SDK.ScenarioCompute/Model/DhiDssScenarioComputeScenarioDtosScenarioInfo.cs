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
    /// DhiDssScenarioComputeScenarioDtosScenarioInfo
    /// </summary>
    [DataContract]
    public partial class DhiDssScenarioComputeScenarioDtosScenarioInfo :  IEquatable<DhiDssScenarioComputeScenarioDtosScenarioInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DhiDssScenarioComputeScenarioDtosScenarioInfo" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="minIOBucket">minIOBucket.</param>
        /// <param name="minIOPath">minIOPath.</param>
        /// <param name="tenantId">tenantId.</param>
        /// <param name="version">version.</param>
        /// <param name="description">description.</param>
        /// <param name="state">state.</param>
        /// <param name="autoAmend">autoAmend.</param>
        /// <param name="onlineFirst">onlineFirst.</param>
        /// <param name="published">published.</param>
        /// <param name="calculated">calculated.</param>
        /// <param name="_checked">_checked.</param>
        /// <param name="modified">modified.</param>
        /// <param name="autoCalculate">autoCalculate.</param>
        /// <param name="createTime">createTime.</param>
        /// <param name="endTime">endTime.</param>
        /// <param name="startTime">startTime.</param>
        /// <param name="currentTime">currentTime.</param>
        /// <param name="projectFile">projectFile.</param>
        /// <param name="relativeFolder">relativeFolder.</param>
        /// <param name="enabled">enabled.</param>
        /// <param name="readOnly">readOnly.</param>
        /// <param name="inheritedScenario">inheritedScenario.</param>
        /// <param name="id">id.</param>
        /// <param name="scenarioCode">scenarioCode.</param>
        /// <param name="scenarioName">scenarioName.</param>
        /// <param name="modelType">modelType.</param>
        /// <param name="modelSubType">modelSubType.</param>
        /// <param name="template">template.</param>
        public DhiDssScenarioComputeScenarioDtosScenarioInfo(string name = default(string), string minIOBucket = default(string), string minIOPath = default(string), string tenantId = default(string), string version = default(string), string description = default(string), string state = default(string), int autoAmend = default(int), int onlineFirst = default(int), int published = default(int), int calculated = default(int), int _checked = default(int), int modified = default(int), int autoCalculate = default(int), string createTime = default(string), string endTime = default(string), string startTime = default(string), string currentTime = default(string), string projectFile = default(string), string relativeFolder = default(string), int enabled = default(int), int readOnly = default(int), Guid inheritedScenario = default(Guid), Guid id = default(Guid), string scenarioCode = default(string), string scenarioName = default(string), string modelType = default(string), string modelSubType = default(string), int template = default(int))
        {
            this.Name = name;
            this.MinIOBucket = minIOBucket;
            this.MinIOPath = minIOPath;
            this.TenantId = tenantId;
            this.Version = version;
            this.Description = description;
            this.State = state;
            this.AutoAmend = autoAmend;
            this.OnlineFirst = onlineFirst;
            this.Published = published;
            this.Calculated = calculated;
            this.Checked = _checked;
            this.Modified = modified;
            this.AutoCalculate = autoCalculate;
            this.CreateTime = createTime;
            this.EndTime = endTime;
            this.StartTime = startTime;
            this.CurrentTime = currentTime;
            this.ProjectFile = projectFile;
            this.RelativeFolder = relativeFolder;
            this.Enabled = enabled;
            this.ReadOnly = readOnly;
            this.InheritedScenario = inheritedScenario;
            this.Id = id;
            this.ScenarioCode = scenarioCode;
            this.ScenarioName = scenarioName;
            this.ModelType = modelType;
            this.ModelSubType = modelSubType;
            this.Template = template;
        }
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets MinIOBucket
        /// </summary>
        [DataMember(Name="minIOBucket", EmitDefaultValue=true)]
        public string MinIOBucket { get; set; }

        /// <summary>
        /// Gets or Sets MinIOPath
        /// </summary>
        [DataMember(Name="minIOPath", EmitDefaultValue=true)]
        public string MinIOPath { get; set; }

        /// <summary>
        /// Gets or Sets TenantId
        /// </summary>
        [DataMember(Name="tenantId", EmitDefaultValue=true)]
        public string TenantId { get; set; }

        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name="version", EmitDefaultValue=true)]
        public string Version { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=true)]
        public string State { get; set; }

        /// <summary>
        /// Gets or Sets AutoAmend
        /// </summary>
        [DataMember(Name="autoAmend", EmitDefaultValue=false)]
        public int AutoAmend { get; set; }

        /// <summary>
        /// Gets or Sets OnlineFirst
        /// </summary>
        [DataMember(Name="onlineFirst", EmitDefaultValue=false)]
        public int OnlineFirst { get; set; }

        /// <summary>
        /// Gets or Sets Published
        /// </summary>
        [DataMember(Name="published", EmitDefaultValue=false)]
        public int Published { get; set; }

        /// <summary>
        /// Gets or Sets Calculated
        /// </summary>
        [DataMember(Name="calculated", EmitDefaultValue=false)]
        public int Calculated { get; set; }

        /// <summary>
        /// Gets or Sets Checked
        /// </summary>
        [DataMember(Name="checked", EmitDefaultValue=false)]
        public int Checked { get; set; }

        /// <summary>
        /// Gets or Sets Modified
        /// </summary>
        [DataMember(Name="modified", EmitDefaultValue=false)]
        public int Modified { get; set; }

        /// <summary>
        /// Gets or Sets AutoCalculate
        /// </summary>
        [DataMember(Name="autoCalculate", EmitDefaultValue=false)]
        public int AutoCalculate { get; set; }

        /// <summary>
        /// Gets or Sets CreateTime
        /// </summary>
        [DataMember(Name="createTime", EmitDefaultValue=true)]
        public string CreateTime { get; set; }

        /// <summary>
        /// Gets or Sets EndTime
        /// </summary>
        [DataMember(Name="endTime", EmitDefaultValue=true)]
        public string EndTime { get; set; }

        /// <summary>
        /// Gets or Sets StartTime
        /// </summary>
        [DataMember(Name="startTime", EmitDefaultValue=true)]
        public string StartTime { get; set; }

        /// <summary>
        /// Gets or Sets CurrentTime
        /// </summary>
        [DataMember(Name="currentTime", EmitDefaultValue=true)]
        public string CurrentTime { get; set; }

        /// <summary>
        /// Gets or Sets ProjectFile
        /// </summary>
        [DataMember(Name="projectFile", EmitDefaultValue=true)]
        public string ProjectFile { get; set; }

        /// <summary>
        /// Gets or Sets RelativeFolder
        /// </summary>
        [DataMember(Name="relativeFolder", EmitDefaultValue=true)]
        public string RelativeFolder { get; set; }

        /// <summary>
        /// Gets or Sets Enabled
        /// </summary>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public int Enabled { get; set; }

        /// <summary>
        /// Gets or Sets ReadOnly
        /// </summary>
        [DataMember(Name="readOnly", EmitDefaultValue=false)]
        public int ReadOnly { get; set; }

        /// <summary>
        /// Gets or Sets InheritedScenario
        /// </summary>
        [DataMember(Name="inheritedScenario", EmitDefaultValue=false)]
        public Guid InheritedScenario { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets ScenarioCode
        /// </summary>
        [DataMember(Name="scenarioCode", EmitDefaultValue=true)]
        public string ScenarioCode { get; set; }

        /// <summary>
        /// Gets or Sets ScenarioName
        /// </summary>
        [DataMember(Name="scenarioName", EmitDefaultValue=true)]
        public string ScenarioName { get; set; }

        /// <summary>
        /// Gets or Sets ModelType
        /// </summary>
        [DataMember(Name="modelType", EmitDefaultValue=true)]
        public string ModelType { get; set; }

        /// <summary>
        /// Gets or Sets ModelSubType
        /// </summary>
        [DataMember(Name="modelSubType", EmitDefaultValue=true)]
        public string ModelSubType { get; set; }

        /// <summary>
        /// Gets or Sets Template
        /// </summary>
        [DataMember(Name="template", EmitDefaultValue=false)]
        public int Template { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DhiDssScenarioComputeScenarioDtosScenarioInfo {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  MinIOBucket: ").Append(MinIOBucket).Append("\n");
            sb.Append("  MinIOPath: ").Append(MinIOPath).Append("\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  AutoAmend: ").Append(AutoAmend).Append("\n");
            sb.Append("  OnlineFirst: ").Append(OnlineFirst).Append("\n");
            sb.Append("  Published: ").Append(Published).Append("\n");
            sb.Append("  Calculated: ").Append(Calculated).Append("\n");
            sb.Append("  Checked: ").Append(Checked).Append("\n");
            sb.Append("  Modified: ").Append(Modified).Append("\n");
            sb.Append("  AutoCalculate: ").Append(AutoCalculate).Append("\n");
            sb.Append("  CreateTime: ").Append(CreateTime).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  CurrentTime: ").Append(CurrentTime).Append("\n");
            sb.Append("  ProjectFile: ").Append(ProjectFile).Append("\n");
            sb.Append("  RelativeFolder: ").Append(RelativeFolder).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  ReadOnly: ").Append(ReadOnly).Append("\n");
            sb.Append("  InheritedScenario: ").Append(InheritedScenario).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ScenarioCode: ").Append(ScenarioCode).Append("\n");
            sb.Append("  ScenarioName: ").Append(ScenarioName).Append("\n");
            sb.Append("  ModelType: ").Append(ModelType).Append("\n");
            sb.Append("  ModelSubType: ").Append(ModelSubType).Append("\n");
            sb.Append("  Template: ").Append(Template).Append("\n");
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
            return this.Equals(input as DhiDssScenarioComputeScenarioDtosScenarioInfo);
        }

        /// <summary>
        /// Returns true if DhiDssScenarioComputeScenarioDtosScenarioInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of DhiDssScenarioComputeScenarioDtosScenarioInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DhiDssScenarioComputeScenarioDtosScenarioInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.MinIOBucket == input.MinIOBucket ||
                    (this.MinIOBucket != null &&
                    this.MinIOBucket.Equals(input.MinIOBucket))
                ) && 
                (
                    this.MinIOPath == input.MinIOPath ||
                    (this.MinIOPath != null &&
                    this.MinIOPath.Equals(input.MinIOPath))
                ) && 
                (
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.AutoAmend == input.AutoAmend ||
                    this.AutoAmend.Equals(input.AutoAmend)
                ) && 
                (
                    this.OnlineFirst == input.OnlineFirst ||
                    this.OnlineFirst.Equals(input.OnlineFirst)
                ) && 
                (
                    this.Published == input.Published ||
                    this.Published.Equals(input.Published)
                ) && 
                (
                    this.Calculated == input.Calculated ||
                    this.Calculated.Equals(input.Calculated)
                ) && 
                (
                    this.Checked == input.Checked ||
                    this.Checked.Equals(input.Checked)
                ) && 
                (
                    this.Modified == input.Modified ||
                    this.Modified.Equals(input.Modified)
                ) && 
                (
                    this.AutoCalculate == input.AutoCalculate ||
                    this.AutoCalculate.Equals(input.AutoCalculate)
                ) && 
                (
                    this.CreateTime == input.CreateTime ||
                    (this.CreateTime != null &&
                    this.CreateTime.Equals(input.CreateTime))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.CurrentTime == input.CurrentTime ||
                    (this.CurrentTime != null &&
                    this.CurrentTime.Equals(input.CurrentTime))
                ) && 
                (
                    this.ProjectFile == input.ProjectFile ||
                    (this.ProjectFile != null &&
                    this.ProjectFile.Equals(input.ProjectFile))
                ) && 
                (
                    this.RelativeFolder == input.RelativeFolder ||
                    (this.RelativeFolder != null &&
                    this.RelativeFolder.Equals(input.RelativeFolder))
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    this.Enabled.Equals(input.Enabled)
                ) && 
                (
                    this.ReadOnly == input.ReadOnly ||
                    this.ReadOnly.Equals(input.ReadOnly)
                ) && 
                (
                    this.InheritedScenario == input.InheritedScenario ||
                    (this.InheritedScenario != null &&
                    this.InheritedScenario.Equals(input.InheritedScenario))
                ) && 
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.MinIOBucket != null)
                    hashCode = hashCode * 59 + this.MinIOBucket.GetHashCode();
                if (this.MinIOPath != null)
                    hashCode = hashCode * 59 + this.MinIOPath.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                hashCode = hashCode * 59 + this.AutoAmend.GetHashCode();
                hashCode = hashCode * 59 + this.OnlineFirst.GetHashCode();
                hashCode = hashCode * 59 + this.Published.GetHashCode();
                hashCode = hashCode * 59 + this.Calculated.GetHashCode();
                hashCode = hashCode * 59 + this.Checked.GetHashCode();
                hashCode = hashCode * 59 + this.Modified.GetHashCode();
                hashCode = hashCode * 59 + this.AutoCalculate.GetHashCode();
                if (this.CreateTime != null)
                    hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.CurrentTime != null)
                    hashCode = hashCode * 59 + this.CurrentTime.GetHashCode();
                if (this.ProjectFile != null)
                    hashCode = hashCode * 59 + this.ProjectFile.GetHashCode();
                if (this.RelativeFolder != null)
                    hashCode = hashCode * 59 + this.RelativeFolder.GetHashCode();
                hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                hashCode = hashCode * 59 + this.ReadOnly.GetHashCode();
                if (this.InheritedScenario != null)
                    hashCode = hashCode * 59 + this.InheritedScenario.GetHashCode();
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