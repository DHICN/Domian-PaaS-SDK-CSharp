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
    /// 0-Waiting(Waiting for calculation) 1-PreHandling(Pre-processing) 2-PreHandled(Pre-processing finished) 3-Running(Calculating) 4-Run(Calculating finished) 5-PostHanding(Post-processing) 6-PostHandled(Post-processing finished) 7-Cancelling(Cancelling) 8-Canceled(Canceled) 1000-Finished(Whole process finished) 
    /// </summary>
    /// <value>0-Waiting(Waiting for calculation) 1-PreHandling(Pre-processing) 2-PreHandled(Pre-processing finished) 3-Running(Calculating) 4-Run(Calculating finished) 5-PostHanding(Post-processing) 6-PostHandled(Post-processing finished) 7-Cancelling(Cancelling) 8-Canceled(Canceled) 1000-Finished(Whole process finished) </value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ModelStateEnum
    {
        /// <summary>
        /// Enum NUMBER_0 for value: 0
        /// </summary>
        [EnumMember(Value = "0")]
        NUMBER_0 = 1,

        /// <summary>
        /// Enum NUMBER_1 for value: 1
        /// </summary>
        [EnumMember(Value = "1")]
        NUMBER_1 = 2,

        /// <summary>
        /// Enum NUMBER_2 for value: 2
        /// </summary>
        [EnumMember(Value = "2")]
        NUMBER_2 = 3,

        /// <summary>
        /// Enum NUMBER_3 for value: 3
        /// </summary>
        [EnumMember(Value = "3")]
        NUMBER_3 = 4,

        /// <summary>
        /// Enum NUMBER_4 for value: 4
        /// </summary>
        [EnumMember(Value = "4")]
        NUMBER_4 = 5,

        /// <summary>
        /// Enum NUMBER_5 for value: 5
        /// </summary>
        [EnumMember(Value = "5")]
        NUMBER_5 = 6,

        /// <summary>
        /// Enum NUMBER_6 for value: 6
        /// </summary>
        [EnumMember(Value = "6")]
        NUMBER_6 = 7,

        /// <summary>
        /// Enum NUMBER_7 for value: 7
        /// </summary>
        [EnumMember(Value = "7")]
        NUMBER_7 = 8,

        /// <summary>
        /// Enum NUMBER_8 for value: 8
        /// </summary>
        [EnumMember(Value = "8")]
        NUMBER_8 = 9,

        /// <summary>
        /// Enum NUMBER_1000 for value: 1000
        /// </summary>
        [EnumMember(Value = "1000")]
        NUMBER_1000 = 10

    }

}
