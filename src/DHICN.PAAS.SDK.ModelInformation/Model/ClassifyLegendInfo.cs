/* 
 * model-configuration-service
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
using OpenAPIDateConverter = DHICN.PAAS.SDK.ModelInformation.Client.OpenAPIDateConverter;

namespace DHICN.PAAS.SDK.ModelInformation.Model
{
    /// <summary>
    /// ClassifyLegendInfo
    /// </summary>
    [DataContract]
    public partial class ClassifyLegendInfo :  IEquatable<ClassifyLegendInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifyLegendInfo" /> class.
        /// </summary>
        /// <param name="grade">等级序号 grade.</param>
        /// <param name="maxValue">最大值 max value.</param>
        /// <param name="minValue">最小值 min value.</param>
        /// <param name="red">RGB颜色的红色值 red value in rgb color (0-255).</param>
        /// <param name="green">RGB颜色的绿色值 green value in rgb color (0-255).</param>
        /// <param name="blue">RGB颜色的蓝色值 blue value in rgb color (0-255).</param>
        /// <param name="description">描述 description.</param>
        public ClassifyLegendInfo(int grade = default(int), double maxValue = default(double), double minValue = default(double), int red = default(int), int green = default(int), int blue = default(int), string description = default(string))
        {
            this.Grade = grade;
            this.MaxValue = maxValue;
            this.MinValue = minValue;
            this.Red = red;
            this.Green = green;
            this.Blue = blue;
            this.Description = description;
        }
        
        /// <summary>
        /// 等级序号 grade
        /// </summary>
        /// <value>等级序号 grade</value>
        [DataMember(Name="grade", EmitDefaultValue=false)]
        public int Grade { get; set; }

        /// <summary>
        /// 最大值 max value
        /// </summary>
        /// <value>最大值 max value</value>
        [DataMember(Name="maxValue", EmitDefaultValue=false)]
        public double MaxValue { get; set; }

        /// <summary>
        /// 最小值 min value
        /// </summary>
        /// <value>最小值 min value</value>
        [DataMember(Name="minValue", EmitDefaultValue=false)]
        public double MinValue { get; set; }

        /// <summary>
        /// RGB颜色的红色值 red value in rgb color (0-255)
        /// </summary>
        /// <value>RGB颜色的红色值 red value in rgb color (0-255)</value>
        [DataMember(Name="red", EmitDefaultValue=false)]
        public int Red { get; set; }

        /// <summary>
        /// RGB颜色的绿色值 green value in rgb color (0-255)
        /// </summary>
        /// <value>RGB颜色的绿色值 green value in rgb color (0-255)</value>
        [DataMember(Name="green", EmitDefaultValue=false)]
        public int Green { get; set; }

        /// <summary>
        /// RGB颜色的蓝色值 blue value in rgb color (0-255)
        /// </summary>
        /// <value>RGB颜色的蓝色值 blue value in rgb color (0-255)</value>
        [DataMember(Name="blue", EmitDefaultValue=false)]
        public int Blue { get; set; }

        /// <summary>
        /// 描述 description
        /// </summary>
        /// <value>描述 description</value>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClassifyLegendInfo {\n");
            sb.Append("  Grade: ").Append(Grade).Append("\n");
            sb.Append("  MaxValue: ").Append(MaxValue).Append("\n");
            sb.Append("  MinValue: ").Append(MinValue).Append("\n");
            sb.Append("  Red: ").Append(Red).Append("\n");
            sb.Append("  Green: ").Append(Green).Append("\n");
            sb.Append("  Blue: ").Append(Blue).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return this.Equals(input as ClassifyLegendInfo);
        }

        /// <summary>
        /// Returns true if ClassifyLegendInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ClassifyLegendInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClassifyLegendInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Grade == input.Grade ||
                    this.Grade.Equals(input.Grade)
                ) && 
                (
                    this.MaxValue == input.MaxValue ||
                    this.MaxValue.Equals(input.MaxValue)
                ) && 
                (
                    this.MinValue == input.MinValue ||
                    this.MinValue.Equals(input.MinValue)
                ) && 
                (
                    this.Red == input.Red ||
                    this.Red.Equals(input.Red)
                ) && 
                (
                    this.Green == input.Green ||
                    this.Green.Equals(input.Green)
                ) && 
                (
                    this.Blue == input.Blue ||
                    this.Blue.Equals(input.Blue)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                hashCode = hashCode * 59 + this.Grade.GetHashCode();
                hashCode = hashCode * 59 + this.MaxValue.GetHashCode();
                hashCode = hashCode * 59 + this.MinValue.GetHashCode();
                hashCode = hashCode * 59 + this.Red.GetHashCode();
                hashCode = hashCode * 59 + this.Green.GetHashCode();
                hashCode = hashCode * 59 + this.Blue.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
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
