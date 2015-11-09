using ProduktyWebSerwis.Models;
using ProduktyWebSerwis.Repo.IRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

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

        public void Dodaj(Produkt produkt)
        {
            _db.Produkty.Add(produkt);
        }

        public void Zapisz()
        {
            _db.SaveChanges();
        }

        public Produkt GetProduktById(int id)
        {
            Produkt produkt = _db.Produkty.Find(id);
            return produkt;
        }
    }
}
