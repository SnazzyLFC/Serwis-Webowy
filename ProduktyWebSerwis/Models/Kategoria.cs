using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProduktyWebSerwis.Models
{
    public class Kategoria
    {
        public Kategoria ()
        {
            this.Produkty = new HashSet<Produkt>();
        }

        [Display(Name="Id kategorii:")]
        public int Id { get; set; }

        [Display(Name ="Nazwa kategorii:")]
        public string Nazwa { get; set; }

        public virtual ICollection<Produkt> Produkty { get; private set; }
    }
}
