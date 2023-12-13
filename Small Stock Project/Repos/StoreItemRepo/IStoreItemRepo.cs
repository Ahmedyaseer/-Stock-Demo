namespace Small_Stock_Project;

public interface IStoreItemRepo : IGenericRepo<StoreItem>
{

    public int GetBalance(int StoreId, int ItemId);
    
    public void DecreaseBalance(int storeid, int itemid, int quantity);

    public List<IncludeDtoStoreBalanceItem> IncludeAllModels();

    public List<IncludeDtoStoreBalanceItem> GetAllByName(string name);

}
