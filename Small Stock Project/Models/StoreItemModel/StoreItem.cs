using System.ComponentModel.DataAnnotations.Schema;

namespace Small_Stock_Project;

public class StoreItem
{

    public int StoreId { get; set; }
    public int ItemId { get; set; }

    public int Balance { get; set; }

    [ForeignKey("StoreId")]
    public Store? Store { get; set; }

    [ForeignKey("ItemId")]

    public Item? Item { get; set; } 

}
