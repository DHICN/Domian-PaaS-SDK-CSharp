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
using OpenAPIDateConverter = DHICN.PAAS.SDK.ModelDriver.Client.OpenAPIDateConverter;

namespace DHICN.PAAS.SDK.ModelDriver.Model
{
    /// <summary>
    /// ModelTypePara
    /// </summary>
    [DataContract]
    public partial class ModelTypePara :  IEquatable<ModelTypePara>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelTypePara" /> class.
        /// </summary>
        /// <param name="projectName">项目名称 project name.</param>
        /// <param name="modelType">模型类型，不同类型对应不同的计算服务 model type, different type corresond to different compute service.</param>
        public ModelTypePara(string projectName = default(string), string modelType = default(string))
        {
            this.ProjectName = projectName;
            this.ModelType = modelType;
        }
        
        /// <summary>
        /// 项目名称 project name
        /// </summary>
        /// <value>项目名称 project name</value>
        [DataMember(Name="projectName", EmitDefaultValue=true)]
        public string ProjectName { get; set; }

        /// <summary>
        /// 模型类型，不同类型对应不同的计算服务 model type, different type corresond to different compute service
        /// </summary>
        /// <value>模型类型，不同类型对应不同的计算服务 model type, different type corresond to different compute service</value>
        [DataMember(Name="modelType", EmitDefaultValue=true)]
        public string ModelType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModelTypePara {\n");
            sb.Append("  ProjectName: ").Append(ProjectName).Append("\n");
            sb.Append("  ModelType: ").Append(ModelType).Append("\n");
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
            return this.Equals(input as ModelTypePara);
        }

        /// <summary>
        /// Returns true if ModelTypePara instances are equal
        /// </summary>
        /// <param name="input">Instance of ModelTypePara to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModelTypePara input)
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
                    this.ModelType == input.ModelType ||
                    (this.ModelType != null &&
                    this.ModelType.Equals(input.ModelType))
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
                if (this.ModelType != null)
                    hashCode = hashCode * 59 + this.ModelType.GetHashCode();
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
