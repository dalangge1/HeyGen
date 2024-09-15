
#nullable enable

namespace HeyGen
{
    /// <summary>
    /// These API endpoints allow you to manage photo avatars in your account.<br/>
    /// **Reference**: [https://docs.heygen.com/reference/upload-talking-photo](https://docs.heygen.com/reference/upload-talking-photo)<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface ITalkingPhotoClient : global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


    }
}