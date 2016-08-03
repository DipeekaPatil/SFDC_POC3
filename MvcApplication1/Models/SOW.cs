using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class SOW
    {
        public string Customer { get; set; }
        public string Status { get; set; }
        public string Project { get; set; }
        public string ProjectType { get; set; }
        public string Date { get; set; }
        public string ProjectStartDate{ get; set; }
        public string ProjectEndDate { get; set; }
        public string DeliveryModel { get; set; }
        public string PO { get; set; }
        public string Memo{ get; set; }
        public string SalesRep{ get; set; }
        public string EndCustomer { get; set; }
        public string Subsidiary { get; set; }
        public string Location { get; set; }
        public string Vertical { get; set; }
        public string BillingLocation { get; set; }
        public string WorkLocation { get; set; }
        public string ClientPartner { get; set; }
        public string LayoutType { get; set; }
    }
}