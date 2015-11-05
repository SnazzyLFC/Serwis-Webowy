using ProduktyWebSerwis.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProduktyWebSerwis.Repo.IRepo
{
    public interface IProdContext
    {
        DbSet<Produkt> Produkty { get; set; }
        DbSet<Allergen> Allergeny { get; set; }
        DbSet<Kategoria> Kategorie { get; set; }

        int SaveChanges();
        Database Database { get; }
    }
}
