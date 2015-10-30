using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProduktyWebSerwis.Models
{
    public class Allergen
    {
        public Allergen()
        {
            this.Produkty = new HashSet<Produkt>();
        }

        [Display(Name="Id allergenu:")]
        public int Id { get; set; }

        [Display(Name ="Nazwa allergenu:")]
        public string Nazwa { get; set; }

        public string KategoriaId { get; set; }
        public Kategoria Kategoria { get; set; }
        public virtual ICollection<Produkt> Produkty { get; private set; }
    }
}
