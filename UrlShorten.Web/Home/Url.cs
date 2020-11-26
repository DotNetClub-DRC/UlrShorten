using System.ComponentModel.DataAnnotations;

namespace UrlShorten.Web.Home
{
    public class Url
    {
        [Required]
        public string Value { get; set; }
    }
}