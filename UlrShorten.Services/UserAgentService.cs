using UAParser;
using UlrShorten.Domain.Interfaces;
using UlrShorten.Domain.Models;
using UserAgent = UlrShorten.Domain.Models.UserAgent;
using OS = UlrShorten.Domain.Models.OS;
using Device = UlrShorten.Domain.Models.Device;

namespace UlrShorten.Services
{
    public class UserAgentService : IUserAgentService
    {
        public UserAgent ParserUserAgent(string userAgent)
        {
            var uaParser = Parser.GetDefault();
            ClientInfo c = uaParser.Parse(userAgent);

            var os = new OS
            {
                Family = c.OS.Family,
                Major = c.OS.Major,
                Minor = c.OS.Minor
            };
            var device = new Device
            {
                IsBot = c.Device.IsSpider,
                Brand = c.Device.Brand,
                Family = c.Device.Family,
                Model = c.Device.Model
            };
            var browser = new Browser()
            {
                Family = c.UA.Family,
                Major = c.UA.Major,
                Minor = c.UA.Minor
            };

            return new UserAgent(os, device, browser);
        }
    }
}