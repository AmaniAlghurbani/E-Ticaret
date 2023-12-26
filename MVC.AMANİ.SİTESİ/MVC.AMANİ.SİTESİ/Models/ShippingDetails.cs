using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.AMANİ.SİTESİ.Models
{
    public class ShippingDetails
    {

        public string UserName { get; set; }

        [Required (ErrorMessage="Lütfen adres taınımını giriniz.")]
        public String AdresBasligi { get; set; }
       

        [Required(ErrorMessage = "Lütfen bir adres  giriniz.")]
        public String Adres { get; set; }

        [Required(ErrorMessage = "Lütfen şehir giriniz.")]
        public String Sehir { get; set; }

        [Required(ErrorMessage = "Lütfen semt giriniz.")]
        public String Semt { get; set; }

        [Required(ErrorMessage = "Lütfen mahalle giriniz.")]
        public String Mahalle { get; set; }
        public String PostaKodu { get; set; }
    }
}