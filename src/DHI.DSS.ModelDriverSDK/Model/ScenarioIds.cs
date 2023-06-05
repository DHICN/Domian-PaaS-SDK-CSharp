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
    /// ScenarioIds
    /// </summary>
    [DataContract]
    public partial class ScenarioIds :  IEquatable<ScenarioIds>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScenarioIds" /> class.
        /// </summary>
        /// <param name="projectName">项目名称 project name.</param>
        /// <param name="scenarioIdStrings">方案ID列表 scenario ids.</param>
        public ScenarioIds(string projectName = default(string), List<string> scenarioIdStrings = default(List<string>))
        {
            this.ProjectName = projectName;
            this.ScenarioIdStrings = scenarioIdStrings;
        }
        
        /// <summary>
        /// 项目名称 project name
        /// </summary>
        /// <value>项目名称 project name</value>
        [DataMember(Name="projectName", EmitDefaultValue=true)]
        public string ProjectName { get; set; }

        /// <summary>
        /// 方案ID列表 scenario ids
        /// </summary>
        /// <value>方案ID列表 scenario ids</value>
        [DataMember(Name="scenarioIdStrings", EmitDefaultValue=true)]
        public List<string> ScenarioIdStrings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScenarioIds {\n");
            sb.Append("  ProjectName: ").Append(ProjectName).Append("\n");
            sb.Append("  ScenarioIdStrings: ").Append(ScenarioIdStrings).Append("\n");
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
            return this.Equals(input as ScenarioIds);
        }

        /// <summary>
        /// Returns true if ScenarioIds instances are equal
        /// </summary>
        /// <param name="input">Instance of ScenarioIds to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScenarioIds input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProjectName == input.ProjectName ||
                    (this.ProjectName != null &&
                    this.ProjectName.Equals(input.ProjectName))
                ) && 
                (
                    this.ScenarioIdStrings == input.ScenarioIdStrings ||
                    this.ScenarioIdStrings != null &&
                    input.ScenarioIdStrings != null &&
                    this.ScenarioIdStrings.SequenceEqual(input.ScenarioIdStrings)
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
                if (this.ProjectName != null)
                    hashCode = hashCode * 59 + this.ProjectName.GetHashCode();
                if (this.ScenarioIdStrings != null)
                    hashCode = hashCode * 59 + this.ScenarioIdStrings.GetHashCode();
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
