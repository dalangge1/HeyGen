
#nullable enable

namespace HeyGen
{
    public partial class WebhooksClient
    {
        partial void PrepareV1WebhookEndpointDeleteArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? endpointId);
        partial void PrepareV1WebhookEndpointDeleteRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? endpointId);
        partial void ProcessV1WebhookEndpointDeleteResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// v1/webhook/endpoint.delete<br/>
        /// v1/webhook/endpoint.delete
        /// </summary>
        /// <param name="endpointId">
        /// Example: &lt;endpoint_id&gt;
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task V1WebhookEndpointDeleteAsync(
            string? endpointId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareV1WebhookEndpointDeleteArguments(
                httpClient: _httpClient,
                endpointId: ref endpointId);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Delete,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/v1/webhook/endpoint.delete?endpoint_id={endpointId}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareV1WebhookEndpointDeleteRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                endpointId: endpointId);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessV1WebhookEndpointDeleteResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);
            response.EnsureSuccessStatusCode();
        }
    }
}