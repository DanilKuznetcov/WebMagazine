﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebMagazine.Models
{
    public class PhoneContext : DbContext
    {
        public PhoneContext() : base("PhoneContext")
        {

        }

        public DbSet<Phone> Phones { get; set; }

        public DbSet<Purchase> Purchases { get; set; }
    }
}