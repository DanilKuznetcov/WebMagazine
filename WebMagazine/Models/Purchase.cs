using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebMagazine.Models
{
    public class Purchase
    {
        public int PurchaseId { get; set; }

        public int PhoneId { get; set; }

        [Required(ErrorMessage = "Необходимо заполнить поле")]
        [StringLength(50, MinimumLength = 4, ErrorMessage = "Длина имени от 4 до 50 символов")]
        public string FIO { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Необходимо заполнить поле")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Необходимо заполнить поле")]
        public string Address { get; set; }

        public DateTime Date { get; set; }
    }
}