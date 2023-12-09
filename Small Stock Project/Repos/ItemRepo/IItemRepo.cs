namespace Small_Stock_Project.Repos.ItemRepo
{
    public interface IItemRepo :IGenericRepo<Item>
    {
    public List<Item> ListByFilter(Func<Item, bool> lamda);

 
        
    }

   
}
