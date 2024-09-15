
#nullable enable

namespace HeyGen
{
    /// <summary>
    /// Import contacts into your HeyGen **Personalized Video** campaign. <br/>
    /// **Guide**: [https://docs.heygen.com/docs/import-contacts-via-api](https://docs.heygen.com/docs/import-contacts-via-api)  <br/>
    /// Reference: [https://docs.heygen.com/reference/add-contact](https://docs.heygen.com/reference/add-contact)<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IPersonalizedVideoClient : global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


    }
}