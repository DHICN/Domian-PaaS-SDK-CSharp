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
    /// MsgTemplateObj
    /// </summary>
    [DataContract]
    public partial class MsgTemplateObj :  IEquatable<MsgTemplateObj>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MsgTemplateObj" /> class.
        /// </summary>
        /// <param name="title">消息标题  &lt;br&gt;message&#39;s title .</param>
        /// <param name="time">发送消息时刻  &lt;br&gt; message&#39;s time .</param>
        /// <param name="content">消息内容  &lt;br&gt; message&#39;s content .</param>
        /// <param name="linkUrl">链接地址  &lt;br&gt; link&#39;s url .</param>
        public MsgTemplateObj(string title = default(string), string time = default(string), string content = default(string), string linkUrl = default(string))
        {
            this.Title = title;
            this.Time = time;
            this.Content = content;
            this.LinkUrl = linkUrl;
        }
        
        /// <summary>
        /// 消息标题  &lt;br&gt;message&#39;s title 
        /// </summary>
        /// <value>消息标题  &lt;br&gt;message&#39;s title </value>
        [DataMember(Name="title", EmitDefaultValue=true)]
        public string Title { get; set; }

        /// <summary>
        /// 发送消息时刻  &lt;br&gt; message&#39;s time 
        /// </summary>
        /// <value>发送消息时刻  &lt;br&gt; message&#39;s time </value>
        [DataMember(Name="time", EmitDefaultValue=true)]
        public string Time { get; set; }

        /// <summary>
        /// 消息内容  &lt;br&gt; message&#39;s content 
        /// </summary>
        /// <value>消息内容  &lt;br&gt; message&#39;s content </value>
        [DataMember(Name="content", EmitDefaultValue=true)]
        public string Content { get; set; }

        /// <summary>
        /// 链接地址  &lt;br&gt; link&#39;s url 
        /// </summary>
        /// <value>链接地址  &lt;br&gt; link&#39;s url </value>
        [DataMember(Name="linkUrl", EmitDefaultValue=true)]
        public string LinkUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MsgTemplateObj {\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  LinkUrl: ").Append(LinkUrl).Append("\n");
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
            return this.Equals(input as MsgTemplateObj);
        }

        /// <summary>
        /// Returns true if MsgTemplateObj instances are equal
        /// </summary>
        /// <param name="input">Instance of MsgTemplateObj to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MsgTemplateObj input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Time == input.Time ||
                    (this.Time != null &&
                    this.Time.Equals(input.Time))
                ) && 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
                ) && 
                (
                    this.LinkUrl == input.LinkUrl ||
                    (this.LinkUrl != null &&
                    this.LinkUrl.Equals(input.LinkUrl))
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
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Time != null)
                    hashCode = hashCode * 59 + this.Time.GetHashCode();
                if (this.Content != null)
                    hashCode = hashCode * 59 + this.Content.GetHashCode();
                if (this.LinkUrl != null)
                    hashCode = hashCode * 59 + this.LinkUrl.GetHashCode();
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
