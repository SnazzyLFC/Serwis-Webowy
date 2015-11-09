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
    public class KatRepo : IKatRepo
    {
        private readonly IProdContext _db;
        public KatRepo(IProdContext db)
        {
            _db = db;
        }

        public void Dodaj(Kategoria kategoria)
        {
            _db.Kategorie.Add(kategoria);
        }

        public IQueryable<Kategoria> PobierzKategorie()
        {
            var kategorie = _db.Kategorie.AsNoTracking();
            return kategorie;
        }

        public IEnumerable<SelectListItem> PobierzListeKategorii()
        {
            var kategorie = _db.Kategorie.AsNoTracking();
            List<SelectListItem> lista = new List<SelectListItem>();
            int i = 0;
            foreach (var k in kategorie)
            {
                lista.Add(new SelectListItem { Text = k.Nazwa, Value = i.ToString() });
                i++;
            }
            return lista;
        }

        public void Zapisz()
        {
            _db.SaveChanges();
        }
    }
}
