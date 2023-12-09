using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Small_Stock_Project.Repos.ItemRepo;
using Small_Stock_Project.Repos.StoreRepo;

namespace Small_Stock_Project.Controllers.StoreItemControllers
{
    public class StoreItemController : Controller
    {
        private readonly IStoreItemRepo storeItemRepo;
        private readonly IStoreRepo storeRepo;
        private readonly IItemRepo itemRepo;
        private readonly StockContext context;

        public StoreItemController
            (
            IStoreItemRepo storeItemRepo ,
            IStoreRepo storeRepo ,
            IItemRepo  ItemRepo ,
            StockContext context
            )
        {
            this.storeItemRepo = storeItemRepo;
            this.storeRepo = storeRepo;
            itemRepo = ItemRepo;
            this.context = context;
        }
   
        public IActionResult Index()
        {
            ViewBag.currentDate = DateTime.Now.ToString("yyyy-MM-dd");

            StoreItemVM vm = new StoreItemVM
            {
                Stores = storeRepo.GetAll(),
            };

            return View(vm);
        }



        public JsonResult GetItems(int storeId)
        {
           // select id , name from items inner join storeitems on items.id = storeitem.itemid
           // where storeid = storeid

                var items =  context.items
                            .Where(i => i.storeItems.Any(si => si.StoreId == storeId))
                            .Select(i => new { Id = i.Id, Name = i.Name })
                            .ToList();

                return Json(items);
            
        }

        public JsonResult GetBalance (int storeId , int itemId)
        {
            var balance = storeItemRepo.GetBalance(storeId, itemId);
            return Json(balance);
        }


        [HttpPost]
        public IActionResult Index( int storeid , int itemid  , int? quantity)
        {


            if (quantity == null) {
                return new ContentResult()
                {
                    Content = "Please Add Quantity to compelte purchase order",
                    StatusCode = 404
                };
                
            };

            //if (balance < quantity.Value) return new ContentResult()
            //{
            //    Content = "Canot withdraw quantity more than the balance ",
            //    StatusCode = 404
            //};

            
            storeItemRepo.DecreaseBalance(storeid, itemid, (int)quantity);   

            return RedirectToAction("Index");
        }




    }
}
