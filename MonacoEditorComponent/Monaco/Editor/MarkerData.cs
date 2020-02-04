﻿using Newtonsoft.Json;

namespace Monaco.Editor
{
    /// <summary>
    /// https://microsoft.github.io/monaco-editor/api/interfaces/monaco.editor.imarkerdata.html
    /// </summary>
    public sealed class MarkerData : IMarkerData
    {
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }

        [JsonProperty("endColumn")]
        public uint EndColumn { get; set; }

        [JsonProperty("endLineNumber")]
        public uint EndLineNumber { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("relatedInformation", NullValueHandling = NullValueHandling.Ignore)]
        public IRelatedInformation[] RelatedInformation { get; set; }

        [JsonProperty("severity")]
        public MarkerSeverity Severity { get; set; }

        [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore)]
        public string Source { get; set; }

        [JsonProperty("startColumn")]
        public uint StartColumn { get; set; }

        [JsonProperty("startLineNumber")]
        public uint StartLineNumber { get; set; }

        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public MarkerTag[] Tags { get; set; }
    }
}
