using System.ComponentModel.DataAnnotations;

namespace Small_Stock_Project;

public class Store
{
    public int id { get; set; }

    [Required]
    public string name { get; set; } = String.Empty;

    [Required]
    public string address { get; set; } = String.Empty;


    public ICollection<StoreItem> storeItems { get; set; } = new HashSet<StoreItem>();  
}
