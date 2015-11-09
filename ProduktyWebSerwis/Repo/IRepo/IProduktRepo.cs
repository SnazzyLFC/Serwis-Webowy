using ProduktyWebSerwis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ProduktyWebSerwis.Repo.IRepo
{
    public interface IProduktRepo
    {
        IQueryable<Produkt> PobierzProdukty();
        Produkt GetProduktById(int id);
        void Dodaj(Produkt produkt);
        void Zapisz();
    }
}
