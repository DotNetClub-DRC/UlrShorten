using System;
using UlrShorten.Domain.Models;

namespace UlrShorten.Domain.Interfaces
{
    public interface IUrlShorteningService
    {
        ShortUrl QuickShort(Uri url);
    }
}