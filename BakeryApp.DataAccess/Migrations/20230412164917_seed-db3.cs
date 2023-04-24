using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BakeryApp.DataAccess.Migrations
{
    public partial class seeddb3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_MenuItems_MenuItemId",
                table: "Recipes");

            migrationBuilder.DropIndex(
                name: "IX_Recipes_MenuItemId",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "MenuItemId",
                table: "Recipes");

            migrationBuilder.AddColumn<int>(
                name: "IngredientId",
                table: "MenuItemRecipes",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[] { 1, 10, "Strawberry Shortcake" });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[] { 2, 11, "Chocolate chip cookie" });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[] { 3, 10, "Croissant" });

            migrationBuilder.InsertData(
                table: "MenuItemRecipes",
                columns: new[] { "MenuItemId", "RecipeId", "IngredientId" },
                values: new object[] { 1, 2, 6 });

            migrationBuilder.InsertData(
                table: "MenuItemRecipes",
                columns: new[] { "MenuItemId", "RecipeId", "IngredientId" },
                values: new object[] { 1, 4, 6 });

            migrationBuilder.CreateIndex(
                name: "IX_MenuItemRecipes_IngredientId",
                table: "MenuItemRecipes",
                column: "IngredientId");

            migrationBuilder.AddForeignKey(
                name: "FK_MenuItemRecipes_Ingredients_IngredientId",
                table: "MenuItemRecipes",
                column: "IngredientId",
                principalTable: "Ingredients",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MenuItemRecipes_Ingredients_IngredientId",
                table: "MenuItemRecipes");

            migrationBuilder.DropIndex(
                name: "IX_MenuItemRecipes_IngredientId",
                table: "MenuItemRecipes");

            migrationBuilder.DeleteData(
                table: "MenuItemRecipes",
                keyColumns: new[] { "MenuItemId", "RecipeId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "MenuItemRecipes",
                keyColumns: new[] { "MenuItemId", "RecipeId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "IngredientId",
                table: "MenuItemRecipes");

            migrationBuilder.AddColumn<int>(
                name: "MenuItemId",
                table: "Recipes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_MenuItemId",
                table: "Recipes",
                column: "MenuItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_MenuItems_MenuItemId",
                table: "Recipes",
                column: "MenuItemId",
                principalTable: "MenuItems",
                principalColumn: "Id");
        }
    }
}
