
#nullable enable

namespace HeyGen
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StreamingStopRequest
    {
        /// <summary>
        /// Example: &lt;session_id&gt;
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public string? SessionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}