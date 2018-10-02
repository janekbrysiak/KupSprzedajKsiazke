using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KupSprzedajKsiazke.Models;
using KupSprzedajKsiazke.Models.ViewModels;

namespace KupSprzedajKsiazke.Controllers
{
   public class KsiążkaController:Controller
    {
        private IKsiazkaRepository repository;
        public int PageSize = 4;

        public KsiążkaController(IKsiazkaRepository repo)
        {
            repository = repo;
        }


        public ViewResult List(int ksiazkaPage = 1)=> View(new KsiazkiListViewModel
        {
            Ksiazki = repository.Ksiazki.OrderBy(k => k.Id).Skip((ksiazkaPage - 1) * PageSize).Take(PageSize),
            PagingInfo = new PagingInfo
            {

                CurrentPage = ksiazkaPage,
                ItemsPerPage = PageSize,
                TotalItems = repository.Ksiazki.Count()
            }
        });

    }
}

