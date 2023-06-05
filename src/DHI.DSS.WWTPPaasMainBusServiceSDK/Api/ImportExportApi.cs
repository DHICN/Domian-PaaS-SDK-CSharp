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
using DHI.DSS.WWTPPaasMainBusServiceSDK.Client;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Model;

namespace DHI.DSS.WWTPPaasMainBusServiceSDK.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IImportExportApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 导入业务服务配置文件Excel / Import config Excel
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DHI.DSS.WWTPPaasMainBusServiceSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="excelFile"> (optional)</param>
        /// <returns>StringListResult</returns>
        Result<StringListResult> ApiV2ConfigImportConfigExcelPost (System.IO.Stream excelFile = default(System.IO.Stream));

        /// <summary>
        /// 导入业务服务配置文件Excel / Import config Excel
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DHI.DSS.WWTPPaasMainBusServiceSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="excelFile"> (optional)</param>
        /// <returns>ApiResponse of StringListResult</returns>
        ApiResponse<Result<StringListResult>> ApiV2ConfigImportConfigExcelPostWithHttpInfo (System.IO.Stream excelFile = default(System.IO.Stream));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IImportExportApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 导入业务服务配置文件Excel / Import config Excel
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DHI.DSS.WWTPPaasMainBusServiceSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="excelFile"> (optional)</param>
        /// <returns>Task of StringListResult</returns>
        System.Threading.Tasks.Task<Result<StringListResult>> ApiV2ConfigImportConfigExcelPostAsync (System.IO.Stream excelFile = default(System.IO.Stream));

        /// <summary>
        /// 导入业务服务配置文件Excel / Import config Excel
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DHI.DSS.WWTPPaasMainBusServiceSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="excelFile"> (optional)</param>
        /// <returns>Task of ApiResponse (StringListResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<Result<StringListResult>>> ApiV2ConfigImportConfigExcelPostAsyncWithHttpInfo (System.IO.Stream excelFile = default(System.IO.Stream));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IImportExportApi : IImportExportApiSync, IImportExportApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ImportExportApi : IImportExportApi
    {
        private DHI.DSS.WWTPPaasMainBusServiceSDK.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportExportApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ImportExportApi() : this((string) null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportExportApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ImportExportApi(String basePath)
        {
            this.Configuration = DHI.DSS.WWTPPaasMainBusServiceSDK.Client.Configuration.MergeConfigurations(
                DHI.DSS.WWTPPaasMainBusServiceSDK.Client.GlobalConfiguration.Instance,
                new DHI.DSS.WWTPPaasMainBusServiceSDK.Client.Configuration { BasePath = basePath }
            );
            this.Client = new DHI.DSS.WWTPPaasMainBusServiceSDK.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new DHI.DSS.WWTPPaasMainBusServiceSDK.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = DHI.DSS.WWTPPaasMainBusServiceSDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportExportApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ImportExportApi(DHI.DSS.WWTPPaasMainBusServiceSDK.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = DHI.DSS.WWTPPaasMainBusServiceSDK.Client.Configuration.MergeConfigurations(
                DHI.DSS.WWTPPaasMainBusServiceSDK.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new DHI.DSS.WWTPPaasMainBusServiceSDK.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new DHI.DSS.WWTPPaasMainBusServiceSDK.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = DHI.DSS.WWTPPaasMainBusServiceSDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportExportApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public ImportExportApi(DHI.DSS.WWTPPaasMainBusServiceSDK.Client.ISynchronousClient client,DHI.DSS.WWTPPaasMainBusServiceSDK.Client.IAsynchronousClient asyncClient, DHI.DSS.WWTPPaasMainBusServiceSDK.Client.IReadableConfiguration configuration)
        {
            if(client == null) throw new ArgumentNullException("client");
            if(asyncClient == null) throw new ArgumentNullException("asyncClient");
            if(configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = DHI.DSS.WWTPPaasMainBusServiceSDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public DHI.DSS.WWTPPaasMainBusServiceSDK.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public DHI.DSS.WWTPPaasMainBusServiceSDK.Client.ISynchronousClient Client { get; set; }

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
        public DHI.DSS.WWTPPaasMainBusServiceSDK.Client.IReadableConfiguration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public DHI.DSS.WWTPPaasMainBusServiceSDK.Client.ExceptionFactory ExceptionFactory
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
        /// 导入业务服务配置文件Excel / Import config Excel 
        /// </summary>
        /// <exception cref="DHI.DSS.WWTPPaasMainBusServiceSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="excelFile"> (optional)</param>
        /// <returns>StringListResult</returns>
        public Result<StringListResult> ApiV2ConfigImportConfigExcelPost (System.IO.Stream excelFile = default(System.IO.Stream))
        {
             DHI.DSS.WWTPPaasMainBusServiceSDK.Client.ApiResponse<Result<StringListResult>> localVarResponse = ApiV2ConfigImportConfigExcelPostWithHttpInfo(excelFile);
             return localVarResponse.Data;
        }

        /// <summary>
        /// 导入业务服务配置文件Excel / Import config Excel 
        /// </summary>
        /// <exception cref="DHI.DSS.WWTPPaasMainBusServiceSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="excelFile"> (optional)</param>
        /// <returns>ApiResponse of StringListResult</returns>
        public DHI.DSS.WWTPPaasMainBusServiceSDK.Client.ApiResponse<Result< StringListResult >> ApiV2ConfigImportConfigExcelPostWithHttpInfo (System.IO.Stream excelFile = default(System.IO.Stream))
        {
            DHI.DSS.WWTPPaasMainBusServiceSDK.Client.RequestOptions localVarRequestOptions = new DHI.DSS.WWTPPaasMainBusServiceSDK.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "multipart/form-data"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = DHI.DSS.WWTPPaasMainBusServiceSDK.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = DHI.DSS.WWTPPaasMainBusServiceSDK.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (excelFile != null)
            {
                localVarRequestOptions.FileParameters.Add("excelFile", excelFile);
            }


            // make the HTTP request
            var localVarResponse = this.Client.Post<Result< StringListResult >>("/api/v2/config/import-config-excel", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiV2ConfigImportConfigExcelPost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// 导入业务服务配置文件Excel / Import config Excel 
        /// </summary>
        /// <exception cref="DHI.DSS.WWTPPaasMainBusServiceSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="excelFile"> (optional)</param>
        /// <returns>Task of StringListResult</returns>
        public async System.Threading.Tasks.Task<Result<StringListResult>> ApiV2ConfigImportConfigExcelPostAsync (System.IO.Stream excelFile = default(System.IO.Stream))
        {
             DHI.DSS.WWTPPaasMainBusServiceSDK.Client.ApiResponse<Result<StringListResult>> localVarResponse = await ApiV2ConfigImportConfigExcelPostAsyncWithHttpInfo(excelFile);
             return localVarResponse.Data;

        }

        /// <summary>
        /// 导入业务服务配置文件Excel / Import config Excel 
        /// </summary>
        /// <exception cref="DHI.DSS.WWTPPaasMainBusServiceSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="excelFile"> (optional)</param>
        /// <returns>Task of ApiResponse (StringListResult)</returns>
        public async System.Threading.Tasks.Task<DHI.DSS.WWTPPaasMainBusServiceSDK.Client.ApiResponse<Result<StringListResult>>> ApiV2ConfigImportConfigExcelPostAsyncWithHttpInfo (System.IO.Stream excelFile = default(System.IO.Stream))
        {

            DHI.DSS.WWTPPaasMainBusServiceSDK.Client.RequestOptions localVarRequestOptions = new DHI.DSS.WWTPPaasMainBusServiceSDK.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "multipart/form-data"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            
            if (excelFile != null)
            {
                localVarRequestOptions.FileParameters.Add("excelFile", excelFile);
            }


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<Result<StringListResult>>("/api/v2/config/import-config-excel", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiV2ConfigImportConfigExcelPost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
