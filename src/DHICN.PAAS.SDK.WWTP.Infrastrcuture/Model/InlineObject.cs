/* 
 * wwtp-paas-infrastructure-service
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
using OpenAPIDateConverter = DHICN.PAAS.SDK.WWTP.Infrastrcuture.Client.OpenAPIDateConverter;

namespace DHICN.PAAS.SDK.WWTP.Infrastrcuture.Model
{
    /// <summary>
    /// InlineObject
    /// </summary>
    [DataContract]
    public partial class InlineObject :  IEquatable<InlineObject>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineObject" /> class.
        /// </summary>
        /// <param name="excelFile">excelFile.</param>
        public InlineObject(System.IO.Stream excelFile = default(System.IO.Stream))
        {
            this.ExcelFile = excelFile;
        }
        
        /// <summary>
        /// Gets or Sets ExcelFile
        /// </summary>
        [DataMember(Name="excelFile", EmitDefaultValue=false)]
        public System.IO.Stream ExcelFile { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineObject {\n");
            sb.Append("  ExcelFile: ").Append(ExcelFile).Append("\n");
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
            return this.Equals(input as InlineObject);
        }

        /// <summary>
        /// Returns true if InlineObject instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineObject input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ExcelFile == input.ExcelFile ||
                    (this.ExcelFile != null &&
                    this.ExcelFile.Equals(input.ExcelFile))
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
                if (this.ExcelFile != null)
                    hashCode = hashCode * 59 + this.ExcelFile.GetHashCode();
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
