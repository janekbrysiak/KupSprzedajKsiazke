using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KupSprzedajKsiazke.Models
{
    public class Ksiazka
    {
        public int Id { get; set; }
        public string Nazwa { get; set; }
        public string Opis { get; set; }
        public int Cena { get; set; }
        public string Kategoria { get; set; }
    }
}
