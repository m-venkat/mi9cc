using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace mi9cc.JsonModel
{
    public class PayLoadContainer
    {
        public List<payload> payload {get;set;}
        public int skip { get; set; }
        public int take { get; set; }
        public int totalRecords { get; set; }
        
    }

    public class payload
    {
        public string country { get; set; }
        public string description { get; set; }
        public bool? drm { get; set; }
        public int? episodeCount { get; set; }
        public string genre { get; set; }
        public image image { get; set; }
        public string language { get; set; }
        public nextEpisode nextEpisode { get; set; }
        public string primaryColour { get; set; }
        public season[] seasons { get; set; }
        public string slug { get; set; }
        public string title { get; set; }
        public string tvChannel { get; set; }

    }

    public class image
    {
        public string showImage { get; set; }
    }

    public class nextEpisode
    {
        public object channel { get; set; }
        public string channelLogo { get; set; }
        public object date { get; set; }
        public string html { get; set; }
        public string url { get; set; }
    }

    public class season
    {
        public string slug { get; set; }
    }

}