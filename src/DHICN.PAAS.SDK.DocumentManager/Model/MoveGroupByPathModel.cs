/* 
 * document-manager-service
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
using OpenAPIDateConverter = DHICN.PAAS.SDK.DocumentManager.Client.OpenAPIDateConverter;

namespace DHICN.PAAS.SDK.DocumentManager.Model
{
    /// <summary>
    /// MoveGroupByPathModel
    /// </summary>
    [DataContract]
    public partial class MoveGroupByPathModel :  IEquatable<MoveGroupByPathModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MoveGroupByPathModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MoveGroupByPathModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MoveGroupByPathModel" /> class.
        /// </summary>
        /// <param name="parentGroupPath">parentGroupPath.</param>
        /// <param name="movingGroupPath">movingGroupPath (required).</param>
        public MoveGroupByPathModel(string parentGroupPath = default(string), string movingGroupPath = default(string))
        {
            // to ensure "movingGroupPath" is required (not null)
            this.MovingGroupPath = movingGroupPath ?? throw new ArgumentNullException("movingGroupPath is a required property for MoveGroupByPathModel and cannot be null");
            this.ParentGroupPath = parentGroupPath;
        }
        
        /// <summary>
        /// Gets or Sets ParentGroupPath
        /// </summary>
        [DataMember(Name="parentGroupPath", EmitDefaultValue=true)]
        public string ParentGroupPath { get; set; }

        /// <summary>
        /// Gets or Sets MovingGroupPath
        /// </summary>
        [DataMember(Name="movingGroupPath", EmitDefaultValue=false)]
        public string MovingGroupPath { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MoveGroupByPathModel {\n");
            sb.Append("  ParentGroupPath: ").Append(ParentGroupPath).Append("\n");
            sb.Append("  MovingGroupPath: ").Append(MovingGroupPath).Append("\n");
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
            return this.Equals(input as MoveGroupByPathModel);
        }

        /// <summary>
        /// Returns true if MoveGroupByPathModel instances are equal
        /// </summary>
        /// <param name="input">Instance of MoveGroupByPathModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MoveGroupByPathModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ParentGroupPath == input.ParentGroupPath ||
                    (this.ParentGroupPath != null &&
                    this.ParentGroupPath.Equals(input.ParentGroupPath))
                ) && 
                (
                    this.MovingGroupPath == input.MovingGroupPath ||
                    (this.MovingGroupPath != null &&
                    this.MovingGroupPath.Equals(input.MovingGroupPath))
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
                if (this.ParentGroupPath != null)
                    hashCode = hashCode * 59 + this.ParentGroupPath.GetHashCode();
                if (this.MovingGroupPath != null)
                    hashCode = hashCode * 59 + this.MovingGroupPath.GetHashCode();
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
