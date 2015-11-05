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
        private readonly IProdContext _db;
        public ProduktRepo(IProdContext db)
        {
            _db = db;
        }

        public IQueryable<Produkt> PobierzProdukty()
        {
            var produkty = _db.Produkty.AsNoTracking();
            return produkty;
        }
    }
}
