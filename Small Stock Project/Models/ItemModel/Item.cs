using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Small_Stock_Project;

public class Item
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; } = String.Empty;

    [Required]
    public string Description { get; set; } = String.Empty;


    

    public ICollection<StoreItem> storeItems { get; set; } = new HashSet<StoreItem>();      
}
