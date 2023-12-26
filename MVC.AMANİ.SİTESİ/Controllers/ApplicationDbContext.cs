using System;

namespace MVC.AMANİ.SİTESİ.Controllers
{
    internal class ApplicationDbContext
    {
        public ApplicationDbContext()
        {
        }

        public object Kampanyalar { get; internal set; }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}