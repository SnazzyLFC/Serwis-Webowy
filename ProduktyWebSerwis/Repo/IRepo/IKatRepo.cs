using ProduktyWebSerwis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ProduktyWebSerwis.Repo.IRepo
{
    public interface IKatRepo
    {
        IEnumerable<SelectListItem> PobierzListeKategorii();
        IQueryable<Kategoria> PobierzKategorie();
        void Dodaj(Kategoria kategoria);
        void Zapisz();
    }
}
