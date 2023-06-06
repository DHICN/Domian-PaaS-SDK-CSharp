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
    /// BaseTimeseriesBatchOutput
    /// </summary>
    [DataContract]
    public partial class BaseTimeseriesBatchOutput :  IEquatable<BaseTimeseriesBatchOutput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BaseTimeseriesBatchOutput" /> class.
        /// </summary>
        /// <param name="t">时刻列表 all the time steps, in string with timezone.</param>
        /// <param name="v">时刻对应的数值列表 value of each time step.</param>
        /// <param name="modelId">modelId.</param>
        public BaseTimeseriesBatchOutput(List<string> t = default(List<string>), List<double> v = default(List<double>), string modelId = default(string))
        {
            this.T = t;
            this.V = v;
            this.ModelId = modelId;
        }
        
        /// <summary>
        /// 时刻列表 all the time steps, in string with timezone
        /// </summary>
        /// <value>时刻列表 all the time steps, in string with timezone</value>
        [DataMember(Name="t", EmitDefaultValue=true)]
        public List<string> T { get; set; }

        /// <summary>
        /// 时刻对应的数值列表 value of each time step
        /// </summary>
        /// <value>时刻对应的数值列表 value of each time step</value>
        [DataMember(Name="v", EmitDefaultValue=true)]
        public List<double> V { get; set; }

        /// <summary>
        /// Gets or Sets ModelId
        /// </summary>
        [DataMember(Name="modelId", EmitDefaultValue=true)]
        public string ModelId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BaseTimeseriesBatchOutput {\n");
            sb.Append("  T: ").Append(T).Append("\n");
            sb.Append("  V: ").Append(V).Append("\n");
            sb.Append("  ModelId: ").Append(ModelId).Append("\n");
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
            return this.Equals(input as BaseTimeseriesBatchOutput);
        }

        /// <summary>
        /// Returns true if BaseTimeseriesBatchOutput instances are equal
        /// </summary>
        /// <param name="input">Instance of BaseTimeseriesBatchOutput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BaseTimeseriesBatchOutput input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.T == input.T ||
                    this.T != null &&
                    input.T != null &&
                    this.T.SequenceEqual(input.T)
                ) && 
                (
                    this.V == input.V ||
                    this.V != null &&
                    input.V != null &&
                    this.V.SequenceEqual(input.V)
                ) && 
                (
                    this.ModelId == input.ModelId ||
                    (this.ModelId != null &&
                    this.ModelId.Equals(input.ModelId))
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
                if (this.T != null)
                    hashCode = hashCode * 59 + this.T.GetHashCode();
                if (this.V != null)
                    hashCode = hashCode * 59 + this.V.GetHashCode();
                if (this.ModelId != null)
                    hashCode = hashCode * 59 + this.ModelId.GetHashCode();
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
