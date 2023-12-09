using Microsoft.EntityFrameworkCore;

namespace Small_Stock_Project;

public class StoreItemRepo : GenricRepo<StoreItem> , IStoreItemRepo
{
    private readonly StockContext context;

    public StoreItemRepo(StockContext context) : base(context)  
    {
        this.context = context;
    }



    public int GetBalance(int StoreId, int ItemId)
    {

        //select storeitem.balance
        // from storeitem
        // where itemid = 1 and storeid =1

        var balance = context.storeItems
            .Where(item => item.ItemId == ItemId && item.StoreId == StoreId)
            .Select(item => item.Balance)
            .FirstOrDefault();

        return balance;
    }

    public void DecreaseBalance(int storeid, int itemid, int quantity)
    {

        // select top 1 * from storeitem where storeid = storeid and itemid = itemid  
        var storeItemToUpdate = context.storeItems
              .Where(item => item.StoreId == storeid && item.ItemId == itemid)
              .FirstOrDefault();

      

        if (storeItemToUpdate != null)
        {
            storeItemToUpdate.Balance -= quantity;
            context.SaveChanges();
        }
    }
}
