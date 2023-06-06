/* 
 * model-information-service
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
    /// InitialCondition
    /// </summary>
    [DataContract]
    public partial class InitialCondition :  IEquatable<InitialCondition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InitialCondition" /> class.
        /// </summary>
        /// <param name="hotstartScenario">热启动方案ID hotstart scenario ID.</param>
        /// <param name="m1DHotStartID">河道模型热启动文件 river hotstart file.</param>
        /// <param name="m1DHotstartFile">管网模型热启动文件 pipe hotstart file.</param>
        /// <param name="m2DHotstartFile">二维模型热启动文件 2D hotstart file.</param>
        public InitialCondition(string hotstartScenario = default(string), string m1DHotStartID = default(string), string m1DHotstartFile = default(string), string m2DHotstartFile = default(string))
        {
            this.HotstartScenario = hotstartScenario;
            this.M1DHotStartID = m1DHotStartID;
            this.M1DHotstartFile = m1DHotstartFile;
            this.M2DHotstartFile = m2DHotstartFile;
        }
        
        /// <summary>
        /// 热启动方案ID hotstart scenario ID
        /// </summary>
        /// <value>热启动方案ID hotstart scenario ID</value>
        [DataMember(Name="hotstartScenario", EmitDefaultValue=true)]
        public string HotstartScenario { get; set; }

        /// <summary>
        /// 河道模型热启动文件 river hotstart file
        /// </summary>
        /// <value>河道模型热启动文件 river hotstart file</value>
        [DataMember(Name="m1DHotStartID", EmitDefaultValue=true)]
        public string M1DHotStartID { get; set; }

        /// <summary>
        /// 管网模型热启动文件 pipe hotstart file
        /// </summary>
        /// <value>管网模型热启动文件 pipe hotstart file</value>
        [DataMember(Name="m1DHotstartFile", EmitDefaultValue=true)]
        public string M1DHotstartFile { get; set; }

        /// <summary>
        /// 二维模型热启动文件 2D hotstart file
        /// </summary>
        /// <value>二维模型热启动文件 2D hotstart file</value>
        [DataMember(Name="m2DHotstartFile", EmitDefaultValue=true)]
        public string M2DHotstartFile { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InitialCondition {\n");
            sb.Append("  HotstartScenario: ").Append(HotstartScenario).Append("\n");
            sb.Append("  M1DHotStartID: ").Append(M1DHotStartID).Append("\n");
            sb.Append("  M1DHotstartFile: ").Append(M1DHotstartFile).Append("\n");
            sb.Append("  M2DHotstartFile: ").Append(M2DHotstartFile).Append("\n");
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
            return this.Equals(input as InitialCondition);
        }

        /// <summary>
        /// Returns true if InitialCondition instances are equal
        /// </summary>
        /// <param name="input">Instance of InitialCondition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InitialCondition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.HotstartScenario == input.HotstartScenario ||
                    (this.HotstartScenario != null &&
                    this.HotstartScenario.Equals(input.HotstartScenario))
                ) && 
                (
                    this.M1DHotStartID == input.M1DHotStartID ||
                    (this.M1DHotStartID != null &&
                    this.M1DHotStartID.Equals(input.M1DHotStartID))
                ) && 
                (
                    this.M1DHotstartFile == input.M1DHotstartFile ||
                    (this.M1DHotstartFile != null &&
                    this.M1DHotstartFile.Equals(input.M1DHotstartFile))
                ) && 
                (
                    this.M2DHotstartFile == input.M2DHotstartFile ||
                    (this.M2DHotstartFile != null &&
                    this.M2DHotstartFile.Equals(input.M2DHotstartFile))
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
                if (this.HotstartScenario != null)
                    hashCode = hashCode * 59 + this.HotstartScenario.GetHashCode();
                if (this.M1DHotStartID != null)
                    hashCode = hashCode * 59 + this.M1DHotStartID.GetHashCode();
                if (this.M1DHotstartFile != null)
                    hashCode = hashCode * 59 + this.M1DHotstartFile.GetHashCode();
                if (this.M2DHotstartFile != null)
                    hashCode = hashCode * 59 + this.M2DHotstartFile.GetHashCode();
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
