using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KupSprzedajKsiazke.Models.ViewModels
{
    public class KsiazkiListViewModel
    {
        public IEnumerable<Ksiazka> Ksiazki { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
