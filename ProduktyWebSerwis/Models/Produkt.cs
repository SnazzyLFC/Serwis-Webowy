﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProduktyWebSerwis.Models
{
    public class Produkt
    {
        public Produkt()
        {
            this.Allergeny = new HashSet<Allergen>();
        }
        [Display(Name = "Id produktu:")]
        public int Id { get; set; }

        public virtual ICollection<Allergen> Allergeny { get; private set; }

        [Display(Name = "Nazwa produktu:")]
        public string Nazwa { get; set; }

        [Display(Name = "Kategoria:")]
        public String Kategoria { get; set; }
    }
}
