using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProduktyWebSerwis.Models
{
    public class Produkt
    {
        [Display(Name="Id produktu")]
        public int Id { get; set; }

        public virtual ICollection<Allergen> Allergeny { get; set; }

        [Display(Name ="Nazwa produktu")]
        public string Nazwa { get; set; }

        public virtual Kategoria Kategoria { get; set; }

    }
}
