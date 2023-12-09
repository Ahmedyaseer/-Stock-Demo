using Microsoft.EntityFrameworkCore;
using Small_Stock_Project.Repos.ItemRepo;

namespace Small_Stock_Project;

public class ItemRepo : GenricRepo<Item>, IItemRepo
{
    private readonly StockContext context;

    public ItemRepo(StockContext context):base(context) 
    {
        this.context = context;
    }



    public List<Item> ListByFilter(Func<Item, bool> lamda)
    {
        List<Item> items = context.items.Where(lamda).ToList();
        return items;
    }
}
