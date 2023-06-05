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
    /// ChemicalCostPerFlowOutput
    /// </summary>
    [DataContract]
    public partial class ChemicalCostPerFlowOutput :  IEquatable<ChemicalCostPerFlowOutput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChemicalCostPerFlowOutput" /> class.
        /// </summary>
        /// <param name="chemicalName">药剂名称 dosage name.</param>
        /// <param name="datas">每条工艺线的吨水药耗数据 dosage cost per ton water of each product line.</param>
        public ChemicalCostPerFlowOutput(string chemicalName = default(string), List<Data> datas = default(List<Data>))
        {
            this.ChemicalName = chemicalName;
            this.Datas = datas;
        }
        
        /// <summary>
        /// 药剂名称 dosage name
        /// </summary>
        /// <value>药剂名称 dosage name</value>
        [DataMember(Name="chemicalName", EmitDefaultValue=true)]
        public string ChemicalName { get; set; }

        /// <summary>
        /// 每条工艺线的吨水药耗数据 dosage cost per ton water of each product line
        /// </summary>
        /// <value>每条工艺线的吨水药耗数据 dosage cost per ton water of each product line</value>
        [DataMember(Name="datas", EmitDefaultValue=true)]
        public List<Data> Datas { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChemicalCostPerFlowOutput {\n");
            sb.Append("  ChemicalName: ").Append(ChemicalName).Append("\n");
            sb.Append("  Datas: ").Append(Datas).Append("\n");
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
            return this.Equals(input as ChemicalCostPerFlowOutput);
        }

        /// <summary>
        /// Returns true if ChemicalCostPerFlowOutput instances are equal
        /// </summary>
        /// <param name="input">Instance of ChemicalCostPerFlowOutput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChemicalCostPerFlowOutput input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ChemicalName == input.ChemicalName ||
                    (this.ChemicalName != null &&
                    this.ChemicalName.Equals(input.ChemicalName))
                ) && 
                (
                    this.Datas == input.Datas ||
                    this.Datas != null &&
                    input.Datas != null &&
                    this.Datas.SequenceEqual(input.Datas)
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
                if (this.ChemicalName != null)
                    hashCode = hashCode * 59 + this.ChemicalName.GetHashCode();
                if (this.Datas != null)
                    hashCode = hashCode * 59 + this.Datas.GetHashCode();
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
