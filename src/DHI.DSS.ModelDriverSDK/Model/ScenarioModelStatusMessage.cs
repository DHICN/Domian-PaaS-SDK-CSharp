/* 
 * model-driver-service
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
using OpenAPIDateConverter = DHI.DSS.ModelDriverSDK.Client.OpenAPIDateConverter;

namespace DHI.DSS.ModelDriverSDK.Model
{
    /// <summary>
    /// ScenarioModelStatusMessage
    /// </summary>
    [DataContract]
    public partial class ScenarioModelStatusMessage :  IEquatable<ScenarioModelStatusMessage>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Stage
        /// </summary>
        [DataMember(Name="stage", EmitDefaultValue=false)]
        public ModelState? Stage { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ScenarioModelStatusMessage" /> class.
        /// </summary>
        /// <param name="appId">计算服务id Computer service app id.</param>
        /// <param name="projectName">项目名称 project name.</param>
        /// <param name="scenarioId">方案ID scenario id.</param>
        /// <param name="serialNo">序列ID serial id.</param>
        /// <param name="stage">stage.</param>
        /// <param name="processStatus">进度状态 Process status.</param>
        /// <param name="dateTime">状态更新时间 status last modification time.</param>
        /// <param name="hasError">是否存在错误 if error existed.</param>
        /// <param name="message">包含进度信息的计算日志信息 log message with progress.</param>
        public ScenarioModelStatusMessage(string appId = default(string), string projectName = default(string), Guid scenarioId = default(Guid), Guid serialNo = default(Guid), ModelState? stage = default(ModelState?), float processStatus = default(float), DateTime dateTime = default(DateTime), bool hasError = default(bool), string message = default(string))
        {
            this.AppId = appId;
            this.ProjectName = projectName;
            this.ScenarioId = scenarioId;
            this.SerialNo = serialNo;
            this.Stage = stage;
            this.ProcessStatus = processStatus;
            this.DateTime = dateTime;
            this.HasError = hasError;
            this.Message = message;
        }
        
        /// <summary>
        /// 计算服务id Computer service app id
        /// </summary>
        /// <value>计算服务id Computer service app id</value>
        [DataMember(Name="appId", EmitDefaultValue=true)]
        public string AppId { get; set; }

        /// <summary>
        /// 项目名称 project name
        /// </summary>
        /// <value>项目名称 project name</value>
        [DataMember(Name="projectName", EmitDefaultValue=true)]
        public string ProjectName { get; set; }

        /// <summary>
        /// 方案ID scenario id
        /// </summary>
        /// <value>方案ID scenario id</value>
        [DataMember(Name="scenarioId", EmitDefaultValue=false)]
        public Guid ScenarioId { get; set; }

        /// <summary>
        /// 序列ID serial id
        /// </summary>
        /// <value>序列ID serial id</value>
        [DataMember(Name="serialNo", EmitDefaultValue=false)]
        public Guid SerialNo { get; set; }

        /// <summary>
        /// 进度状态 Process status
        /// </summary>
        /// <value>进度状态 Process status</value>
        [DataMember(Name="processStatus", EmitDefaultValue=false)]
        public float ProcessStatus { get; set; }

        /// <summary>
        /// 状态更新时间 status last modification time
        /// </summary>
        /// <value>状态更新时间 status last modification time</value>
        [DataMember(Name="dateTime", EmitDefaultValue=false)]
        public DateTime DateTime { get; set; }

        /// <summary>
        /// 是否存在错误 if error existed
        /// </summary>
        /// <value>是否存在错误 if error existed</value>
        [DataMember(Name="hasError", EmitDefaultValue=false)]
        public bool HasError { get; set; }

        /// <summary>
        /// 包含进度信息的计算日志信息 log message with progress
        /// </summary>
        /// <value>包含进度信息的计算日志信息 log message with progress</value>
        [DataMember(Name="message", EmitDefaultValue=true)]
        public string Message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScenarioModelStatusMessage {\n");
            sb.Append("  AppId: ").Append(AppId).Append("\n");
            sb.Append("  ProjectName: ").Append(ProjectName).Append("\n");
            sb.Append("  ScenarioId: ").Append(ScenarioId).Append("\n");
            sb.Append("  SerialNo: ").Append(SerialNo).Append("\n");
            sb.Append("  Stage: ").Append(Stage).Append("\n");
            sb.Append("  ProcessStatus: ").Append(ProcessStatus).Append("\n");
            sb.Append("  DateTime: ").Append(DateTime).Append("\n");
            sb.Append("  HasError: ").Append(HasError).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
            return this.Equals(input as ScenarioModelStatusMessage);
        }

        /// <summary>
        /// Returns true if ScenarioModelStatusMessage instances are equal
        /// </summary>
        /// <param name="input">Instance of ScenarioModelStatusMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScenarioModelStatusMessage input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AppId == input.AppId ||
                    (this.AppId != null &&
                    this.AppId.Equals(input.AppId))
                ) && 
                (
                    this.ProjectName == input.ProjectName ||
                    (this.ProjectName != null &&
                    this.ProjectName.Equals(input.ProjectName))
                ) && 
                (
                    this.ScenarioId == input.ScenarioId ||
                    (this.ScenarioId != null &&
                    this.ScenarioId.Equals(input.ScenarioId))
                ) && 
                (
                    this.SerialNo == input.SerialNo ||
                    (this.SerialNo != null &&
                    this.SerialNo.Equals(input.SerialNo))
                ) && 
                (
                    this.Stage == input.Stage ||
                    this.Stage.Equals(input.Stage)
                ) && 
                (
                    this.ProcessStatus == input.ProcessStatus ||
                    this.ProcessStatus.Equals(input.ProcessStatus)
                ) && 
                (
                    this.DateTime == input.DateTime ||
                    (this.DateTime != null &&
                    this.DateTime.Equals(input.DateTime))
                ) && 
                (
                    this.HasError == input.HasError ||
                    this.HasError.Equals(input.HasError)
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
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
                if (this.AppId != null)
                    hashCode = hashCode * 59 + this.AppId.GetHashCode();
                if (this.ProjectName != null)
                    hashCode = hashCode * 59 + this.ProjectName.GetHashCode();
                if (this.ScenarioId != null)
                    hashCode = hashCode * 59 + this.ScenarioId.GetHashCode();
                if (this.SerialNo != null)
                    hashCode = hashCode * 59 + this.SerialNo.GetHashCode();
                hashCode = hashCode * 59 + this.Stage.GetHashCode();
                hashCode = hashCode * 59 + this.ProcessStatus.GetHashCode();
                if (this.DateTime != null)
                    hashCode = hashCode * 59 + this.DateTime.GetHashCode();
                hashCode = hashCode * 59 + this.HasError.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
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