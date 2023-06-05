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
using OpenAPIDateConverter = DHI.DSS.WWTPPaasInfrastructureServiceSDK.Client.OpenAPIDateConverter;

namespace DHI.DSS.WWTPPaasInfrastructureServiceSDK.Model
{
    /// <summary>
    /// UpdateIotInput
    /// </summary>
    [DataContract]
    public partial class UpdateIotInput :  IEquatable<UpdateIotInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateIotInput" /> class.
        /// </summary>
        /// <param name="dateTime">当前时刻 current time.</param>
        public UpdateIotInput(DateTime? dateTime = default(DateTime?))
        {
            this.DateTime = dateTime;
        }
        
        /// <summary>
        /// 当前时刻 current time
        /// </summary>
        /// <value>当前时刻 current time</value>
        [DataMember(Name="dateTime", EmitDefaultValue=true)]
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateIotInput {\n");
            sb.Append("  DateTime: ").Append(DateTime).Append("\n");
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
            return this.Equals(input as UpdateIotInput);
        }

        /// <summary>
        /// Returns true if UpdateIotInput instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateIotInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateIotInput input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DateTime == input.DateTime ||
                    (this.DateTime != null &&
                    this.DateTime.Equals(input.DateTime))
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
                if (this.DateTime != null)
                    hashCode = hashCode * 59 + this.DateTime.GetHashCode();
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