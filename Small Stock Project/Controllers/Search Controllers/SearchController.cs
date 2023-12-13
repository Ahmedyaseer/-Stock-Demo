using Microsoft.AspNetCore.Mvc;
using Small_Stock_Project.Repos.ItemRepo;
using Small_Stock_Project.Repos.StoreRepo;

namespace Small_Stock_Project.Controllers.Search_Controllers
{
    public class SearchController : Controller
    {
   
        private readonly IStoreItemRepo storeItemRepo;
        

        public SearchController( IStoreItemRepo storeItemRepo )
        {
            
            this.storeItemRepo = storeItemRepo;
            
        }
        public IActionResult Index()
        {
            
            List<IncludeDtoStoreBalanceItem> result = storeItemRepo.IncludeAllModels();

            return View(result);
        }

        [HttpPost]
        public IActionResult Index(string search)
        {
            var item = storeItemRepo.GetAllByName(search);
            return View(item);  
        }
    }
}
