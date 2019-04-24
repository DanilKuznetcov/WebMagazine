using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMagazine.Models
{
    public class Purchase
    {
        public int PurchaseId { get; set; }

        public int PhoneId { get; set; }

        public string FIO { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public DateTime Date { get; set; }
    }
}