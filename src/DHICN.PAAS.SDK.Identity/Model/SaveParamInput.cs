/* 
 * identity-service
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
using OpenAPIDateConverter = DHICN.PAAS.SDK.Identity.Client.OpenAPIDateConverter;

namespace DHICN.PAAS.SDK.Identity.Model
{
    /// <summary>
    /// SaveParamInput
    /// </summary>
    [DataContract]
    public partial class SaveParamInput :  IEquatable<SaveParamInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SaveParamInput" /> class.
        /// </summary>
        /// <param name="scenarioId">方案ID scenario id.</param>
        /// <param name="productLine">工艺线代码 product line code.</param>
        /// <param name="isNew">是否是新建方案 if the scenario is new.</param>
        /// <param name="modelParams">模型参数列表 moel parameter list.</param>
        public SaveParamInput(Guid scenarioId = default(Guid), string productLine = default(string), bool isNew = default(bool), List<ModelParam> modelParams = default(List<ModelParam>))
        {
            this.ScenarioId = scenarioId;
            this.ProductLine = productLine;
            this.IsNew = isNew;
            this.ModelParams = modelParams;
        }
        
        /// <summary>
        /// 方案ID scenario id
        /// </summary>
        /// <value>方案ID scenario id</value>
        [DataMember(Name="scenarioId", EmitDefaultValue=false)]
        public Guid ScenarioId { get; set; }

        /// <summary>
        /// 工艺线代码 product line code
        /// </summary>
        /// <value>工艺线代码 product line code</value>
        [DataMember(Name="productLine", EmitDefaultValue=true)]
        public string ProductLine { get; set; }

        /// <summary>
        /// 是否是新建方案 if the scenario is new
        /// </summary>
        /// <value>是否是新建方案 if the scenario is new</value>
        [DataMember(Name="isNew", EmitDefaultValue=false)]
        public bool IsNew { get; set; }

        /// <summary>
        /// 模型参数列表 moel parameter list
        /// </summary>
        /// <value>模型参数列表 moel parameter list</value>
        [DataMember(Name="modelParams", EmitDefaultValue=true)]
        public List<ModelParam> ModelParams { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SaveParamInput {\n");
            sb.Append("  ScenarioId: ").Append(ScenarioId).Append("\n");
            sb.Append("  ProductLine: ").Append(ProductLine).Append("\n");
            sb.Append("  IsNew: ").Append(IsNew).Append("\n");
            sb.Append("  ModelParams: ").Append(ModelParams).Append("\n");
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
            return this.Equals(input as SaveParamInput);
        }

        /// <summary>
        /// Returns true if SaveParamInput instances are equal
        /// </summary>
        /// <param name="input">Instance of SaveParamInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SaveParamInput input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ScenarioId == input.ScenarioId ||
                    (this.ScenarioId != null &&
                    this.ScenarioId.Equals(input.ScenarioId))
                ) && 
                (
                    this.ProductLine == input.ProductLine ||
                    (this.ProductLine != null &&
                    this.ProductLine.Equals(input.ProductLine))
                ) && 
                (
                    this.IsNew == input.IsNew ||
                    this.IsNew.Equals(input.IsNew)
                ) && 
                (
                    this.ModelParams == input.ModelParams ||
                    this.ModelParams != null &&
                    input.ModelParams != null &&
                    this.ModelParams.SequenceEqual(input.ModelParams)
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
                if (this.ScenarioId != null)
                    hashCode = hashCode * 59 + this.ScenarioId.GetHashCode();
                if (this.ProductLine != null)
                    hashCode = hashCode * 59 + this.ProductLine.GetHashCode();
                hashCode = hashCode * 59 + this.IsNew.GetHashCode();
                if (this.ModelParams != null)
                    hashCode = hashCode * 59 + this.ModelParams.GetHashCode();
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
