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

    public List<IncludeDtoStoreBalanceItem> IncludeAllModels()
    {
        var all = from store in context.stores
                  join storeItem in context.storeItems
                  on store.id equals storeItem.StoreId
                  join item in context.items on storeItem.ItemId equals item.Id
                  select new IncludeDtoStoreBalanceItem
                  {
                      storeName = store.name,
                      itemName = item.Name,
                      itemBalance = storeItem.Balance.ToString()
                  };
        var result = all.ToList();
        return result;
    }

    public List<IncludeDtoStoreBalanceItem> GetAllByName (string name)
    {
        var query = from item in context.items
                    join storeItem in context.storeItems on item.Id equals storeItem.ItemId
                    join store in context.stores on storeItem.StoreId equals store.id
                    where item.Name.StartsWith(name)
                    select new IncludeDtoStoreBalanceItem
                    {
                        storeName = store.name,
                        itemName = item.Name,
                        itemBalance = storeItem.Balance.ToString()
                    };

        var result = query.ToList();
        return result;

    }

}
