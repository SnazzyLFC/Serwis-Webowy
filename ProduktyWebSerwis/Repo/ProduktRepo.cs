using ProduktyWebSerwis.Models;
using ProduktyWebSerwis.Repo.IRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProduktyWebSerwis.Repo
{
    public class ProduktRepo : IProduktRepo
    {
        private ProdContext db = new ProdContext();

        public IQueryable<Produkt> PobierzProdukty()
        {
            return db.Produkty.AsNoTracking();
        }
    }
}
