
#nullable enable

namespace HeyGen
{
    public partial class PersonalizedVideoClient
    {
        partial void PreparePersonalizedVideoProjectDetailArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? id);
        partial void PreparePersonalizedVideoProjectDetailRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? id);
        partial void ProcessPersonalizedVideoProjectDetailResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// personalized_video/project/detail<br/>
        /// personalized_video/project/detail
        /// </summary>
        /// <param name="id">
        /// Example: &lt;project-id&gt;
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task PersonalizedVideoProjectDetailAsync(
            string? id = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PreparePersonalizedVideoProjectDetailArguments(
                httpClient: _httpClient,
                id: ref id);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/v1/personalized_video/project/detail?id={id}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PreparePersonalizedVideoProjectDetailRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                id: id);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessPersonalizedVideoProjectDetailResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);
            response.EnsureSuccessStatusCode();
        }
    }
}