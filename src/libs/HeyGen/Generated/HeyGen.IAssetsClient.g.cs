
#nullable enable

namespace HeyGen
{
    /// <summary>
    /// Upload an image or video asset to your account.<br/>
    /// **Reference**: [https://docs.heygen.com/reference/upload-asset-1](https://docs.heygen.com/reference/upload-asset-1)<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IAssetsClient : global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


    }
}