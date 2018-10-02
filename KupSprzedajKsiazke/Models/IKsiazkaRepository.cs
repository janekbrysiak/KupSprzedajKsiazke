using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KupSprzedajKsiazke.Models
{
    public interface IKsiazkaRepository
    {
        IQueryable<Ksiazka>Ksiazki{ get;  }
    }
}
