/* 
 * result-analysis-service
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
using OpenAPIDateConverter = DHICN.PAAS.SDK.ResultAnalysis.Client.OpenAPIDateConverter;

namespace DHICN.PAAS.SDK.ResultAnalysis.Model
{
    /// <summary>
    /// ModelResultTimesOutput
    /// </summary>
    [DataContract]
    public partial class ModelResultTimesOutput :  IEquatable<ModelResultTimesOutput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelResultTimesOutput" /> class.
        /// </summary>
        /// <param name="id">唯一标识 id.</param>
        /// <param name="resultType">结果类型（Pipe/Node/Flow/Pressure/Velocity等） result type(Pipe/Node/Flow/Pressure/Velocity and so on).</param>
        /// <param name="startTime">startTime.</param>
        /// <param name="endTime">结束时间 end time.</param>
        /// <param name="timeStep">时间步长 单位 s time step (unit:s).</param>
        /// <param name="timeNo">时间序列总数  time number.</param>
        public ModelResultTimesOutput(Guid id = default(Guid), string resultType = default(string), string startTime = default(string), string endTime = default(string), int timeStep = default(int), int timeNo = default(int))
        {
            this.Id = id;
            this.ResultType = resultType;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.TimeStep = timeStep;
            this.TimeNo = timeNo;
        }
        
        /// <summary>
        /// 唯一标识 id
        /// </summary>
        /// <value>唯一标识 id</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid Id { get; set; }

        /// <summary>
        /// 结果类型（Pipe/Node/Flow/Pressure/Velocity等） result type(Pipe/Node/Flow/Pressure/Velocity and so on)
        /// </summary>
        /// <value>结果类型（Pipe/Node/Flow/Pressure/Velocity等） result type(Pipe/Node/Flow/Pressure/Velocity and so on)</value>
        [DataMember(Name="resultType", EmitDefaultValue=true)]
        public string ResultType { get; set; }

        /// <summary>
        /// Gets or Sets StartTime
        /// </summary>
        [DataMember(Name="startTime", EmitDefaultValue=true)]
        public string StartTime { get; set; }

        /// <summary>
        /// 结束时间 end time
        /// </summary>
        /// <value>结束时间 end time</value>
        [DataMember(Name="endTime", EmitDefaultValue=true)]
        public string EndTime { get; set; }

        /// <summary>
        /// 时间步长 单位 s time step (unit:s)
        /// </summary>
        /// <value>时间步长 单位 s time step (unit:s)</value>
        [DataMember(Name="timeStep", EmitDefaultValue=false)]
        public int TimeStep { get; set; }

        /// <summary>
        /// 时间序列总数  time number
        /// </summary>
        /// <value>时间序列总数  time number</value>
        [DataMember(Name="timeNo", EmitDefaultValue=false)]
        public int TimeNo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModelResultTimesOutput {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ResultType: ").Append(ResultType).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  TimeStep: ").Append(TimeStep).Append("\n");
            sb.Append("  TimeNo: ").Append(TimeNo).Append("\n");
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
            return this.Equals(input as ModelResultTimesOutput);
        }

        /// <summary>
        /// Returns true if ModelResultTimesOutput instances are equal
        /// </summary>
        /// <param name="input">Instance of ModelResultTimesOutput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModelResultTimesOutput input)
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
                    this.ResultType == input.ResultType ||
                    (this.ResultType != null &&
                    this.ResultType.Equals(input.ResultType))
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
                    this.TimeStep == input.TimeStep ||
                    this.TimeStep.Equals(input.TimeStep)
                ) && 
                (
                    this.TimeNo == input.TimeNo ||
                    this.TimeNo.Equals(input.TimeNo)
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
                if (this.ResultType != null)
                    hashCode = hashCode * 59 + this.ResultType.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                hashCode = hashCode * 59 + this.TimeStep.GetHashCode();
                hashCode = hashCode * 59 + this.TimeNo.GetHashCode();
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
