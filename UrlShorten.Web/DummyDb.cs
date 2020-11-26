using System.Collections.Generic;
using UlrShorten.Domain.Models;

namespace UrlShorten.Web
{
    public class DummyDb
    {
        public DummyDb()
        {
            ShortUrls = new List<ShortUrl>();
        }

        public List<ShortUrl> ShortUrls { get; set; }
    }
}