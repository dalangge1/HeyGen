#nullable enable

namespace HeyGen
{
    public partial interface IWebhooksClient
    {
        /// <summary>
        /// v1/webhook/endpoint.add<br/>
        /// v1/webhook/endpoint.add
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task V1WebhookEndpointAddAsync(
            global::HeyGen.V1WebhookEndpointAddRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// v1/webhook/endpoint.add<br/>
        /// v1/webhook/endpoint.add
        /// </summary>
        /// <param name="events"></param>
        /// <param name="url">
        /// Example: &lt;url&gt;
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task V1WebhookEndpointAddAsync(
            global::System.Collections.Generic.IList<object>? events = default,
            string? url = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}