using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Small_Stock_Project;

public class StockContext :DbContext
{
    public DbSet<Store> stores { get; set; }

    public DbSet<Item> items { get; set; }

    public DbSet<StoreItem> storeItems { get; set; }    

    public StockContext(DbContextOptions options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {


        // fluint api 
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());



        #region Data Store
        modelBuilder.Entity<Store>().HasData(
            new Store { id = 1, name = "Wardian", address = "Wardian st." },
            new Store { id = 2, name = "Zezienya" , address = "Zezienya st." },
            new Store { id = 3, name = "Syouif" , address = "Syouif Taram st." },
            new Store { id = 4, name = "Luran" , address = "Luran st." },
            new Store { id = 5, name = "Shots" , address = "Shots st." },
            new Store { id = 6, name = "NasrCity" , address = "NasrCity st." },
            new Store { id = 7, name = "Maady" , address = "Maddy st." },
            new Store { id = 8, name = "Shobra" , address = "Shbora st." },
            new Store { id = 9, name = "KafrAbdo" , address = "KafrAbdo st." },
            new Store { id = 10, name = "Vectoria" , address = "Vectoria st." }
            );
        #endregion

        #region Data Item
        modelBuilder.Entity<Item>().HasData(
            new Item { Id = 1 , Name = "Daflon" , Description = "Powder for oral solution in sachet" },
            new Item { Id = 2 , Name = "Oxazepam", Description = "Powder for solution for infusion" },
            new Item { Id = 3 , Name = "Euthyrox", Description = "Solution for peritoneal dialysis.." },
            new Item { Id = 4 , Name = "Rybelsus" , Description = "Solution for injection/infusion." },
            new Item { Id = 5 , Name = "Clonex", Description = "	Film-coated tablet	." },
            new Item { Id = 6 , Name = "OSPEN 500", Description = "PHENOXYMETHYLPENICILLIN." },
            new Item { Id = 7 , Name = "OTOCOL EAR DROPS", Description = "CHLORAMPHENICOL,BENZOCAINE." },
            new Item { Id = 8 , Name = "PANADOL COLD & FLU CAPLET", Description = "PARACETAMOL,PSEUDOEPHEDRINE." },
            new Item { Id = 9 , Name = "PANADOL ADVANCE 500MG", Description = "OVITRELLE 250MCG-0.5ML PRE-FILLED SYRING." },
            new Item { Id = 10 , Name = "PROSTIN E2 1MG VAGINAL GEL IN APPLICATOR", Description = "Vaginal gel" }
            );
        #endregion

        #region Data StoreItem
        modelBuilder.Entity<StoreItem>().HasData(
            new StoreItem { StoreId = 1 , ItemId = 1 , Balance = 10},
            new StoreItem { StoreId = 2 , ItemId = 2 , Balance = 8},
            new StoreItem { StoreId = 3 , ItemId = 3 , Balance = 11},
            new StoreItem { StoreId = 4 , ItemId = 4 , Balance = 7},
            new StoreItem { StoreId = 5 , ItemId = 5 , Balance = 3},
            new StoreItem { StoreId = 1 , ItemId = 2 , Balance = 4},
            new StoreItem { StoreId = 2 , ItemId = 3 , Balance = 2},
            new StoreItem { StoreId = 1 , ItemId = 5 , Balance = 10},
            new StoreItem { StoreId = 5 , ItemId = 3 , Balance = 9},
            new StoreItem { StoreId = 4 , ItemId = 1 , Balance = 8},
            new StoreItem { StoreId = 2 , ItemId = 5 , Balance = 18},
            new StoreItem { StoreId = 3 , ItemId = 4 , Balance = 17},
            new StoreItem { StoreId = 4 , ItemId = 2 , Balance = 15},
            new StoreItem { StoreId = 5 , ItemId = 1 , Balance = 14},
            new StoreItem { StoreId = 6 , ItemId = 6 , Balance = 9},
            new StoreItem { StoreId = 7 , ItemId = 7 , Balance = 16},
            new StoreItem { StoreId = 8 , ItemId = 8 , Balance = 17},
            new StoreItem { StoreId = 9 , ItemId = 9 , Balance = 22},
            new StoreItem { StoreId = 10 , ItemId = 10 , Balance = 20},
            new StoreItem { StoreId = 6 , ItemId = 10 , Balance = 25},
            new StoreItem { StoreId = 7 , ItemId = 9 , Balance = 3},
            new StoreItem { StoreId = 8 , ItemId = 6 , Balance = 5},
            new StoreItem { StoreId = 10 , ItemId = 7 , Balance = 6},
            new StoreItem { StoreId = 6 , ItemId = 8 , Balance = 8},
            new StoreItem { StoreId = 9 , ItemId = 8 , Balance = 4},
            new StoreItem { StoreId = 10 , ItemId = 2 , Balance = 7},
            new StoreItem { StoreId = 9 , ItemId = 3 , Balance = 6},
            new StoreItem { StoreId = 8 , ItemId = 4 , Balance = 4},
            new StoreItem { StoreId = 7 , ItemId = 3 , Balance = 3},
            new StoreItem { StoreId = 6 , ItemId = 5 , Balance = 12}
            );
        #endregion


    }

}
