/* 
 * identity-service
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
using DHICN.PAAS.SDK.Identity.Client;
using DHICN.PAAS.SDK.Identity.Model;

namespace DHICN.PAAS.SDK.Identity.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ILoginApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 登录
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DHICN.PAAS.SDK.Identity.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loginInput"> (optional)</param>
        /// <returns>List&lt;GetTenantsBySysOutput&gt;</returns>
        Result<List<GetTenantsBySysOutput>> ApiV1LoginTenantsPost (LoginInput loginInput = default(LoginInput));

        /// <summary>
        /// 登录
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DHICN.PAAS.SDK.Identity.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loginInput"> (optional)</param>
        /// <returns>ApiResponse of List&lt;GetTenantsBySysOutput&gt;</returns>
        ApiResponse<Result<List<GetTenantsBySysOutput>>> ApiV1LoginTenantsPostWithHttpInfo (LoginInput loginInput = default(LoginInput));
        /// <summary>
        /// 登录
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DHICN.PAAS.SDK.Identity.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loginInput"> (optional)</param>
        /// <returns>TokenModelWithTenant</returns>
        Result<TokenModelWithTenant> ApiV1LoginTokenPost (LoginInput loginInput = default(LoginInput));

        /// <summary>
        /// 登录
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DHICN.PAAS.SDK.Identity.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loginInput"> (optional)</param>
        /// <returns>ApiResponse of TokenModelWithTenant</returns>
        ApiResponse<Result<TokenModelWithTenant>> ApiV1LoginTokenPostWithHttpInfo (LoginInput loginInput = default(LoginInput));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ILoginApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 登录
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DHICN.PAAS.SDK.Identity.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loginInput"> (optional)</param>
        /// <returns>Task of List&lt;GetTenantsBySysOutput&gt;</returns>
        System.Threading.Tasks.Task<Result<List<GetTenantsBySysOutput>>> ApiV1LoginTenantsPostAsync (LoginInput loginInput = default(LoginInput));

        /// <summary>
        /// 登录
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DHICN.PAAS.SDK.Identity.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loginInput"> (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;GetTenantsBySysOutput&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<Result<List<GetTenantsBySysOutput>>>> ApiV1LoginTenantsPostAsyncWithHttpInfo (LoginInput loginInput = default(LoginInput));
        /// <summary>
        /// 登录
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DHICN.PAAS.SDK.Identity.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loginInput"> (optional)</param>
        /// <returns>Task of TokenModelWithTenant</returns>
        System.Threading.Tasks.Task<Result<TokenModelWithTenant>> ApiV1LoginTokenPostAsync (LoginInput loginInput = default(LoginInput));

        /// <summary>
        /// 登录
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DHICN.PAAS.SDK.Identity.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loginInput"> (optional)</param>
        /// <returns>Task of ApiResponse (TokenModelWithTenant)</returns>
        System.Threading.Tasks.Task<ApiResponse<Result<TokenModelWithTenant>>> ApiV1LoginTokenPostAsyncWithHttpInfo (LoginInput loginInput = default(LoginInput));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ILoginApi : ILoginApiSync, ILoginApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class LoginApi : ILoginApi
    {
        private DHICN.PAAS.SDK.Identity.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="LoginApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LoginApi() : this((string) null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LoginApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LoginApi(String basePath)
        {
            this.Configuration = DHICN.PAAS.SDK.Identity.Client.Configuration.MergeConfigurations(
                DHICN.PAAS.SDK.Identity.Client.GlobalConfiguration.Instance,
                new DHICN.PAAS.SDK.Identity.Client.Configuration { BasePath = basePath }
            );
            this.Client = new DHICN.PAAS.SDK.Identity.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new DHICN.PAAS.SDK.Identity.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = DHICN.PAAS.SDK.Identity.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LoginApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public LoginApi(DHICN.PAAS.SDK.Identity.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = DHICN.PAAS.SDK.Identity.Client.Configuration.MergeConfigurations(
                DHICN.PAAS.SDK.Identity.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new DHICN.PAAS.SDK.Identity.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new DHICN.PAAS.SDK.Identity.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = DHICN.PAAS.SDK.Identity.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LoginApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public LoginApi(DHICN.PAAS.SDK.Identity.Client.ISynchronousClient client,DHICN.PAAS.SDK.Identity.Client.IAsynchronousClient asyncClient, DHICN.PAAS.SDK.Identity.Client.IReadableConfiguration configuration)
        {
            if(client == null) throw new ArgumentNullException("client");
            if(asyncClient == null) throw new ArgumentNullException("asyncClient");
            if(configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = DHICN.PAAS.SDK.Identity.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public DHICN.PAAS.SDK.Identity.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public DHICN.PAAS.SDK.Identity.Client.ISynchronousClient Client { get; set; }

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
        public DHICN.PAAS.SDK.Identity.Client.IReadableConfiguration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public DHICN.PAAS.SDK.Identity.Client.ExceptionFactory ExceptionFactory
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
        /// 登录 
        /// </summary>
        /// <exception cref="DHICN.PAAS.SDK.Identity.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loginInput"> (optional)</param>
        /// <returns>List&lt;GetTenantsBySysOutput&gt;</returns>
        public Result<List<GetTenantsBySysOutput>> ApiV1LoginTenantsPost (LoginInput loginInput = default(LoginInput))
        {
             DHICN.PAAS.SDK.Identity.Client.ApiResponse<Result<List<GetTenantsBySysOutput>>> localVarResponse = ApiV1LoginTenantsPostWithHttpInfo(loginInput);
             return localVarResponse.Data;
        }

        /// <summary>
        /// 登录 
        /// </summary>
        /// <exception cref="DHICN.PAAS.SDK.Identity.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loginInput"> (optional)</param>
        /// <returns>ApiResponse of List&lt;GetTenantsBySysOutput&gt;</returns>
        public DHICN.PAAS.SDK.Identity.Client.ApiResponse<Result< List<GetTenantsBySysOutput> >> ApiV1LoginTenantsPostWithHttpInfo (LoginInput loginInput = default(LoginInput))
        {
            DHICN.PAAS.SDK.Identity.Client.RequestOptions localVarRequestOptions = new DHICN.PAAS.SDK.Identity.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = DHICN.PAAS.SDK.Identity.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = DHICN.PAAS.SDK.Identity.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = loginInput;


            // make the HTTP request
            var localVarResponse = this.Client.Post<Result< List<GetTenantsBySysOutput> >>("/api/v1/login/tenants", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiV1LoginTenantsPost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// 登录 
        /// </summary>
        /// <exception cref="DHICN.PAAS.SDK.Identity.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loginInput"> (optional)</param>
        /// <returns>Task of List&lt;GetTenantsBySysOutput&gt;</returns>
        public async System.Threading.Tasks.Task<Result<List<GetTenantsBySysOutput>>> ApiV1LoginTenantsPostAsync (LoginInput loginInput = default(LoginInput))
        {
             DHICN.PAAS.SDK.Identity.Client.ApiResponse<Result<List<GetTenantsBySysOutput>>> localVarResponse = await ApiV1LoginTenantsPostAsyncWithHttpInfo(loginInput);
             return localVarResponse.Data;

        }

        /// <summary>
        /// 登录 
        /// </summary>
        /// <exception cref="DHICN.PAAS.SDK.Identity.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loginInput"> (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;GetTenantsBySysOutput&gt;)</returns>
        public async System.Threading.Tasks.Task<DHICN.PAAS.SDK.Identity.Client.ApiResponse<Result<List<GetTenantsBySysOutput>>>> ApiV1LoginTenantsPostAsyncWithHttpInfo (LoginInput loginInput = default(LoginInput))
        {

            DHICN.PAAS.SDK.Identity.Client.RequestOptions localVarRequestOptions = new DHICN.PAAS.SDK.Identity.Client.RequestOptions();

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
            
            localVarRequestOptions.Data = loginInput;


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<Result<List<GetTenantsBySysOutput>>>("/api/v1/login/tenants", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiV1LoginTenantsPost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// 登录 
        /// </summary>
        /// <exception cref="DHICN.PAAS.SDK.Identity.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loginInput"> (optional)</param>
        /// <returns>TokenModelWithTenant</returns>
        public Result<TokenModelWithTenant> ApiV1LoginTokenPost (LoginInput loginInput = default(LoginInput))
        {
             DHICN.PAAS.SDK.Identity.Client.ApiResponse<Result<TokenModelWithTenant>> localVarResponse = ApiV1LoginTokenPostWithHttpInfo(loginInput);
             return localVarResponse.Data;
        }

        /// <summary>
        /// 登录 
        /// </summary>
        /// <exception cref="DHICN.PAAS.SDK.Identity.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loginInput"> (optional)</param>
        /// <returns>ApiResponse of TokenModelWithTenant</returns>
        public DHICN.PAAS.SDK.Identity.Client.ApiResponse<Result< TokenModelWithTenant >> ApiV1LoginTokenPostWithHttpInfo (LoginInput loginInput = default(LoginInput))
        {
            DHICN.PAAS.SDK.Identity.Client.RequestOptions localVarRequestOptions = new DHICN.PAAS.SDK.Identity.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = DHICN.PAAS.SDK.Identity.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = DHICN.PAAS.SDK.Identity.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = loginInput;


            // make the HTTP request
            var localVarResponse = this.Client.Post<Result< TokenModelWithTenant >>("/api/v1/login/token", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiV1LoginTokenPost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// 登录 
        /// </summary>
        /// <exception cref="DHICN.PAAS.SDK.Identity.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loginInput"> (optional)</param>
        /// <returns>Task of TokenModelWithTenant</returns>
        public async System.Threading.Tasks.Task<Result<TokenModelWithTenant>> ApiV1LoginTokenPostAsync (LoginInput loginInput = default(LoginInput))
        {
             DHICN.PAAS.SDK.Identity.Client.ApiResponse<Result<TokenModelWithTenant>> localVarResponse = await ApiV1LoginTokenPostAsyncWithHttpInfo(loginInput);
             return localVarResponse.Data;

        }

        /// <summary>
        /// 登录 
        /// </summary>
        /// <exception cref="DHICN.PAAS.SDK.Identity.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loginInput"> (optional)</param>
        /// <returns>Task of ApiResponse (TokenModelWithTenant)</returns>
        public async System.Threading.Tasks.Task<DHICN.PAAS.SDK.Identity.Client.ApiResponse<Result<TokenModelWithTenant>>> ApiV1LoginTokenPostAsyncWithHttpInfo (LoginInput loginInput = default(LoginInput))
        {

            DHICN.PAAS.SDK.Identity.Client.RequestOptions localVarRequestOptions = new DHICN.PAAS.SDK.Identity.Client.RequestOptions();

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
            
            localVarRequestOptions.Data = loginInput;


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<Result<TokenModelWithTenant>>("/api/v1/login/token", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiV1LoginTokenPost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
