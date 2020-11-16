using UlrShorten.Domain.Models;

namespace UlrShorten.Domain.Interfaces
{
    public interface IUserAgentService
    {
        UserAgent ParserUserAgent(string userAgent);
    }
}