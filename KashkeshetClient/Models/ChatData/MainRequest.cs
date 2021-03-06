﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace KashkeshetClient.Models.ChatData
{
    [Serializable]
    public class MainRequest
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string RequestType { get; set; }



        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public string From { get; set; }
    }
}
