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
    /// SelectItemNode
    /// </summary>
    [DataContract]
    public partial class SelectItemNode :  IEquatable<SelectItemNode>, IValidatableObject
    {
        /// <summary>
        /// 选择节点的类型 select node type
        /// </summary>
        /// <value>选择节点的类型 select node type</value>
        public enum NodeTypeEnum
        {
            /// <summary>
            /// Enum NUMBER_0 for value: 0
            /// </summary>
            NUMBER_0 = 0,

            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            NUMBER_1 = 1,

            /// <summary>
            /// Enum NUMBER_2 for value: 2
            /// </summary>
            NUMBER_2 = 2,

            /// <summary>
            /// Enum NUMBER_3 for value: 3
            /// </summary>
            NUMBER_3 = 3,

            /// <summary>
            /// Enum NUMBER_4 for value: 4
            /// </summary>
            NUMBER_4 = 4,

            /// <summary>
            /// Enum NUMBER_5 for value: 5
            /// </summary>
            NUMBER_5 = 5,

            /// <summary>
            /// Enum NUMBER_6 for value: 6
            /// </summary>
            NUMBER_6 = 6

        }

        /// <summary>
        /// 选择节点的类型 select node type
        /// </summary>
        /// <value>选择节点的类型 select node type</value>
        [DataMember(Name="nodeType", EmitDefaultValue=false)]
        public NodeTypeEnum? NodeType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SelectItemNode" /> class.
        /// </summary>
        /// <param name="nodeType">选择节点的类型 select node type.</param>
        /// <param name="code">代码 code.</param>
        /// <param name="name">名称，用于显示 name for display.</param>
        /// <param name="detailedInfo">detailedInfo.</param>
        /// <param name="childNodes">子节点列表 sub node list.</param>
        public SelectItemNode(NodeTypeEnum? nodeType = default(NodeTypeEnum?), string code = default(string), string name = default(string), SelectItemNodeDetailInfo detailedInfo = default(SelectItemNodeDetailInfo), List<SelectItemNode> childNodes = default(List<SelectItemNode>))
        {
            this.NodeType = nodeType;
            this.Code = code;
            this.Name = name;
            this.DetailedInfo = detailedInfo;
            this.ChildNodes = childNodes;
        }
        
        /// <summary>
        /// 代码 code
        /// </summary>
        /// <value>代码 code</value>
        [DataMember(Name="code", EmitDefaultValue=true)]
        public string Code { get; set; }

        /// <summary>
        /// 名称，用于显示 name for display
        /// </summary>
        /// <value>名称，用于显示 name for display</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets DetailedInfo
        /// </summary>
        [DataMember(Name="detailedInfo", EmitDefaultValue=false)]
        public SelectItemNodeDetailInfo DetailedInfo { get; set; }

        /// <summary>
        /// 子节点列表 sub node list
        /// </summary>
        /// <value>子节点列表 sub node list</value>
        [DataMember(Name="childNodes", EmitDefaultValue=true)]
        public List<SelectItemNode> ChildNodes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SelectItemNode {\n");
            sb.Append("  NodeType: ").Append(NodeType).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DetailedInfo: ").Append(DetailedInfo).Append("\n");
            sb.Append("  ChildNodes: ").Append(ChildNodes).Append("\n");
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
            return this.Equals(input as SelectItemNode);
        }

        /// <summary>
        /// Returns true if SelectItemNode instances are equal
        /// </summary>
        /// <param name="input">Instance of SelectItemNode to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SelectItemNode input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NodeType == input.NodeType ||
                    this.NodeType.Equals(input.NodeType)
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.DetailedInfo == input.DetailedInfo ||
                    (this.DetailedInfo != null &&
                    this.DetailedInfo.Equals(input.DetailedInfo))
                ) && 
                (
                    this.ChildNodes == input.ChildNodes ||
                    this.ChildNodes != null &&
                    input.ChildNodes != null &&
                    this.ChildNodes.SequenceEqual(input.ChildNodes)
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
                hashCode = hashCode * 59 + this.NodeType.GetHashCode();
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.DetailedInfo != null)
                    hashCode = hashCode * 59 + this.DetailedInfo.GetHashCode();
                if (this.ChildNodes != null)
                    hashCode = hashCode * 59 + this.ChildNodes.GetHashCode();
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
