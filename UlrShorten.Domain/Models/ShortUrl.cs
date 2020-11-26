using System;
using Microsoft.AspNetCore.Http;

namespace UlrShorten.Domain.Models
{
    public class ShortUrl
    {
        public Uri OriginalUrl { get; set; }
        public Uri Value { get; set; }
        public string Token { get; set; }
        public DateTime DateCreated { get; set; }
    }
}