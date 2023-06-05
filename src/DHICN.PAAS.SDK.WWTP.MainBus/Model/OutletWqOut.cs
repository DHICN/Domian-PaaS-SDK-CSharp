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
    /// OutletWqOut
    /// </summary>
    [DataContract]
    public partial class OutletWqOut :  IEquatable<OutletWqOut>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OutletWqOut" /> class.
        /// </summary>
        /// <param name="code">指标 indicator code.</param>
        /// <param name="realDatas">在线数据 online data.</param>
        /// <param name="modelDatas">模拟数据 model result data.</param>
        /// <param name="unit">单位 unit.</param>
        public OutletWqOut(string code = default(string), List<TsPair1> realDatas = default(List<TsPair1>), List<TsPair1> modelDatas = default(List<TsPair1>), string unit = default(string))
        {
            this.Code = code;
            this.RealDatas = realDatas;
            this.ModelDatas = modelDatas;
            this.Unit = unit;
        }
        
        /// <summary>
        /// 指标 indicator code
        /// </summary>
        /// <value>指标 indicator code</value>
        [DataMember(Name="code", EmitDefaultValue=true)]
        public string Code { get; set; }

        /// <summary>
        /// 在线数据 online data
        /// </summary>
        /// <value>在线数据 online data</value>
        [DataMember(Name="realDatas", EmitDefaultValue=true)]
        public List<TsPair1> RealDatas { get; set; }

        /// <summary>
        /// 模拟数据 model result data
        /// </summary>
        /// <value>模拟数据 model result data</value>
        [DataMember(Name="modelDatas", EmitDefaultValue=true)]
        public List<TsPair1> ModelDatas { get; set; }

        /// <summary>
        /// 单位 unit
        /// </summary>
        /// <value>单位 unit</value>
        [DataMember(Name="unit", EmitDefaultValue=true)]
        public string Unit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OutletWqOut {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  RealDatas: ").Append(RealDatas).Append("\n");
            sb.Append("  ModelDatas: ").Append(ModelDatas).Append("\n");
            sb.Append("  Unit: ").Append(Unit).Append("\n");
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
            return this.Equals(input as OutletWqOut);
        }

        /// <summary>
        /// Returns true if OutletWqOut instances are equal
        /// </summary>
        /// <param name="input">Instance of OutletWqOut to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OutletWqOut input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.RealDatas == input.RealDatas ||
                    this.RealDatas != null &&
                    input.RealDatas != null &&
                    this.RealDatas.SequenceEqual(input.RealDatas)
                ) && 
                (
                    this.ModelDatas == input.ModelDatas ||
                    this.ModelDatas != null &&
                    input.ModelDatas != null &&
                    this.ModelDatas.SequenceEqual(input.ModelDatas)
                ) && 
                (
                    this.Unit == input.Unit ||
                    (this.Unit != null &&
                    this.Unit.Equals(input.Unit))
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
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.RealDatas != null)
                    hashCode = hashCode * 59 + this.RealDatas.GetHashCode();
                if (this.ModelDatas != null)
                    hashCode = hashCode * 59 + this.ModelDatas.GetHashCode();
                if (this.Unit != null)
                    hashCode = hashCode * 59 + this.Unit.GetHashCode();
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
