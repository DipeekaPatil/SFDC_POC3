using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class Customer
    {
        public string CompanyName { get; set; }
        public string CustentityMsaStatus { get; set; }
        public string CustentityClientPartner { get; set; }
        public string Url { get; set; }
        public string Subsidiary { get; set; }
        public string Territory { get; set; }
        public string EndDate { get; set; }
        public string Currency { get; set; }
    }
}