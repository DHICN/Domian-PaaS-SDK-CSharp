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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using DHICN.PAAS.SDK.Message.Center.Client;
using DHICN.PAAS.SDK.Message.Center.Model;

namespace DHICN.PAAS.SDK.Message.Center.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IUserClientApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 通过UserId 和 cid 删除数据
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DHICN.PAAS.SDK.Message.Center.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deleteClientInput"> (optional)</param>
        /// <returns>bool</returns>
        Result<bool> ApiV1MessagePushUserClientDeleteByCidPost (DeleteClientInput deleteClientInput = default(DeleteClientInput));

        /// <summary>
        /// 通过UserId 和 cid 删除数据
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DHICN.PAAS.SDK.Message.Center.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deleteClientInput"> (optional)</param>
        /// <returns>ApiResponse of bool</returns>
        ApiResponse<Result<bool>> ApiV1MessagePushUserClientDeleteByCidPostWithHttpInfo (DeleteClientInput deleteClientInput = default(DeleteClientInput));
        /// <summary>
        /// /api/v1/message/push/user-client/delete
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DHICN.PAAS.SDK.Message.Center.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody"> (optional)</param>
        /// <returns>bool</returns>
        Result<bool> ApiV1MessagePushUserClientDeletePost (List<Guid> requestBody = default(List<Guid>));

        /// <summary>
        /// /api/v1/message/push/user-client/delete
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DHICN.PAAS.SDK.Message.Center.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody"> (optional)</param>
        /// <returns>ApiResponse of bool</returns>
        ApiResponse<Result<bool>> ApiV1MessagePushUserClientDeletePostWithHttpInfo (List<Guid> requestBody = default(List<Guid>));
        /// <summary>
        /// 保存用户客户端信息
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DHICN.PAAS.SDK.Message.Center.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveClientInput"> (optional)</param>
        /// <returns>bool</returns>
        Result<bool> ApiV1MessagePushUserClientSaveClientPost (SaveClientInput saveClientInput = default(SaveClientInput));

        /// <summary>
        /// 保存用户客户端信息
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DHICN.PAAS.SDK.Message.Center.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveClientInput"> (optional)</param>
        /// <returns>ApiResponse of bool</returns>
        ApiResponse<Result<bool>> ApiV1MessagePushUserClientSaveClientPostWithHttpInfo (SaveClientInput saveClientInput = default(SaveClientInput));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IUserClientApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 通过UserId 和 cid 删除数据
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DHICN.PAAS.SDK.Message.Center.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deleteClientInput"> (optional)</param>
        /// <returns>Task of bool</returns>
        System.Threading.Tasks.Task<Result<bool>> ApiV1MessagePushUserClientDeleteByCidPostAsync (DeleteClientInput deleteClientInput = default(DeleteClientInput));

        /// <summary>
        /// 通过UserId 和 cid 删除数据
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DHICN.PAAS.SDK.Message.Center.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deleteClientInput"> (optional)</param>
        /// <returns>Task of ApiResponse (bool)</returns>
        System.Threading.Tasks.Task<ApiResponse<Result<bool>>> ApiV1MessagePushUserClientDeleteByCidPostAsyncWithHttpInfo (DeleteClientInput deleteClientInput = default(DeleteClientInput));
        /// <summary>
        /// /api/v1/message/push/user-client/delete
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DHICN.PAAS.SDK.Message.Center.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody"> (optional)</param>
        /// <returns>Task of bool</returns>
        System.Threading.Tasks.Task<Result<bool>> ApiV1MessagePushUserClientDeletePostAsync (List<Guid> requestBody = default(List<Guid>));

        /// <summary>
        /// /api/v1/message/push/user-client/delete
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DHICN.PAAS.SDK.Message.Center.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody"> (optional)</param>
        /// <returns>Task of ApiResponse (bool)</returns>
        System.Threading.Tasks.Task<ApiResponse<Result<bool>>> ApiV1MessagePushUserClientDeletePostAsyncWithHttpInfo (List<Guid> requestBody = default(List<Guid>));
        /// <summary>
        /// 保存用户客户端信息
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DHICN.PAAS.SDK.Message.Center.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveClientInput"> (optional)</param>
        /// <returns>Task of bool</returns>
        System.Threading.Tasks.Task<Result<bool>> ApiV1MessagePushUserClientSaveClientPostAsync (SaveClientInput saveClientInput = default(SaveClientInput));

        /// <summary>
        /// 保存用户客户端信息
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DHICN.PAAS.SDK.Message.Center.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveClientInput"> (optional)</param>
        /// <returns>Task of ApiResponse (bool)</returns>
        System.Threading.Tasks.Task<ApiResponse<Result<bool>>> ApiV1MessagePushUserClientSaveClientPostAsyncWithHttpInfo (SaveClientInput saveClientInput = default(SaveClientInput));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IUserClientApi : IUserClientApiSync, IUserClientApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class UserClientApi : IUserClientApi
    {
        private DHICN.PAAS.SDK.Message.Center.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserClientApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UserClientApi() : this((string) null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserClientApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UserClientApi(String basePath)
        {
            this.Configuration = DHICN.PAAS.SDK.Message.Center.Client.Configuration.MergeConfigurations(
                DHICN.PAAS.SDK.Message.Center.Client.GlobalConfiguration.Instance,
                new DHICN.PAAS.SDK.Message.Center.Client.Configuration { BasePath = basePath }
            );
            this.Client = new DHICN.PAAS.SDK.Message.Center.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new DHICN.PAAS.SDK.Message.Center.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = DHICN.PAAS.SDK.Message.Center.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserClientApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public UserClientApi(DHICN.PAAS.SDK.Message.Center.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = DHICN.PAAS.SDK.Message.Center.Client.Configuration.MergeConfigurations(
                DHICN.PAAS.SDK.Message.Center.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new DHICN.PAAS.SDK.Message.Center.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new DHICN.PAAS.SDK.Message.Center.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = DHICN.PAAS.SDK.Message.Center.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserClientApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public UserClientApi(DHICN.PAAS.SDK.Message.Center.Client.ISynchronousClient client,DHICN.PAAS.SDK.Message.Center.Client.IAsynchronousClient asyncClient, DHICN.PAAS.SDK.Message.Center.Client.IReadableConfiguration configuration)
        {
            if(client == null) throw new ArgumentNullException("client");
            if(asyncClient == null) throw new ArgumentNullException("asyncClient");
            if(configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = DHICN.PAAS.SDK.Message.Center.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public DHICN.PAAS.SDK.Message.Center.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public DHICN.PAAS.SDK.Message.Center.Client.ISynchronousClient Client { get; set; }

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
        public DHICN.PAAS.SDK.Message.Center.Client.IReadableConfiguration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public DHICN.PAAS.SDK.Message.Center.Client.ExceptionFactory ExceptionFactory
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
        /// 通过UserId 和 cid 删除数据 
        /// </summary>
        /// <exception cref="DHICN.PAAS.SDK.Message.Center.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deleteClientInput"> (optional)</param>
        /// <returns>bool</returns>
        public Result<bool> ApiV1MessagePushUserClientDeleteByCidPost (DeleteClientInput deleteClientInput = default(DeleteClientInput))
        {
             DHICN.PAAS.SDK.Message.Center.Client.ApiResponse<Result<bool>> localVarResponse = ApiV1MessagePushUserClientDeleteByCidPostWithHttpInfo(deleteClientInput);
             return localVarResponse.Data;
        }

        /// <summary>
        /// 通过UserId 和 cid 删除数据 
        /// </summary>
        /// <exception cref="DHICN.PAAS.SDK.Message.Center.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deleteClientInput"> (optional)</param>
        /// <returns>ApiResponse of bool</returns>
        public DHICN.PAAS.SDK.Message.Center.Client.ApiResponse<Result< bool >> ApiV1MessagePushUserClientDeleteByCidPostWithHttpInfo (DeleteClientInput deleteClientInput = default(DeleteClientInput))
        {
            DHICN.PAAS.SDK.Message.Center.Client.RequestOptions localVarRequestOptions = new DHICN.PAAS.SDK.Message.Center.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = DHICN.PAAS.SDK.Message.Center.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = DHICN.PAAS.SDK.Message.Center.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = deleteClientInput;


            // make the HTTP request
            var localVarResponse = this.Client.Post<Result< bool >>("/api/v1/message/push/user-client/delete-by-cid", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiV1MessagePushUserClientDeleteByCidPost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// 通过UserId 和 cid 删除数据 
        /// </summary>
        /// <exception cref="DHICN.PAAS.SDK.Message.Center.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deleteClientInput"> (optional)</param>
        /// <returns>Task of bool</returns>
        public async System.Threading.Tasks.Task<Result<bool>> ApiV1MessagePushUserClientDeleteByCidPostAsync (DeleteClientInput deleteClientInput = default(DeleteClientInput))
        {
             DHICN.PAAS.SDK.Message.Center.Client.ApiResponse<Result<bool>> localVarResponse = await ApiV1MessagePushUserClientDeleteByCidPostAsyncWithHttpInfo(deleteClientInput);
             return localVarResponse.Data;

        }

        /// <summary>
        /// 通过UserId 和 cid 删除数据 
        /// </summary>
        /// <exception cref="DHICN.PAAS.SDK.Message.Center.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deleteClientInput"> (optional)</param>
        /// <returns>Task of ApiResponse (bool)</returns>
        public async System.Threading.Tasks.Task<DHICN.PAAS.SDK.Message.Center.Client.ApiResponse<Result<bool>>> ApiV1MessagePushUserClientDeleteByCidPostAsyncWithHttpInfo (DeleteClientInput deleteClientInput = default(DeleteClientInput))
        {

            DHICN.PAAS.SDK.Message.Center.Client.RequestOptions localVarRequestOptions = new DHICN.PAAS.SDK.Message.Center.Client.RequestOptions();

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
            
            localVarRequestOptions.Data = deleteClientInput;


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<Result<bool>>("/api/v1/message/push/user-client/delete-by-cid", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiV1MessagePushUserClientDeleteByCidPost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// /api/v1/message/push/user-client/delete 
        /// </summary>
        /// <exception cref="DHICN.PAAS.SDK.Message.Center.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody"> (optional)</param>
        /// <returns>bool</returns>
        public Result<bool> ApiV1MessagePushUserClientDeletePost (List<Guid> requestBody = default(List<Guid>))
        {
             DHICN.PAAS.SDK.Message.Center.Client.ApiResponse<Result<bool>> localVarResponse = ApiV1MessagePushUserClientDeletePostWithHttpInfo(requestBody);
             return localVarResponse.Data;
        }

        /// <summary>
        /// /api/v1/message/push/user-client/delete 
        /// </summary>
        /// <exception cref="DHICN.PAAS.SDK.Message.Center.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody"> (optional)</param>
        /// <returns>ApiResponse of bool</returns>
        public DHICN.PAAS.SDK.Message.Center.Client.ApiResponse<Result< bool >> ApiV1MessagePushUserClientDeletePostWithHttpInfo (List<Guid> requestBody = default(List<Guid>))
        {
            DHICN.PAAS.SDK.Message.Center.Client.RequestOptions localVarRequestOptions = new DHICN.PAAS.SDK.Message.Center.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = DHICN.PAAS.SDK.Message.Center.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = DHICN.PAAS.SDK.Message.Center.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = requestBody;


            // make the HTTP request
            var localVarResponse = this.Client.Post<Result< bool >>("/api/v1/message/push/user-client/delete", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiV1MessagePushUserClientDeletePost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// /api/v1/message/push/user-client/delete 
        /// </summary>
        /// <exception cref="DHICN.PAAS.SDK.Message.Center.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody"> (optional)</param>
        /// <returns>Task of bool</returns>
        public async System.Threading.Tasks.Task<Result<bool>> ApiV1MessagePushUserClientDeletePostAsync (List<Guid> requestBody = default(List<Guid>))
        {
             DHICN.PAAS.SDK.Message.Center.Client.ApiResponse<Result<bool>> localVarResponse = await ApiV1MessagePushUserClientDeletePostAsyncWithHttpInfo(requestBody);
             return localVarResponse.Data;

        }

        /// <summary>
        /// /api/v1/message/push/user-client/delete 
        /// </summary>
        /// <exception cref="DHICN.PAAS.SDK.Message.Center.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody"> (optional)</param>
        /// <returns>Task of ApiResponse (bool)</returns>
        public async System.Threading.Tasks.Task<DHICN.PAAS.SDK.Message.Center.Client.ApiResponse<Result<bool>>> ApiV1MessagePushUserClientDeletePostAsyncWithHttpInfo (List<Guid> requestBody = default(List<Guid>))
        {

            DHICN.PAAS.SDK.Message.Center.Client.RequestOptions localVarRequestOptions = new DHICN.PAAS.SDK.Message.Center.Client.RequestOptions();

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
            
            localVarRequestOptions.Data = requestBody;


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<Result<bool>>("/api/v1/message/push/user-client/delete", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiV1MessagePushUserClientDeletePost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// 保存用户客户端信息 
        /// </summary>
        /// <exception cref="DHICN.PAAS.SDK.Message.Center.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveClientInput"> (optional)</param>
        /// <returns>bool</returns>
        public Result<bool> ApiV1MessagePushUserClientSaveClientPost (SaveClientInput saveClientInput = default(SaveClientInput))
        {
             DHICN.PAAS.SDK.Message.Center.Client.ApiResponse<Result<bool>> localVarResponse = ApiV1MessagePushUserClientSaveClientPostWithHttpInfo(saveClientInput);
             return localVarResponse.Data;
        }

        /// <summary>
        /// 保存用户客户端信息 
        /// </summary>
        /// <exception cref="DHICN.PAAS.SDK.Message.Center.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveClientInput"> (optional)</param>
        /// <returns>ApiResponse of bool</returns>
        public DHICN.PAAS.SDK.Message.Center.Client.ApiResponse<Result< bool >> ApiV1MessagePushUserClientSaveClientPostWithHttpInfo (SaveClientInput saveClientInput = default(SaveClientInput))
        {
            DHICN.PAAS.SDK.Message.Center.Client.RequestOptions localVarRequestOptions = new DHICN.PAAS.SDK.Message.Center.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = DHICN.PAAS.SDK.Message.Center.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = DHICN.PAAS.SDK.Message.Center.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = saveClientInput;


            // make the HTTP request
            var localVarResponse = this.Client.Post<Result< bool >>("/api/v1/message/push/user-client/save-client", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiV1MessagePushUserClientSaveClientPost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// 保存用户客户端信息 
        /// </summary>
        /// <exception cref="DHICN.PAAS.SDK.Message.Center.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveClientInput"> (optional)</param>
        /// <returns>Task of bool</returns>
        public async System.Threading.Tasks.Task<Result<bool>> ApiV1MessagePushUserClientSaveClientPostAsync (SaveClientInput saveClientInput = default(SaveClientInput))
        {
             DHICN.PAAS.SDK.Message.Center.Client.ApiResponse<Result<bool>> localVarResponse = await ApiV1MessagePushUserClientSaveClientPostAsyncWithHttpInfo(saveClientInput);
             return localVarResponse.Data;

        }

        /// <summary>
        /// 保存用户客户端信息 
        /// </summary>
        /// <exception cref="DHICN.PAAS.SDK.Message.Center.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveClientInput"> (optional)</param>
        /// <returns>Task of ApiResponse (bool)</returns>
        public async System.Threading.Tasks.Task<DHICN.PAAS.SDK.Message.Center.Client.ApiResponse<Result<bool>>> ApiV1MessagePushUserClientSaveClientPostAsyncWithHttpInfo (SaveClientInput saveClientInput = default(SaveClientInput))
        {

            DHICN.PAAS.SDK.Message.Center.Client.RequestOptions localVarRequestOptions = new DHICN.PAAS.SDK.Message.Center.Client.RequestOptions();

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
            
            localVarRequestOptions.Data = saveClientInput;


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<Result<bool>>("/api/v1/message/push/user-client/save-client", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiV1MessagePushUserClientSaveClientPost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}