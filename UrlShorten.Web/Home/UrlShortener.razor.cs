using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http;
using UlrShorten.Domain.Interfaces;

namespace UrlShorten.Web.Home
{
    public partial class UrlShortener
    {
        [Inject]
        public IUrlShorteningService ShorteningService { get; set; }

        [Inject]
        public DummyDb DummyDb { get; set; }

        protected override Task OnInitializedAsync()
        {
            Url = new Url();
            return base.OnInitializedAsync();
        }

        private Url Url { get; set; }

        private void ShortenUrl()
        {
            var url = new Uri(Url.Value);
            var shortUtl = ShorteningService.QuickShort(url);
            DummyDb.ShortUrls.Add(shortUtl);
            Url.Value = shortUtl.Value.ToString();
        }
    }
}