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
    /// 0-Pressure(压力) 1-Flow(流量(含流向)) 2-Velocity(流速) 3-NodeWaterQuality(节点水质) 4-PipeWaterQuality(管线水质) 5-NodeWaterAge(节点水龄) 6-PipeWaterAge(管线水龄) 7-AbsFlow(流量（不含流向）) 8-TraceSupplyRange(供水边界) 9-NodeTraceWQ(节点污染物扩散) 10-PipeTraceWQ(管道污染物扩散) 11-Pressure_Fluctuate(压力波动) 12-Demand(水量) 13-Head(水头(HGL)) 14-Headloss(水损(千米)) 
    /// </summary>
    /// <value>0-Pressure(压力) 1-Flow(流量(含流向)) 2-Velocity(流速) 3-NodeWaterQuality(节点水质) 4-PipeWaterQuality(管线水质) 5-NodeWaterAge(节点水龄) 6-PipeWaterAge(管线水龄) 7-AbsFlow(流量（不含流向）) 8-TraceSupplyRange(供水边界) 9-NodeTraceWQ(节点污染物扩散) 10-PipeTraceWQ(管道污染物扩散) 11-Pressure_Fluctuate(压力波动) 12-Demand(水量) 13-Head(水头(HGL)) 14-Headloss(水损(千米)) </value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum SysWdDataTypeEnum
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
        /// Enum NUMBER_9 for value: 9
        /// </summary>
        [EnumMember(Value = "9")]
        NUMBER_9 = 10,

        /// <summary>
        /// Enum NUMBER_10 for value: 10
        /// </summary>
        [EnumMember(Value = "10")]
        NUMBER_10 = 11,

        /// <summary>
        /// Enum NUMBER_11 for value: 11
        /// </summary>
        [EnumMember(Value = "11")]
        NUMBER_11 = 12,

        /// <summary>
        /// Enum NUMBER_12 for value: 12
        /// </summary>
        [EnumMember(Value = "12")]
        NUMBER_12 = 13,

        /// <summary>
        /// Enum NUMBER_13 for value: 13
        /// </summary>
        [EnumMember(Value = "13")]
        NUMBER_13 = 14,

        /// <summary>
        /// Enum NUMBER_14 for value: 14
        /// </summary>
        [EnumMember(Value = "14")]
        NUMBER_14 = 15

    }

}