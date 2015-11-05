using ProduktyWebSerwis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProduktyWebSerwis.Repo.IRepo
{
    public interface IProduktRepo
    {
        IQueryable<Produkt> PobierzProdukty();
    }
}
