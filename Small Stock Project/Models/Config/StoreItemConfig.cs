using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Small_Stock_Project.Models.Config
{
    public class StoreItemConfig : IEntityTypeConfiguration<StoreItem>
    {
        public void Configure(EntityTypeBuilder<StoreItem> builder)
        {
            builder.HasKey(s => new
            {
                s.StoreId,
                s.ItemId
            });
        }
    }
}
