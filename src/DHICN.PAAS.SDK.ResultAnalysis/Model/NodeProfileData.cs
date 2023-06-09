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
    /// NodeProfileData
    /// </summary>
    [DataContract]
    public partial class NodeProfileData :  IEquatable<NodeProfileData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NodeProfileData" /> class.
        /// </summary>
        /// <param name="nodeID">节点ID node ID.</param>
        /// <param name="profileData">节点上的剖面数据 water level at the node.</param>
        public NodeProfileData(string nodeID = default(string), double profileData = default(double))
        {
            this.NodeID = nodeID;
            this.ProfileData = profileData;
        }
        
        /// <summary>
        /// 节点ID node ID
        /// </summary>
        /// <value>节点ID node ID</value>
        [DataMember(Name="nodeID", EmitDefaultValue=true)]
        public string NodeID { get; set; }

        /// <summary>
        /// 节点上的剖面数据 water level at the node
        /// </summary>
        /// <value>节点上的剖面数据 water level at the node</value>
        [DataMember(Name="profileData", EmitDefaultValue=false)]
        public double ProfileData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NodeProfileData {\n");
            sb.Append("  NodeID: ").Append(NodeID).Append("\n");
            sb.Append("  ProfileData: ").Append(ProfileData).Append("\n");
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
            return this.Equals(input as NodeProfileData);
        }

        /// <summary>
        /// Returns true if NodeProfileData instances are equal
        /// </summary>
        /// <param name="input">Instance of NodeProfileData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NodeProfileData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NodeID == input.NodeID ||
                    (this.NodeID != null &&
                    this.NodeID.Equals(input.NodeID))
                ) && 
                (
                    this.ProfileData == input.ProfileData ||
                    this.ProfileData.Equals(input.ProfileData)
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
                if (this.NodeID != null)
                    hashCode = hashCode * 59 + this.NodeID.GetHashCode();
                hashCode = hashCode * 59 + this.ProfileData.GetHashCode();
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
