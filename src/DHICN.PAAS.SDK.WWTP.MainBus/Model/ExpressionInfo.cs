/* 
 * wwtp-paas-main-bus-service
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
using OpenAPIDateConverter = DHICN.PAAS.SDK.WWTP.MainBus.Client.OpenAPIDateConverter;

namespace DHICN.PAAS.SDK.WWTP.MainBus.Model
{
    /// <summary>
    /// ExpressionInfo
    /// </summary>
    [DataContract]
    public partial class ExpressionInfo :  IEquatable<ExpressionInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExpressionInfo" /> class.
        /// </summary>
        /// <param name="expression">expression.</param>
        public ExpressionInfo(string expression = default(string))
        {
            this.Expression = expression;
        }
        
        /// <summary>
        /// Gets or Sets Expression
        /// </summary>
        [DataMember(Name="expression", EmitDefaultValue=true)]
        public string Expression { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExpressionInfo {\n");
            sb.Append("  Expression: ").Append(Expression).Append("\n");
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
            return this.Equals(input as ExpressionInfo);
        }

        /// <summary>
        /// Returns true if ExpressionInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ExpressionInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExpressionInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Expression == input.Expression ||
                    (this.Expression != null &&
                    this.Expression.Equals(input.Expression))
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
                if (this.Expression != null)
                    hashCode = hashCode * 59 + this.Expression.GetHashCode();
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
