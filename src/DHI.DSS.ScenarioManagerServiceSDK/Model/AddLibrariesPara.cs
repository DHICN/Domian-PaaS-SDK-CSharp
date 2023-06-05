/* 
 * scenario-manager-service
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
using OpenAPIDateConverter = DHI.DSS.ScenarioManagerServiceSDK.Client.OpenAPIDateConverter;

namespace DHI.DSS.ScenarioManagerServiceSDK.Model
{
    /// <summary>
    /// AddLibrariesPara
    /// </summary>
    [DataContract]
    public partial class AddLibrariesPara :  IEquatable<AddLibrariesPara>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddLibrariesPara" /> class.
        /// </summary>
        /// <param name="scenariogroup">方案组ID scenario group&#39;s Id.</param>
        /// <param name="name">库的名称 library name.</param>
        /// <param name="type">库的类型 library type:  0-Undefined  1-AutoForecast  2-ManualForecast  3-Forecast  4-Schedule  5-Experience  6-ScenarioSimulation  7-WQAccident  8-OnlineHD  9-WaterHammer  10-Filling  11-PipeBurst  12-WQResponse  13-Planning  14-Flushing  15-OnlineWQAccident  16-CloseValve  17-WWTP  18-WWTPOptim  19-WWTPMLab.</param>
        /// <param name="businessType">库的业务类型 business type:  0-Undefined  1-WaterEnvironmnet  2-UrbanFlooding  3-WaterDistribution  4-RiverFlood  5-WWTP.</param>
        /// <param name="_readonly">0代表可读写，1代表只读 0 for not readonly, 1 for readonly.</param>
        /// <param name="bindTemplate">1表示库直接绑定一个模板方案，0表示不绑定 1 for bind a template directly, 0 for not.</param>
        /// <param name="bindType">当BindTemplate为0，此项表示其绑定的库的类型 Bind library type for a template, in case of BindTemplate is 0:  0-Undefined  1-AutoForecast  2-ManualForecast  3-Forecast  4-Schedule  5-Experience  6-ScenarioSimulation  7-WQAccident  8-OnlineHD  9-WaterHammer  10-Filling  11-PipeBurst  12-WQResponse  13-Planning  14-Flushing  15-OnlineWQAccident  16-CloseValve  17-WWTP  18-WWTPOptim  19-WWTPMLab.</param>
        /// <param name="bindBusinessType">当BindTemplate为0，此项表示其绑定的库的业务类型 Bind business type for a template, in case of BindTemplate is 0:  0-Undefined  1-WaterEnvironmnet  2-UrbanFlooding  3-WaterDistribution  4-RiverFlood  5-WWTP.</param>
        /// <param name="enableMultiTemplate">0表示只能绑定单个模板方案，1表示可以绑定多个模板方案 0 for single template which is the default option, 1 for multiple templates.</param>
        /// <param name="description">库的描述 description.</param>
        public AddLibrariesPara(Guid scenariogroup = default(Guid), string name = default(string), int type = default(int), int businessType = default(int), int _readonly = default(int), int bindTemplate = default(int), int bindType = default(int), int bindBusinessType = default(int), int? enableMultiTemplate = default(int?), string description = default(string))
        {
            this.Scenariogroup = scenariogroup;
            this.Name = name;
            this.Type = type;
            this.BusinessType = businessType;
            this.Readonly = _readonly;
            this.BindTemplate = bindTemplate;
            this.BindType = bindType;
            this.BindBusinessType = bindBusinessType;
            this.EnableMultiTemplate = enableMultiTemplate;
            this.Description = description;
        }
        
        /// <summary>
        /// 方案组ID scenario group&#39;s Id
        /// </summary>
        /// <value>方案组ID scenario group&#39;s Id</value>
        [DataMember(Name="scenariogroup", EmitDefaultValue=false)]
        public Guid Scenariogroup { get; set; }

        /// <summary>
        /// 库的名称 library name
        /// </summary>
        /// <value>库的名称 library name</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// 库的类型 library type:  0-Undefined  1-AutoForecast  2-ManualForecast  3-Forecast  4-Schedule  5-Experience  6-ScenarioSimulation  7-WQAccident  8-OnlineHD  9-WaterHammer  10-Filling  11-PipeBurst  12-WQResponse  13-Planning  14-Flushing  15-OnlineWQAccident  16-CloseValve  17-WWTP  18-WWTPOptim  19-WWTPMLab
        /// </summary>
        /// <value>库的类型 library type:  0-Undefined  1-AutoForecast  2-ManualForecast  3-Forecast  4-Schedule  5-Experience  6-ScenarioSimulation  7-WQAccident  8-OnlineHD  9-WaterHammer  10-Filling  11-PipeBurst  12-WQResponse  13-Planning  14-Flushing  15-OnlineWQAccident  16-CloseValve  17-WWTP  18-WWTPOptim  19-WWTPMLab</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public int Type { get; set; }

        /// <summary>
        /// 库的业务类型 business type:  0-Undefined  1-WaterEnvironmnet  2-UrbanFlooding  3-WaterDistribution  4-RiverFlood  5-WWTP
        /// </summary>
        /// <value>库的业务类型 business type:  0-Undefined  1-WaterEnvironmnet  2-UrbanFlooding  3-WaterDistribution  4-RiverFlood  5-WWTP</value>
        [DataMember(Name="businessType", EmitDefaultValue=false)]
        public int BusinessType { get; set; }

        /// <summary>
        /// 0代表可读写，1代表只读 0 for not readonly, 1 for readonly
        /// </summary>
        /// <value>0代表可读写，1代表只读 0 for not readonly, 1 for readonly</value>
        [DataMember(Name="readonly", EmitDefaultValue=false)]
        public int Readonly { get; set; }

        /// <summary>
        /// 1表示库直接绑定一个模板方案，0表示不绑定 1 for bind a template directly, 0 for not
        /// </summary>
        /// <value>1表示库直接绑定一个模板方案，0表示不绑定 1 for bind a template directly, 0 for not</value>
        [DataMember(Name="bindTemplate", EmitDefaultValue=false)]
        public int BindTemplate { get; set; }

        /// <summary>
        /// 当BindTemplate为0，此项表示其绑定的库的类型 Bind library type for a template, in case of BindTemplate is 0:  0-Undefined  1-AutoForecast  2-ManualForecast  3-Forecast  4-Schedule  5-Experience  6-ScenarioSimulation  7-WQAccident  8-OnlineHD  9-WaterHammer  10-Filling  11-PipeBurst  12-WQResponse  13-Planning  14-Flushing  15-OnlineWQAccident  16-CloseValve  17-WWTP  18-WWTPOptim  19-WWTPMLab
        /// </summary>
        /// <value>当BindTemplate为0，此项表示其绑定的库的类型 Bind library type for a template, in case of BindTemplate is 0:  0-Undefined  1-AutoForecast  2-ManualForecast  3-Forecast  4-Schedule  5-Experience  6-ScenarioSimulation  7-WQAccident  8-OnlineHD  9-WaterHammer  10-Filling  11-PipeBurst  12-WQResponse  13-Planning  14-Flushing  15-OnlineWQAccident  16-CloseValve  17-WWTP  18-WWTPOptim  19-WWTPMLab</value>
        [DataMember(Name="bindType", EmitDefaultValue=false)]
        public int BindType { get; set; }

        /// <summary>
        /// 当BindTemplate为0，此项表示其绑定的库的业务类型 Bind business type for a template, in case of BindTemplate is 0:  0-Undefined  1-WaterEnvironmnet  2-UrbanFlooding  3-WaterDistribution  4-RiverFlood  5-WWTP
        /// </summary>
        /// <value>当BindTemplate为0，此项表示其绑定的库的业务类型 Bind business type for a template, in case of BindTemplate is 0:  0-Undefined  1-WaterEnvironmnet  2-UrbanFlooding  3-WaterDistribution  4-RiverFlood  5-WWTP</value>
        [DataMember(Name="bindBusinessType", EmitDefaultValue=false)]
        public int BindBusinessType { get; set; }

        /// <summary>
        /// 0表示只能绑定单个模板方案，1表示可以绑定多个模板方案 0 for single template which is the default option, 1 for multiple templates
        /// </summary>
        /// <value>0表示只能绑定单个模板方案，1表示可以绑定多个模板方案 0 for single template which is the default option, 1 for multiple templates</value>
        [DataMember(Name="enableMultiTemplate", EmitDefaultValue=true)]
        public int? EnableMultiTemplate { get; set; }

        /// <summary>
        /// 库的描述 description
        /// </summary>
        /// <value>库的描述 description</value>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddLibrariesPara {\n");
            sb.Append("  Scenariogroup: ").Append(Scenariogroup).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  BusinessType: ").Append(BusinessType).Append("\n");
            sb.Append("  Readonly: ").Append(Readonly).Append("\n");
            sb.Append("  BindTemplate: ").Append(BindTemplate).Append("\n");
            sb.Append("  BindType: ").Append(BindType).Append("\n");
            sb.Append("  BindBusinessType: ").Append(BindBusinessType).Append("\n");
            sb.Append("  EnableMultiTemplate: ").Append(EnableMultiTemplate).Append("\n");
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
            return this.Equals(input as AddLibrariesPara);
        }

        /// <summary>
        /// Returns true if AddLibrariesPara instances are equal
        /// </summary>
        /// <param name="input">Instance of AddLibrariesPara to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddLibrariesPara input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Scenariogroup == input.Scenariogroup ||
                    (this.Scenariogroup != null &&
                    this.Scenariogroup.Equals(input.Scenariogroup))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.BusinessType == input.BusinessType ||
                    this.BusinessType.Equals(input.BusinessType)
                ) && 
                (
                    this.Readonly == input.Readonly ||
                    this.Readonly.Equals(input.Readonly)
                ) && 
                (
                    this.BindTemplate == input.BindTemplate ||
                    this.BindTemplate.Equals(input.BindTemplate)
                ) && 
                (
                    this.BindType == input.BindType ||
                    this.BindType.Equals(input.BindType)
                ) && 
                (
                    this.BindBusinessType == input.BindBusinessType ||
                    this.BindBusinessType.Equals(input.BindBusinessType)
                ) && 
                (
                    this.EnableMultiTemplate == input.EnableMultiTemplate ||
                    (this.EnableMultiTemplate != null &&
                    this.EnableMultiTemplate.Equals(input.EnableMultiTemplate))
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
                if (this.Scenariogroup != null)
                    hashCode = hashCode * 59 + this.Scenariogroup.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                hashCode = hashCode * 59 + this.BusinessType.GetHashCode();
                hashCode = hashCode * 59 + this.Readonly.GetHashCode();
                hashCode = hashCode * 59 + this.BindTemplate.GetHashCode();
                hashCode = hashCode * 59 + this.BindType.GetHashCode();
                hashCode = hashCode * 59 + this.BindBusinessType.GetHashCode();
                if (this.EnableMultiTemplate != null)
                    hashCode = hashCode * 59 + this.EnableMultiTemplate.GetHashCode();
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
