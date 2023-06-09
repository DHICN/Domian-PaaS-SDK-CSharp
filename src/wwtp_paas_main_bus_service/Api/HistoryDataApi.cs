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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using wwtp_paas_main_bus_service.Client;
using wwtp_paas_main_bus_service.Model;

namespace wwtp_paas_main_bus_service.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IHistoryDataApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 导出清洗后的在线数据，模拟结果数据 Export processed online data or model result data as an excel file
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="wwtp_paas_main_bus_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryByConditionInput"> (optional)</param>
        /// <returns></returns>
        void ApiV2HistoryDataExportPost (QueryByConditionInput queryByConditionInput = default(QueryByConditionInput));

        /// <summary>
        /// 导出清洗后的在线数据，模拟结果数据 Export processed online data or model result data as an excel file
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="wwtp_paas_main_bus_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryByConditionInput"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Result<Object>> ApiV2HistoryDataExportPostWithHttpInfo (QueryByConditionInput queryByConditionInput = default(QueryByConditionInput));
        /// <summary>
        /// 根据时间段和点位代码查询清洗后的在线数据和模拟结果数据 Get processed online data or model result data by time and codes
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="wwtp_paas_main_bus_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryByConditionInput"> (optional)</param>
        /// <returns>List&lt;TsDataOutput&gt;</returns>
        Result<List<TsDataOutput>> ApiV2HistoryDataGetByConditionPost (QueryByConditionInput queryByConditionInput = default(QueryByConditionInput));

        /// <summary>
        /// 根据时间段和点位代码查询清洗后的在线数据和模拟结果数据 Get processed online data or model result data by time and codes
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="wwtp_paas_main_bus_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryByConditionInput"> (optional)</param>
        /// <returns>ApiResponse of List&lt;TsDataOutput&gt;</returns>
        ApiResponse<Result<List<TsDataOutput>>> ApiV2HistoryDataGetByConditionPostWithHttpInfo (QueryByConditionInput queryByConditionInput = default(QueryByConditionInput));
        /// <summary>
        /// 获取指标查询的可选择项的具体信息 Get all the historical data indicators for selection on the front end
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="wwtp_paas_main_bus_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="modelName">模板模型名称 template model name (optional)</param>
        /// <returns>List&lt;SelectItemNode&gt;</returns>
        Result<List<SelectItemNode>> ApiV2HistoryDataSelectItemsGet (string modelName = default(string));

        /// <summary>
        /// 获取指标查询的可选择项的具体信息 Get all the historical data indicators for selection on the front end
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="wwtp_paas_main_bus_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="modelName">模板模型名称 template model name (optional)</param>
        /// <returns>ApiResponse of List&lt;SelectItemNode&gt;</returns>
        ApiResponse<Result<List<SelectItemNode>>> ApiV2HistoryDataSelectItemsGetWithHttpInfo (string modelName = default(string));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IHistoryDataApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 导出清洗后的在线数据，模拟结果数据 Export processed online data or model result data as an excel file
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="wwtp_paas_main_bus_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryByConditionInput"> (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ApiV2HistoryDataExportPostAsync (QueryByConditionInput queryByConditionInput = default(QueryByConditionInput));

        /// <summary>
        /// 导出清洗后的在线数据，模拟结果数据 Export processed online data or model result data as an excel file
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="wwtp_paas_main_bus_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryByConditionInput"> (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Result<Object>>> ApiV2HistoryDataExportPostAsyncWithHttpInfo (QueryByConditionInput queryByConditionInput = default(QueryByConditionInput));
        /// <summary>
        /// 根据时间段和点位代码查询清洗后的在线数据和模拟结果数据 Get processed online data or model result data by time and codes
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="wwtp_paas_main_bus_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryByConditionInput"> (optional)</param>
        /// <returns>Task of List&lt;TsDataOutput&gt;</returns>
        System.Threading.Tasks.Task<Result<List<TsDataOutput>>> ApiV2HistoryDataGetByConditionPostAsync (QueryByConditionInput queryByConditionInput = default(QueryByConditionInput));

        /// <summary>
        /// 根据时间段和点位代码查询清洗后的在线数据和模拟结果数据 Get processed online data or model result data by time and codes
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="wwtp_paas_main_bus_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryByConditionInput"> (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;TsDataOutput&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<Result<List<TsDataOutput>>>> ApiV2HistoryDataGetByConditionPostAsyncWithHttpInfo (QueryByConditionInput queryByConditionInput = default(QueryByConditionInput));
        /// <summary>
        /// 获取指标查询的可选择项的具体信息 Get all the historical data indicators for selection on the front end
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="wwtp_paas_main_bus_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="modelName">模板模型名称 template model name (optional)</param>
        /// <returns>Task of List&lt;SelectItemNode&gt;</returns>
        System.Threading.Tasks.Task<Result<List<SelectItemNode>>> ApiV2HistoryDataSelectItemsGetAsync (string modelName = default(string));

        /// <summary>
        /// 获取指标查询的可选择项的具体信息 Get all the historical data indicators for selection on the front end
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="wwtp_paas_main_bus_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="modelName">模板模型名称 template model name (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;SelectItemNode&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<Result<List<SelectItemNode>>>> ApiV2HistoryDataSelectItemsGetAsyncWithHttpInfo (string modelName = default(string));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IHistoryDataApi : IHistoryDataApiSync, IHistoryDataApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class HistoryDataApi : IHistoryDataApi
    {
        private wwtp_paas_main_bus_service.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="HistoryDataApi"/> class.
        /// </summary>
        /// <returns></returns>
        public HistoryDataApi() : this((string) null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HistoryDataApi"/> class.
        /// </summary>
        /// <returns></returns>
        public HistoryDataApi(String basePath)
        {
            this.Configuration = wwtp_paas_main_bus_service.Client.Configuration.MergeConfigurations(
                wwtp_paas_main_bus_service.Client.GlobalConfiguration.Instance,
                new wwtp_paas_main_bus_service.Client.Configuration { BasePath = basePath }
            );
            this.Client = new wwtp_paas_main_bus_service.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new wwtp_paas_main_bus_service.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = wwtp_paas_main_bus_service.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HistoryDataApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public HistoryDataApi(wwtp_paas_main_bus_service.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = wwtp_paas_main_bus_service.Client.Configuration.MergeConfigurations(
                wwtp_paas_main_bus_service.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new wwtp_paas_main_bus_service.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new wwtp_paas_main_bus_service.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = wwtp_paas_main_bus_service.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HistoryDataApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public HistoryDataApi(wwtp_paas_main_bus_service.Client.ISynchronousClient client,wwtp_paas_main_bus_service.Client.IAsynchronousClient asyncClient, wwtp_paas_main_bus_service.Client.IReadableConfiguration configuration)
        {
            if(client == null) throw new ArgumentNullException("client");
            if(asyncClient == null) throw new ArgumentNullException("asyncClient");
            if(configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = wwtp_paas_main_bus_service.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public wwtp_paas_main_bus_service.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public wwtp_paas_main_bus_service.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public wwtp_paas_main_bus_service.Client.IReadableConfiguration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public wwtp_paas_main_bus_service.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// 导出清洗后的在线数据，模拟结果数据 Export processed online data or model result data as an excel file 
        /// </summary>
        /// <exception cref="wwtp_paas_main_bus_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryByConditionInput"> (optional)</param>
        /// <returns></returns>
        public void ApiV2HistoryDataExportPost (QueryByConditionInput queryByConditionInput = default(QueryByConditionInput))
        {
             ApiV2HistoryDataExportPostWithHttpInfo(queryByConditionInput);
        }

        /// <summary>
        /// 导出清洗后的在线数据，模拟结果数据 Export processed online data or model result data as an excel file 
        /// </summary>
        /// <exception cref="wwtp_paas_main_bus_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryByConditionInput"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public wwtp_paas_main_bus_service.Client.ApiResponse<Result<Object>> ApiV2HistoryDataExportPostWithHttpInfo (QueryByConditionInput queryByConditionInput = default(QueryByConditionInput))
        {
            wwtp_paas_main_bus_service.Client.RequestOptions localVarRequestOptions = new wwtp_paas_main_bus_service.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = wwtp_paas_main_bus_service.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = wwtp_paas_main_bus_service.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = queryByConditionInput;


            // make the HTTP request
            var localVarResponse = this.Client.Post<Result<Object>>("/api/v2/history-data/export", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiV2HistoryDataExportPost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// 导出清洗后的在线数据，模拟结果数据 Export processed online data or model result data as an excel file 
        /// </summary>
        /// <exception cref="wwtp_paas_main_bus_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryByConditionInput"> (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ApiV2HistoryDataExportPostAsync (QueryByConditionInput queryByConditionInput = default(QueryByConditionInput))
        {
             await ApiV2HistoryDataExportPostAsyncWithHttpInfo(queryByConditionInput);

        }

        /// <summary>
        /// 导出清洗后的在线数据，模拟结果数据 Export processed online data or model result data as an excel file 
        /// </summary>
        /// <exception cref="wwtp_paas_main_bus_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryByConditionInput"> (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<wwtp_paas_main_bus_service.Client.ApiResponse<Result<Object>>> ApiV2HistoryDataExportPostAsyncWithHttpInfo (QueryByConditionInput queryByConditionInput = default(QueryByConditionInput))
        {

            wwtp_paas_main_bus_service.Client.RequestOptions localVarRequestOptions = new wwtp_paas_main_bus_service.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            
            localVarRequestOptions.Data = queryByConditionInput;


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<Result<Object>>("/api/v2/history-data/export", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiV2HistoryDataExportPost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// 根据时间段和点位代码查询清洗后的在线数据和模拟结果数据 Get processed online data or model result data by time and codes 
        /// </summary>
        /// <exception cref="wwtp_paas_main_bus_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryByConditionInput"> (optional)</param>
        /// <returns>List&lt;TsDataOutput&gt;</returns>
        public Result<List<TsDataOutput>> ApiV2HistoryDataGetByConditionPost (QueryByConditionInput queryByConditionInput = default(QueryByConditionInput))
        {
             wwtp_paas_main_bus_service.Client.ApiResponse<Result<List<TsDataOutput>>> localVarResponse = ApiV2HistoryDataGetByConditionPostWithHttpInfo(queryByConditionInput);
             return localVarResponse.Data;
        }

        /// <summary>
        /// 根据时间段和点位代码查询清洗后的在线数据和模拟结果数据 Get processed online data or model result data by time and codes 
        /// </summary>
        /// <exception cref="wwtp_paas_main_bus_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryByConditionInput"> (optional)</param>
        /// <returns>ApiResponse of List&lt;TsDataOutput&gt;</returns>
        public wwtp_paas_main_bus_service.Client.ApiResponse<Result< List<TsDataOutput> >> ApiV2HistoryDataGetByConditionPostWithHttpInfo (QueryByConditionInput queryByConditionInput = default(QueryByConditionInput))
        {
            wwtp_paas_main_bus_service.Client.RequestOptions localVarRequestOptions = new wwtp_paas_main_bus_service.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = wwtp_paas_main_bus_service.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = wwtp_paas_main_bus_service.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = queryByConditionInput;


            // make the HTTP request
            var localVarResponse = this.Client.Post<Result< List<TsDataOutput> >>("/api/v2/history-data/get-by-condition", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiV2HistoryDataGetByConditionPost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// 根据时间段和点位代码查询清洗后的在线数据和模拟结果数据 Get processed online data or model result data by time and codes 
        /// </summary>
        /// <exception cref="wwtp_paas_main_bus_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryByConditionInput"> (optional)</param>
        /// <returns>Task of List&lt;TsDataOutput&gt;</returns>
        public async System.Threading.Tasks.Task<Result<List<TsDataOutput>>> ApiV2HistoryDataGetByConditionPostAsync (QueryByConditionInput queryByConditionInput = default(QueryByConditionInput))
        {
             wwtp_paas_main_bus_service.Client.ApiResponse<Result<List<TsDataOutput>>> localVarResponse = await ApiV2HistoryDataGetByConditionPostAsyncWithHttpInfo(queryByConditionInput);
             return localVarResponse.Data;

        }

        /// <summary>
        /// 根据时间段和点位代码查询清洗后的在线数据和模拟结果数据 Get processed online data or model result data by time and codes 
        /// </summary>
        /// <exception cref="wwtp_paas_main_bus_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryByConditionInput"> (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;TsDataOutput&gt;)</returns>
        public async System.Threading.Tasks.Task<wwtp_paas_main_bus_service.Client.ApiResponse<Result<List<TsDataOutput>>>> ApiV2HistoryDataGetByConditionPostAsyncWithHttpInfo (QueryByConditionInput queryByConditionInput = default(QueryByConditionInput))
        {

            wwtp_paas_main_bus_service.Client.RequestOptions localVarRequestOptions = new wwtp_paas_main_bus_service.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            
            localVarRequestOptions.Data = queryByConditionInput;


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<Result<List<TsDataOutput>>>("/api/v2/history-data/get-by-condition", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiV2HistoryDataGetByConditionPost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// 获取指标查询的可选择项的具体信息 Get all the historical data indicators for selection on the front end 
        /// </summary>
        /// <exception cref="wwtp_paas_main_bus_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="modelName">模板模型名称 template model name (optional)</param>
        /// <returns>List&lt;SelectItemNode&gt;</returns>
        public Result<List<SelectItemNode>> ApiV2HistoryDataSelectItemsGet (string modelName = default(string))
        {
             wwtp_paas_main_bus_service.Client.ApiResponse<Result<List<SelectItemNode>>> localVarResponse = ApiV2HistoryDataSelectItemsGetWithHttpInfo(modelName);
             return localVarResponse.Data;
        }

        /// <summary>
        /// 获取指标查询的可选择项的具体信息 Get all the historical data indicators for selection on the front end 
        /// </summary>
        /// <exception cref="wwtp_paas_main_bus_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="modelName">模板模型名称 template model name (optional)</param>
        /// <returns>ApiResponse of List&lt;SelectItemNode&gt;</returns>
        public wwtp_paas_main_bus_service.Client.ApiResponse<Result< List<SelectItemNode> >> ApiV2HistoryDataSelectItemsGetWithHttpInfo (string modelName = default(string))
        {
            wwtp_paas_main_bus_service.Client.RequestOptions localVarRequestOptions = new wwtp_paas_main_bus_service.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = wwtp_paas_main_bus_service.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = wwtp_paas_main_bus_service.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (modelName != null)
            {
                localVarRequestOptions.QueryParameters.Add(wwtp_paas_main_bus_service.Client.ClientUtils.ParameterToMultiMap("", "modelName", modelName));
            }


            // make the HTTP request
            var localVarResponse = this.Client.Get<Result< List<SelectItemNode> >>("/api/v2/history-data/select-items", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiV2HistoryDataSelectItemsGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// 获取指标查询的可选择项的具体信息 Get all the historical data indicators for selection on the front end 
        /// </summary>
        /// <exception cref="wwtp_paas_main_bus_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="modelName">模板模型名称 template model name (optional)</param>
        /// <returns>Task of List&lt;SelectItemNode&gt;</returns>
        public async System.Threading.Tasks.Task<Result<List<SelectItemNode>>> ApiV2HistoryDataSelectItemsGetAsync (string modelName = default(string))
        {
             wwtp_paas_main_bus_service.Client.ApiResponse<Result<List<SelectItemNode>>> localVarResponse = await ApiV2HistoryDataSelectItemsGetAsyncWithHttpInfo(modelName);
             return localVarResponse.Data;

        }

        /// <summary>
        /// 获取指标查询的可选择项的具体信息 Get all the historical data indicators for selection on the front end 
        /// </summary>
        /// <exception cref="wwtp_paas_main_bus_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="modelName">模板模型名称 template model name (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;SelectItemNode&gt;)</returns>
        public async System.Threading.Tasks.Task<wwtp_paas_main_bus_service.Client.ApiResponse<Result<List<SelectItemNode>>>> ApiV2HistoryDataSelectItemsGetAsyncWithHttpInfo (string modelName = default(string))
        {

            wwtp_paas_main_bus_service.Client.RequestOptions localVarRequestOptions = new wwtp_paas_main_bus_service.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            
            if (modelName != null)
            {
                localVarRequestOptions.QueryParameters.Add(wwtp_paas_main_bus_service.Client.ClientUtils.ParameterToMultiMap("", "modelName", modelName));
            }


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<Result<List<SelectItemNode>>>("/api/v2/history-data/select-items", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiV2HistoryDataSelectItemsGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
