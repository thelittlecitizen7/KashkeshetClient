﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace KashkeshetClient.Models.ChatData
{
    [Serializable]
    public class AllUsersMessage : MainRequest
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Names { get; set; }
    }
}
