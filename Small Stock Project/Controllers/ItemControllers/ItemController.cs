using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Small_Stock_Project.Repos.ItemRepo;

namespace Small_Stock_Project.Controllers.ItemControllers
{
    public class ItemController : Controller
    {
        private readonly IItemRepo itemRepo;

        public ItemController(IItemRepo itemRepo)
        {
            this.itemRepo = itemRepo;
        }

        public IActionResult Index()
        {
            List<Item> items = itemRepo.GetAll();
            return View(items);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Item item)
        {
            if (ModelState.IsValid)
            {
                itemRepo.Add(item);
                itemRepo.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Update(int? id)
        {
            if (id == null) return BadRequest();
            Item? item = itemRepo.GetById(id.Value);
             
            if (item == null) return NotFound();
            return View(item);
        }

        [HttpPost]
        public IActionResult Update(Item item)
        {

            if (ModelState.IsValid)
            {
               itemRepo.Update(item);
               itemRepo.SaveChanges();
               return RedirectToAction("Index"); 
            }
            return View(item);  
        }

        public IActionResult Delete(int? id)
        {
            if (id == null) return BadRequest();
            Item? item = itemRepo.GetById(id.Value);

            if(item == null) return NotFound(); 
            return View(item);
        }

        [HttpPost , ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            itemRepo.Delete(id);
            itemRepo.SaveChanges();
            return RedirectToAction("Index");   
        }
    }
}
