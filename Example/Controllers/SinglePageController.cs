using Example.Models;
using Microsoft.AspNetCore.Mvc;

namespace Example.Controllers
{
    public class SinglePageController : Controller
    {
        [HttpGet]
        public IActionResult GetSinglePage(int Id)
        {
            PhoneViewModel[] array =
            {
                 new PhoneViewModel { Id = 1, PhoneBrand = "Apple", PhoneModel = "11 pro", Description = "Огрызок яблока", Price = 9999 },
                 new PhoneViewModel { Id = 2, PhoneBrand = "Samsung", PhoneModel = "A52", Description = "Корейцы делают вещи", Price = 3453 },
                 new PhoneViewModel { Id = 3, PhoneBrand = "Xiaomi", PhoneModel = "Redmi note 10 pro", Description = "Топ за свои деньги", Price = 1875 },
                 new PhoneViewModel { Id = 4, PhoneBrand = "LG", PhoneModel = "Wing", Description = "Они вообще ещё телефоны выпускают ?", Price = 3456 },
                 new PhoneViewModel { Id = 5, PhoneBrand = "Honor", PhoneModel = "X9a", Description = "Не придумал описание", Price = 6764 }
            };

            var resultById = array.FirstOrDefault(x => x.Id == Id);
            return View(resultById);
        }
    }
}
