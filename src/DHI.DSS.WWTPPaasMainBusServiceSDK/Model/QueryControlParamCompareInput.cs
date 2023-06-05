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
using OpenAPIDateConverter = DHI.DSS.WWTPPaasMainBusServiceSDK.Client.OpenAPIDateConverter;

namespace DHI.DSS.WWTPPaasMainBusServiceSDK.Model
{
    /// <summary>
    /// QueryControlParamCompareInput
    /// </summary>
    [DataContract]
    public partial class QueryControlParamCompareInput :  IEquatable<QueryControlParamCompareInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryControlParamCompareInput" /> class.
        /// </summary>
        /// <param name="scenarioIds">用于对比的方案ID scenario ids for compare.</param>
        /// <param name="productLine">工艺线代码 product line code.</param>
        public QueryControlParamCompareInput(List<Guid> scenarioIds = default(List<Guid>), string productLine = default(string))
        {
            this.ScenarioIds = scenarioIds;
            this.ProductLine = productLine;
        }
        
        /// <summary>
        /// 用于对比的方案ID scenario ids for compare
        /// </summary>
        /// <value>用于对比的方案ID scenario ids for compare</value>
        [DataMember(Name="scenarioIds", EmitDefaultValue=true)]
        public List<Guid> ScenarioIds { get; set; }

        /// <summary>
        /// 工艺线代码 product line code
        /// </summary>
        /// <value>工艺线代码 product line code</value>
        [DataMember(Name="productLine", EmitDefaultValue=true)]
        public string ProductLine { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryControlParamCompareInput {\n");
            sb.Append("  ScenarioIds: ").Append(ScenarioIds).Append("\n");
            sb.Append("  ProductLine: ").Append(ProductLine).Append("\n");
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
            return this.Equals(input as QueryControlParamCompareInput);
        }

        /// <summary>
        /// Returns true if QueryControlParamCompareInput instances are equal
        /// </summary>
        /// <param name="input">Instance of QueryControlParamCompareInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueryControlParamCompareInput input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ScenarioIds == input.ScenarioIds ||
                    this.ScenarioIds != null &&
                    input.ScenarioIds != null &&
                    this.ScenarioIds.SequenceEqual(input.ScenarioIds)
                ) && 
                (
                    this.ProductLine == input.ProductLine ||
                    (this.ProductLine != null &&
                    this.ProductLine.Equals(input.ProductLine))
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
                if (this.ScenarioIds != null)
                    hashCode = hashCode * 59 + this.ScenarioIds.GetHashCode();
                if (this.ProductLine != null)
                    hashCode = hashCode * 59 + this.ProductLine.GetHashCode();
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