using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Example.Models;


namespace Example.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
            //List<PhoneViewModel> list = new List<PhoneViewModel>();
            //list.Add(new PhoneViewModel { Id =1, PhoneBrand = "Apple", PhoneModel = "11 pro", Description = "", Price = 0 });
            //list.Add(new PhoneViewModel { Id = 2, PhoneBrand = "Samsung", PhoneModel = "A52", Description = "", Price = 0 });
            //list.Add(new PhoneViewModel { Id = 3, PhoneBrand = "Xiaomi", PhoneModel = "Redmi note 10 pro", Description = "", Price = 0 });
            //list.Add(new PhoneViewModel { Id = 4, PhoneBrand = "LG", PhoneModel = "Wing", Description = "", Price = 0 });
            //list.Add(new PhoneViewModel { Id = 5, PhoneBrand = "Honor", PhoneModel = "X9a", Description = "", Price = 0 });
            //PhoneViews = list;
        }
       // public List<PhoneViewModel> PhoneViews { get; set; }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Catalog()
        {
            var list = new List<PhoneViewModel>();
            list.Add(new PhoneViewModel { Id = 1, PhoneBrand = "Apple", PhoneModel = "11 pro", Description = "", Price = 0 });
            list.Add(new PhoneViewModel { Id = 2, PhoneBrand = "Samsung", PhoneModel = "A52", Description = "", Price = 0 });
            list.Add(new PhoneViewModel { Id = 3, PhoneBrand = "Xiaomi", PhoneModel = "Redmi note 10 pro", Description = "", Price = 0 });
            list.Add(new PhoneViewModel { Id = 4, PhoneBrand = "LG", PhoneModel = "Wing", Description = "", Price = 0 });
            list.Add(new PhoneViewModel { Id = 5, PhoneBrand = "Honor", PhoneModel = "X9a", Description = "", Price = 0 });
           
            return View(list);   
        }

        public IActionResult SinglePage() 
        {
            return View();
        }
  
    }
}