using Microsoft.AspNetCore.Mvc;
using Small_Stock_Project.Repos.StoreRepo;

namespace Small_Stock_Project.Controllers.StoreControllers
{
    public class StoreController : Controller
    {
        private readonly IStoreRepo storeRepo;

        public StoreController(IStoreRepo storeRepo)
        {
            this.storeRepo = storeRepo;
        }
        public IActionResult Index()
        {
            List<Store> stores = storeRepo.GetAll();
            return View(stores);
        } 

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Store store)
        {
            if (ModelState.IsValid)
            {
                storeRepo.Add(store);
                storeRepo.SaveChanges();
               return RedirectToAction("Index");
            }
            return View(store);
        }
        public IActionResult Update(int? id)
        {
            if (id == null) return BadRequest();
           Store? store =  storeRepo.GetById(id.Value);

            if(store == null) return NotFound();
            return View(store);
        }

        [HttpPost]
        public IActionResult Update(Store store)
        {
            if (ModelState.IsValid)
            {
                storeRepo.Update(store);
                storeRepo.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(store);
        }

        public IActionResult Delete(int? id)
        {
            if(id == null) return BadRequest(); 
            Store? store = storeRepo.GetById(id.Value);

            if(id == null) return NotFound();
            return View(store);
        }

        [HttpPost , ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            storeRepo.Delete(id);
            storeRepo.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
