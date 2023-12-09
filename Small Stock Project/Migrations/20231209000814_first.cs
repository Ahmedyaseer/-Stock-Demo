using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Small_Stock_Project.Migrations
{
    /// <inheritdoc />
    public partial class first : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_items", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "stores",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stores", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "storeItems",
                columns: table => new
                {
                    StoreId = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    Balance = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_storeItems", x => new { x.StoreId, x.ItemId });
                    table.ForeignKey(
                        name: "FK_storeItems_items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_storeItems_stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "stores",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "items",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Powder for oral solution in sachet", "Daflon" },
                    { 2, "Powder for solution for infusion", "Oxazepam" },
                    { 3, "Solution for peritoneal dialysis..", "Euthyrox" },
                    { 4, "Solution for injection/infusion.", "Rybelsus" },
                    { 5, "	Film-coated tablet	.", "Clonex" },
                    { 6, "PHENOXYMETHYLPENICILLIN.", "OSPEN 500" },
                    { 7, "CHLORAMPHENICOL,BENZOCAINE.", "OTOCOL EAR DROPS" },
                    { 8, "PARACETAMOL,PSEUDOEPHEDRINE.", "PANADOL COLD & FLU CAPLET" },
                    { 9, "OVITRELLE 250MCG-0.5ML PRE-FILLED SYRING.", "PANADOL ADVANCE 500MG" },
                    { 10, "Vaginal gel", "PROSTIN E2 1MG VAGINAL GEL IN APPLICATOR" }
                });

            migrationBuilder.InsertData(
                table: "stores",
                columns: new[] { "id", "address", "name" },
                values: new object[,]
                {
                    { 1, "Wardian st.", "Wardian" },
                    { 2, "Zezienya st.", "Zezienya" },
                    { 3, "Syouif Taram st.", "Syouif" },
                    { 4, "Luran st.", "Luran" },
                    { 5, "Shots st.", "Shots" },
                    { 6, "NasrCity st.", "NasrCity" },
                    { 7, "Maddy st.", "Maady" },
                    { 8, "Shbora st.", "Shobra" },
                    { 9, "KafrAbdo st.", "KafrAbdo" },
                    { 10, "Vectoria st.", "Vectoria" }
                });

            migrationBuilder.InsertData(
                table: "storeItems",
                columns: new[] { "ItemId", "StoreId", "Balance" },
                values: new object[,]
                {
                    { 1, 1, 10 },
                    { 2, 1, 4 },
                    { 5, 1, 10 },
                    { 2, 2, 8 },
                    { 3, 2, 2 },
                    { 5, 2, 18 },
                    { 3, 3, 11 },
                    { 4, 3, 17 },
                    { 1, 4, 8 },
                    { 2, 4, 15 },
                    { 4, 4, 7 },
                    { 1, 5, 14 },
                    { 3, 5, 9 },
                    { 5, 5, 3 },
                    { 5, 6, 12 },
                    { 6, 6, 9 },
                    { 8, 6, 8 },
                    { 10, 6, 25 },
                    { 3, 7, 3 },
                    { 7, 7, 16 },
                    { 9, 7, 3 },
                    { 4, 8, 4 },
                    { 6, 8, 5 },
                    { 8, 8, 17 },
                    { 3, 9, 6 },
                    { 8, 9, 4 },
                    { 9, 9, 22 },
                    { 2, 10, 7 },
                    { 7, 10, 6 },
                    { 10, 10, 20 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_storeItems_ItemId",
                table: "storeItems",
                column: "ItemId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "storeItems");

            migrationBuilder.DropTable(
                name: "items");

            migrationBuilder.DropTable(
                name: "stores");
        }
    }
}
