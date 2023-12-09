namespace Small_Stock_Project;

public class StoreItemVM
{
    public List<Store> Stores { get; set; } = new List<Store>();

    public int StoreId { get; set; } 

    public List<Item> Items { get; set; }= new List<Item>();    

    public int ItemId { get; set; } 
}
