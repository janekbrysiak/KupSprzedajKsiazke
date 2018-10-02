using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KupSprzedajKsiazke.Models
{
    public class EFKsiazkaRepository : IKsiazkaRepository
    {
        private ApplicationDbContext context;

        public EFKsiazkaRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Ksiazka> Ksiazki => context.Ksiazki;

       
    }

}
