using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KupSprzedajKsiazke.Models;


namespace KupSprzedajKsiazke.Models
{
    public class FakeKsiazkaRepository : IKsiazkaRepository
    {
        public IQueryable<Ksiazka> Ksiazki => new List<Ksiazka>
        {
            new Ksiazka{Nazwa="Podstawy programowania w C#",Opis="Podstawy C# dla początkująch",Cena=25,Kategoria="Programowanie"},
            new Ksiazka{Nazwa="Podstawy programowania w C++",Opis="Podstawy C++ dla początkująch",Cena=15,Kategoria="Programowanie"},
            new Ksiazka{Nazwa="Podstawy programowania w java script",Opis="Podstawy Cjava script dla początkująch",Cena=40,Kategoria="Webmaster"}


        }.AsQueryable<Ksiazka>();

       
    }
}

