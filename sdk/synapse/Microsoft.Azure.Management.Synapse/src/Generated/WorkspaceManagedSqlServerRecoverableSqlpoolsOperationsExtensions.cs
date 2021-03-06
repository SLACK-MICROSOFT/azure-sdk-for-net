// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Synapse
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for WorkspaceManagedSqlServerRecoverableSqlpoolsOperations.
    /// </summary>
    public static partial class WorkspaceManagedSqlServerRecoverableSqlpoolsOperationsExtensions
    {
            /// <summary>
            /// Get list of recoverable sql pools for the server.
            /// </summary>
            /// <remarks>
            /// Get list of recoverable sql pools for workspace managed sql server.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace
            /// </param>
            public static IPage<RecoverableSqlPool> List(this IWorkspaceManagedSqlServerRecoverableSqlpoolsOperations operations, string resourceGroupName, string workspaceName)
            {
                return operations.ListAsync(resourceGroupName, workspaceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get list of recoverable sql pools for the server.
            /// </summary>
            /// <remarks>
            /// Get list of recoverable sql pools for workspace managed sql server.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<RecoverableSqlPool>> ListAsync(this IWorkspaceManagedSqlServerRecoverableSqlpoolsOperations operations, string resourceGroupName, string workspaceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, workspaceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get recoverable sql pools for the server.
            /// </summary>
            /// <remarks>
            /// Get recoverable sql pools for workspace managed sql server.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace
            /// </param>
            /// <param name='sqlComputeName'>
            /// The name of the sql compute
            /// </param>
            public static RecoverableSqlPool Get(this IWorkspaceManagedSqlServerRecoverableSqlpoolsOperations operations, string resourceGroupName, string workspaceName, string sqlComputeName)
            {
                return operations.GetAsync(resourceGroupName, workspaceName, sqlComputeName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get recoverable sql pools for the server.
            /// </summary>
            /// <remarks>
            /// Get recoverable sql pools for workspace managed sql server.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace
            /// </param>
            /// <param name='sqlComputeName'>
            /// The name of the sql compute
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RecoverableSqlPool> GetAsync(this IWorkspaceManagedSqlServerRecoverableSqlpoolsOperations operations, string resourceGroupName, string workspaceName, string sqlComputeName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, workspaceName, sqlComputeName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get list of recoverable sql pools for the server.
            /// </summary>
            /// <remarks>
            /// Get list of recoverable sql pools for workspace managed sql server.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<RecoverableSqlPool> ListNext(this IWorkspaceManagedSqlServerRecoverableSqlpoolsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get list of recoverable sql pools for the server.
            /// </summary>
            /// <remarks>
            /// Get list of recoverable sql pools for workspace managed sql server.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<RecoverableSqlPool>> ListNextAsync(this IWorkspaceManagedSqlServerRecoverableSqlpoolsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
