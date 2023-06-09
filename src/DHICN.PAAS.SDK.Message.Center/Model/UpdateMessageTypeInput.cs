/* 
 * message-center-service
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
using OpenAPIDateConverter = DHICN.PAAS.SDK.Message.Center.Client.OpenAPIDateConverter;

namespace DHICN.PAAS.SDK.Message.Center.Model
{
    /// <summary>
    /// UpdateMessageTypeInput
    /// </summary>
    [DataContract]
    public partial class UpdateMessageTypeInput :  IEquatable<UpdateMessageTypeInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMessageTypeInput" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="msgType">消息类型  &lt;br&gt; message&#39;s type .</param>
        /// <param name="showName">显示名  &lt;br&gt; display&#39;s name .</param>
        /// <param name="order">排序 order number.</param>
        public UpdateMessageTypeInput(Guid id = default(Guid), string msgType = default(string), string showName = default(string), int order = default(int))
        {
            this.Id = id;
            this.MsgType = msgType;
            this.ShowName = showName;
            this.Order = order;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid Id { get; set; }

        /// <summary>
        /// 消息类型  &lt;br&gt; message&#39;s type 
        /// </summary>
        /// <value>消息类型  &lt;br&gt; message&#39;s type </value>
        [DataMember(Name="msgType", EmitDefaultValue=true)]
        public string MsgType { get; set; }

        /// <summary>
        /// 显示名  &lt;br&gt; display&#39;s name 
        /// </summary>
        /// <value>显示名  &lt;br&gt; display&#39;s name </value>
        [DataMember(Name="showName", EmitDefaultValue=true)]
        public string ShowName { get; set; }

        /// <summary>
        /// 排序 order number
        /// </summary>
        /// <value>排序 order number</value>
        [DataMember(Name="order", EmitDefaultValue=false)]
        public int Order { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateMessageTypeInput {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  MsgType: ").Append(MsgType).Append("\n");
            sb.Append("  ShowName: ").Append(ShowName).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
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
            return this.Equals(input as UpdateMessageTypeInput);
        }

        /// <summary>
        /// Returns true if UpdateMessageTypeInput instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateMessageTypeInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateMessageTypeInput input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.MsgType == input.MsgType ||
                    (this.MsgType != null &&
                    this.MsgType.Equals(input.MsgType))
                ) && 
                (
                    this.ShowName == input.ShowName ||
                    (this.ShowName != null &&
                    this.ShowName.Equals(input.ShowName))
                ) && 
                (
                    this.Order == input.Order ||
                    this.Order.Equals(input.Order)
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.MsgType != null)
                    hashCode = hashCode * 59 + this.MsgType.GetHashCode();
                if (this.ShowName != null)
                    hashCode = hashCode * 59 + this.ShowName.GetHashCode();
                hashCode = hashCode * 59 + this.Order.GetHashCode();
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
