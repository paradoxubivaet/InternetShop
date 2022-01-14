using System;

namespace InternetShop.Web.Contractors
{
    public interface IWebContractorService
    {
        string UniqueCode { get; }
        string GetUri { get; }
    }
}
