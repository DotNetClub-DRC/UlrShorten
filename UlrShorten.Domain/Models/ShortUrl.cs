using System;
using Microsoft.AspNetCore.Http;

namespace UlrShorten.Domain.Models
{
    public class ShortUrl
    {
        public PathString OriginalUrl { get; set; }
        public PathString Value { get; set; }
        public string Token { get; set; }
        public DateTime DateCreated { get; set; }
    }
}