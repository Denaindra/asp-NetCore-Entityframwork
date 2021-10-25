using System;

namespace earn_ASP.NET_Core_5._0_MVC_by_tutorialsEU.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
