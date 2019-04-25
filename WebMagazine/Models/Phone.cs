﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebMagazine.Models
{
    public class Phone
    {
        public int PhoneId { get; set; }

        public string Name { get; set; }

        public string Producer { get; set; }

        public string Price { get; set; }
    }
}