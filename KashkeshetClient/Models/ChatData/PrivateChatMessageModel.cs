using KashkeshetClient.Enums;
using KashkeshtWorkerServiceServer.Src;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace KashkeshetClient.Models.ChatData
{
    [Serializable]
    public class PrivateChatMessageModel : MainRequest
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<string> lsUsers { get; set; }
    }
}
