using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace KashkeshetClient.Models.ChatData
{
    [Serializable]
    public class NewChatMessage : MainRequest
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }


        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string ChatId { get; set; }

    }
}
