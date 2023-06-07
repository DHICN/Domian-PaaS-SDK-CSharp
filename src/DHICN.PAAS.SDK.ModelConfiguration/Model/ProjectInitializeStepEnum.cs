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
using OpenAPIDateConverter = DHICN.PAAS.SDK.ModelConfiguration.Client.OpenAPIDateConverter;

namespace DHICN.PAAS.SDK.ModelConfiguration.Model
{
    /// <summary>
    /// 0-Default 10-CreateProject(Create a new project) 20-CreateProjectInfo(Create project information) 30-UploadModelingFile(Upload template files) 40-UploadModelTemplate(Create template scenarios) 50-DealWithModelTemplate(Export model information from the template model file) 60-Uploadasset(Config IoT assets and devices) 70-ConfigurationModelTemplate(Config template information) 80-ConfigurationSchedulePloicy(Config schedule rules) 90-ConfigurationKeyPoint(Config key points) 100-ConfigurationFloodRisk(Config flood risk thresholds) 110-ConfigurationAutoforecast(Config auto forecast rule) 120-ConfigurationBoundary(Config model boundaries) 130-ConfigurationMapping(Config assets and model points mapping relation) 140-ConfigurationFloodSensitivePoint(Config flood sensitive points) 150-ConfigurationLegend(Config legend grades and colors) 160-ConfigurationDAPoints(Config model DA points) 170-ConfigurationFSA(Config flood storage areas) 
    /// </summary>
    /// <value>0-Default 10-CreateProject(Create a new project) 20-CreateProjectInfo(Create project information) 30-UploadModelingFile(Upload template files) 40-UploadModelTemplate(Create template scenarios) 50-DealWithModelTemplate(Export model information from the template model file) 60-Uploadasset(Config IoT assets and devices) 70-ConfigurationModelTemplate(Config template information) 80-ConfigurationSchedulePloicy(Config schedule rules) 90-ConfigurationKeyPoint(Config key points) 100-ConfigurationFloodRisk(Config flood risk thresholds) 110-ConfigurationAutoforecast(Config auto forecast rule) 120-ConfigurationBoundary(Config model boundaries) 130-ConfigurationMapping(Config assets and model points mapping relation) 140-ConfigurationFloodSensitivePoint(Config flood sensitive points) 150-ConfigurationLegend(Config legend grades and colors) 160-ConfigurationDAPoints(Config model DA points) 170-ConfigurationFSA(Config flood storage areas) </value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ProjectInitializeStepEnum
    {
        /// <summary>
        /// Enum NUMBER_0 for value: 0
        /// </summary>
        [EnumMember(Value = "0")]
        NUMBER_0 = 1,

        /// <summary>
        /// Enum NUMBER_10 for value: 10
        /// </summary>
        [EnumMember(Value = "10")]
        NUMBER_10 = 2,

        /// <summary>
        /// Enum NUMBER_20 for value: 20
        /// </summary>
        [EnumMember(Value = "20")]
        NUMBER_20 = 3,

        /// <summary>
        /// Enum NUMBER_30 for value: 30
        /// </summary>
        [EnumMember(Value = "30")]
        NUMBER_30 = 4,

        /// <summary>
        /// Enum NUMBER_40 for value: 40
        /// </summary>
        [EnumMember(Value = "40")]
        NUMBER_40 = 5,

        /// <summary>
        /// Enum NUMBER_50 for value: 50
        /// </summary>
        [EnumMember(Value = "50")]
        NUMBER_50 = 6,

        /// <summary>
        /// Enum NUMBER_60 for value: 60
        /// </summary>
        [EnumMember(Value = "60")]
        NUMBER_60 = 7,

        /// <summary>
        /// Enum NUMBER_70 for value: 70
        /// </summary>
        [EnumMember(Value = "70")]
        NUMBER_70 = 8,

        /// <summary>
        /// Enum NUMBER_80 for value: 80
        /// </summary>
        [EnumMember(Value = "80")]
        NUMBER_80 = 9,

        /// <summary>
        /// Enum NUMBER_90 for value: 90
        /// </summary>
        [EnumMember(Value = "90")]
        NUMBER_90 = 10,

        /// <summary>
        /// Enum NUMBER_100 for value: 100
        /// </summary>
        [EnumMember(Value = "100")]
        NUMBER_100 = 11,

        /// <summary>
        /// Enum NUMBER_110 for value: 110
        /// </summary>
        [EnumMember(Value = "110")]
        NUMBER_110 = 12,

        /// <summary>
        /// Enum NUMBER_120 for value: 120
        /// </summary>
        [EnumMember(Value = "120")]
        NUMBER_120 = 13,

        /// <summary>
        /// Enum NUMBER_130 for value: 130
        /// </summary>
        [EnumMember(Value = "130")]
        NUMBER_130 = 14,

        /// <summary>
        /// Enum NUMBER_140 for value: 140
        /// </summary>
        [EnumMember(Value = "140")]
        NUMBER_140 = 15,

        /// <summary>
        /// Enum NUMBER_150 for value: 150
        /// </summary>
        [EnumMember(Value = "150")]
        NUMBER_150 = 16,

        /// <summary>
        /// Enum NUMBER_160 for value: 160
        /// </summary>
        [EnumMember(Value = "160")]
        NUMBER_160 = 17,

        /// <summary>
        /// Enum NUMBER_170 for value: 170
        /// </summary>
        [EnumMember(Value = "170")]
        NUMBER_170 = 18

    }

}