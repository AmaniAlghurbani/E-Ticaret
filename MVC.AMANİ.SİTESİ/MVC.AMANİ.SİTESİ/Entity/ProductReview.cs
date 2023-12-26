using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.AMANİ.SİTESİ.Entity
{
    public class ProductReview
    {
        public int ProductReviewId { get; set; }
        public string UserName { get; set; }
        public string Comment { get; set; }
        public int Rating { get; set; }

        // Foreign key for the relationship
        public int ProductId { get; set; }

        // Navigation property for the relationship
        public Product Product { get; set; }
    }
}