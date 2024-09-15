
#nullable enable

namespace HeyGen
{
    /// <summary>
    /// The [Video Translate](https://labs.heygen.com/video-translate) by HeyGen provides a powerful solution for effortlessly translating videos, integrating natural voice cloning and authentic speaking styles seamlessly. Now, you can harness its capabilities programmatically through the **Video Translate API**!<br/>
    /// **Guide**: [https://docs.heygen.com/docs/video-translate-api](https://docs.heygen.com/docs/video-translate-api)**Reference**: [https://docs.heygen.com/reference/video-translate](https://docs.heygen.com/reference/video-translate)<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IVideoTranslateAPIClient : global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


    }
}