using ProduktyWebSerwis.Repo.IRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProduktyWebSerwis.Models;

namespace ProduktyWebSerwis.Repo
{
    public class AllergenRepo : IAllergenRepo
    {
        public AllergenRepo(IProdContext db)
        {
            _db = db;
        }
        private readonly IProdContext _db;

        public List<Allergen> PobierzAllergeny()
        {
            var allergeny = _db.Allergeny.AsNoTracking();
            var ListaAllergen = new List<Allergen>();
            foreach(var allergen in allergeny)
            {
                ListaAllergen.Add(allergen);
            }
            return ListaAllergen;
        }
    }
}
