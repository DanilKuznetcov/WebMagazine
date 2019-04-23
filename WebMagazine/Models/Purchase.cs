using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMagazine.Models
{
    public class Purchase
    {
        public int Id { get; set; }
        
        public string Date { get; set; }

        public string Email { get; set; }

        public string FIO { get; set; }

        public string Address { get; set; }
    }
}