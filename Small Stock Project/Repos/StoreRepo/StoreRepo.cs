using Microsoft.EntityFrameworkCore;
using Small_Stock_Project.Repos.StoreRepo;

namespace Small_Stock_Project;

public class StoreRepo : GenricRepo<Store> , IStoreRepo
{
    private readonly StockContext context;

    public StoreRepo(StockContext context):base(context)
    {
        this.context = context;
    }
}
