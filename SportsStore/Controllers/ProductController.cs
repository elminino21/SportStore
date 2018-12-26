
using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;

namespace SportsStore.Controllers{

    public class ProductController: Controller {

        private IProductRepository repository;
        public int PageSize = 4;

        public ProductController(IProductRepository repository) {
             this.repository = repository;
            Console.Write("product controller init");
        }
        

        public ViewResult List(int productPage = 1){
            return View(repository.Products
            .OrderBy(p=> p.ProductID)
            .Skip((productPage -1)* PageSize)
            .Take(PageSize)
            
            );
        }
    }
}