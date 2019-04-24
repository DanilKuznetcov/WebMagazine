using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebMagazine.Models
{
    public class DBInitializer : DropCreateDatabaseIfModelChanges<PhoneContext>
    {
        protected override void Seed(PhoneContext context)
        {
            context.Phones.Add(new Phone() { Name = "Power Ice", Price = "7990", Producer = "HightScreen" });

            context.Phones.Add(new Phone() { Name = "Redmi 4X", Price = "11110", Producer = "Xiaomi" });

            context.Phones.Add(new Phone() { Name = "StupidPhone", Price = "3480", Producer = "Redmi" });

            base.Seed(context);
        }
    }
}