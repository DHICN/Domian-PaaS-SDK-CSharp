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
    /// TurnOnTemplatePara
    /// </summary>
    [DataContract]
    public partial class TurnOnTemplatePara :  IEquatable<TurnOnTemplatePara>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TurnOnTemplatePara" /> class.
        /// </summary>
        /// <param name="libraryId">库的ID Library&#39;s Id.</param>
        /// <param name="templateId">需要启用的模板方案的ID Template scenario&#39;s Id to be turned on.</param>
        public TurnOnTemplatePara(Guid libraryId = default(Guid), Guid templateId = default(Guid))
        {
            this.LibraryId = libraryId;
            this.TemplateId = templateId;
        }
        
        /// <summary>
        /// 库的ID Library&#39;s Id
        /// </summary>
        /// <value>库的ID Library&#39;s Id</value>
        [DataMember(Name="libraryId", EmitDefaultValue=false)]
        public Guid LibraryId { get; set; }

        /// <summary>
        /// 需要启用的模板方案的ID Template scenario&#39;s Id to be turned on
        /// </summary>
        /// <value>需要启用的模板方案的ID Template scenario&#39;s Id to be turned on</value>
        [DataMember(Name="templateId", EmitDefaultValue=false)]
        public Guid TemplateId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TurnOnTemplatePara {\n");
            sb.Append("  LibraryId: ").Append(LibraryId).Append("\n");
            sb.Append("  TemplateId: ").Append(TemplateId).Append("\n");
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
            return this.Equals(input as TurnOnTemplatePara);
        }

        /// <summary>
        /// Returns true if TurnOnTemplatePara instances are equal
        /// </summary>
        /// <param name="input">Instance of TurnOnTemplatePara to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TurnOnTemplatePara input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LibraryId == input.LibraryId ||
                    (this.LibraryId != null &&
                    this.LibraryId.Equals(input.LibraryId))
                ) && 
                (
                    this.TemplateId == input.TemplateId ||
                    (this.TemplateId != null &&
                    this.TemplateId.Equals(input.TemplateId))
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
                if (this.LibraryId != null)
                    hashCode = hashCode * 59 + this.LibraryId.GetHashCode();
                if (this.TemplateId != null)
                    hashCode = hashCode * 59 + this.TemplateId.GetHashCode();
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
