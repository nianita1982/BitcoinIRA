using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Bitcoin.Data.Model.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsOrganic = table.Column<bool>(type: "bit", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Measure = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cost = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalTax = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TotalDiscount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RecipeIngredients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IngredientId = table.Column<int>(type: "int", nullable: false),
                    RecipeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipeIngredients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RecipeIngredients_Ingredients_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "Ingredients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RecipeIngredients_Recipes_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Cost", "IsOrganic", "Measure", "Name", "Type" },
                values: new object[,]
                {
                    { 1, 0.67m, true, "clover", "Garlic", 1 },
                    { 2, 2.03m, false, "unit", "Lemon", 1 },
                    { 3, 0.87m, false, "cup", "Corn", 1 },
                    { 4, 2.19m, false, "prey", "Chicken", 2 },
                    { 5, 0.24m, false, "slice", "Bacon", 2 },
                    { 6, 0.31m, false, "ounce", "Pasta", 3 },
                    { 7, 1.92m, false, "cup", "Olive Oil", 3 },
                    { 8, 1.26m, false, "cup", "Vinegar", 3 },
                    { 9, 0.16m, false, "teaspoon", "Salt", 3 },
                    { 10, 0.17m, false, "teaspoon", "Pepper", 3 }
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "Name", "Total", "TotalDiscount", "TotalTax" },
                values: new object[,]
                {
                    { 1, "1", null, null, null },
                    { 2, "2", null, null, null },
                    { 3, "3", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "RecipeIngredients",
                columns: new[] { "Id", "Amount", "IngredientId", "RecipeId" },
                values: new object[,]
                {
                    { 1, 1m, 1, 1 },
                    { 2, 1m, 2, 1 },
                    { 3, 0.75m, 7, 1 },
                    { 4, 0.75m, 9, 1 },
                    { 5, 0.5m, 10, 1 },
                    { 6, 1m, 1, 3 },
                    { 7, 4m, 3, 3 },
                    { 8, 4m, 5, 3 },
                    { 9, 8m, 6, 3 },
                    { 10, 0.33m, 7, 3 },
                    { 11, 1.25m, 9, 3 },
                    { 12, 0.75m, 10, 3 },
                    { 13, 1m, 1, 2 },
                    { 14, 4m, 4, 2 },
                    { 15, 0.5m, 7, 2 },
                    { 16, 0.5m, 8, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_RecipeIngredients_IngredientId",
                table: "RecipeIngredients",
                column: "IngredientId");

            migrationBuilder.CreateIndex(
                name: "IX_RecipeIngredients_RecipeId",
                table: "RecipeIngredients",
                column: "RecipeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RecipeIngredients");

            migrationBuilder.DropTable(
                name: "Ingredients");

            migrationBuilder.DropTable(
                name: "Recipes");
        }
    }
}
