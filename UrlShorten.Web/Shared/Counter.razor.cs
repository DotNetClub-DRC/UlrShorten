using Microsoft.AspNetCore.Components;

namespace UrlShorten.Web.Shared
{
    public partial class Counter
    {
        [Parameter]
        public int Count { get; set; }

        [Parameter]
        public string Text { get; set; }
    }
}