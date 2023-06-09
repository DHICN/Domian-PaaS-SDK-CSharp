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
using OpenAPIDateConverter = DHICN.PAAS.SDK.ScenarioManager.Client.OpenAPIDateConverter;

namespace DHICN.PAAS.SDK.ScenarioManager.Model
{
    /// <summary>
    /// CreateTemplateScenarioPara2
    /// </summary>
    [DataContract]
    public partial class CreateTemplateScenarioPara2 :  IEquatable<CreateTemplateScenarioPara2>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTemplateScenarioPara2" /> class.
        /// </summary>
        /// <param name="modelFile">模型文件的绝对路径 absolute path of the model file.</param>
        /// <param name="groupId">模板的方案组ID template scenario&#39;s group Id.</param>
        /// <param name="newTemplateName">模板方案名称 template scenario name.</param>
        /// <param name="subType">模板方案的子类型 template scenario subtype.</param>
        /// <param name="description">模板方案描述 template scenario description.</param>
        public CreateTemplateScenarioPara2(string modelFile = default(string), string groupId = default(string), string newTemplateName = default(string), string subType = default(string), string description = default(string))
        {
            this.ModelFile = modelFile;
            this.GroupId = groupId;
            this.NewTemplateName = newTemplateName;
            this.SubType = subType;
            this.Description = description;
        }
        
        /// <summary>
        /// 模型文件的绝对路径 absolute path of the model file
        /// </summary>
        /// <value>模型文件的绝对路径 absolute path of the model file</value>
        [DataMember(Name="modelFile", EmitDefaultValue=true)]
        public string ModelFile { get; set; }

        /// <summary>
        /// 模板的方案组ID template scenario&#39;s group Id
        /// </summary>
        /// <value>模板的方案组ID template scenario&#39;s group Id</value>
        [DataMember(Name="groupId", EmitDefaultValue=true)]
        public string GroupId { get; set; }

        /// <summary>
        /// 模板方案名称 template scenario name
        /// </summary>
        /// <value>模板方案名称 template scenario name</value>
        [DataMember(Name="newTemplateName", EmitDefaultValue=true)]
        public string NewTemplateName { get; set; }

        /// <summary>
        /// 模板方案的子类型 template scenario subtype
        /// </summary>
        /// <value>模板方案的子类型 template scenario subtype</value>
        [DataMember(Name="subType", EmitDefaultValue=true)]
        public string SubType { get; set; }

        /// <summary>
        /// 模板方案描述 template scenario description
        /// </summary>
        /// <value>模板方案描述 template scenario description</value>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateTemplateScenarioPara2 {\n");
            sb.Append("  ModelFile: ").Append(ModelFile).Append("\n");
            sb.Append("  GroupId: ").Append(GroupId).Append("\n");
            sb.Append("  NewTemplateName: ").Append(NewTemplateName).Append("\n");
            sb.Append("  SubType: ").Append(SubType).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return this.Equals(input as CreateTemplateScenarioPara2);
        }

        /// <summary>
        /// Returns true if CreateTemplateScenarioPara2 instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateTemplateScenarioPara2 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateTemplateScenarioPara2 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ModelFile == input.ModelFile ||
                    (this.ModelFile != null &&
                    this.ModelFile.Equals(input.ModelFile))
                ) && 
                (
                    this.GroupId == input.GroupId ||
                    (this.GroupId != null &&
                    this.GroupId.Equals(input.GroupId))
                ) && 
                (
                    this.NewTemplateName == input.NewTemplateName ||
                    (this.NewTemplateName != null &&
                    this.NewTemplateName.Equals(input.NewTemplateName))
                ) && 
                (
                    this.SubType == input.SubType ||
                    (this.SubType != null &&
                    this.SubType.Equals(input.SubType))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                if (this.ModelFile != null)
                    hashCode = hashCode * 59 + this.ModelFile.GetHashCode();
                if (this.GroupId != null)
                    hashCode = hashCode * 59 + this.GroupId.GetHashCode();
                if (this.NewTemplateName != null)
                    hashCode = hashCode * 59 + this.NewTemplateName.GetHashCode();
                if (this.SubType != null)
                    hashCode = hashCode * 59 + this.SubType.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
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
