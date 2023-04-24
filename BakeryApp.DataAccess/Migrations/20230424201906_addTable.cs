using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BakeryApp.DataAccess.Migrations
{
    public partial class addTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MenuItemRecipes_Ingredients_IngredientId",
                table: "MenuItemRecipes");

            migrationBuilder.DropIndex(
                name: "IX_MenuItemRecipes_IngredientId",
                table: "MenuItemRecipes");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "IngredientId",
                table: "MenuItemRecipes");

            migrationBuilder.AlterColumn<string>(
                name: "Unit",
                table: "recipeIngredients",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Amount",
                table: "recipeIngredients",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "MenuItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Instructions",
                table: "MenuItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "MenuItemIngredient",
                columns: table => new
                {
                    IngredientId = table.Column<int>(type: "int", nullable: false),
                    MenuItemId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuItemIngredient", x => new { x.IngredientId, x.MenuItemId });
                    table.ForeignKey(
                        name: "FK_MenuItemIngredient_Ingredients_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "Ingredients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MenuItemIngredient_MenuItems_MenuItemId",
                        column: x => x.MenuItemId,
                        principalTable: "MenuItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[,]
                {
                    { 1, 4, "Butter" },
                    { 2, 4, "Milk" },
                    { 3, 5, "Sugar" },
                    { 4, 5, "Brown Sugar" },
                    { 5, 6, "Flour" },
                    { 6, 6, "StrawBerry" }
                });

            migrationBuilder.UpdateData(
                table: "recipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 1, 2 },
                column: "Amount",
                value: null);

            migrationBuilder.UpdateData(
                table: "recipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 3, 3 },
                column: "Amount",
                value: null);

            migrationBuilder.UpdateData(
                table: "recipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 5, 3 },
                column: "Amount",
                value: null);

            migrationBuilder.UpdateData(
                table: "recipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 5, 4 },
                column: "Amount",
                value: null);

            migrationBuilder.InsertData(
                table: "MenuItemIngredient",
                columns: new[] { "IngredientId", "MenuItemId", "Id" },
                values: new object[] { 4, 1, null });

            migrationBuilder.InsertData(
                table: "MenuItemIngredient",
                columns: new[] { "IngredientId", "MenuItemId", "Id" },
                values: new object[] { 6, 1, null });

            migrationBuilder.CreateIndex(
                name: "IX_MenuItemIngredient_MenuItemId",
                table: "MenuItemIngredient",
                column: "MenuItemId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MenuItemIngredient");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DropColumn(
                name: "Instructions",
                table: "MenuItems");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Recipes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Unit",
                table: "recipeIngredients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Amount",
                table: "recipeIngredients",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "MenuItems",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "IngredientId",
                table: "MenuItemRecipes",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[,]
                {
                    { 1, 4, "Butter" },
                    { 2, 4, "Milk" },
                    { 3, 5, "Sugar" },
                    { 4, 5, "Brown Sugar" },
                    { 5, 6, "Flour" },
                    { 6, 6, "StrawBerry" }
                });

            migrationBuilder.UpdateData(
                table: "recipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 1, 2 },
                column: "Amount",
                value: 0);

            migrationBuilder.UpdateData(
                table: "recipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 3, 3 },
                column: "Amount",
                value: 0);

            migrationBuilder.UpdateData(
                table: "recipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 5, 3 },
                column: "Amount",
                value: 0);

            migrationBuilder.UpdateData(
                table: "recipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 5, 4 },
                column: "Amount",
                value: 0);

            migrationBuilder.UpdateData(
                table: "MenuItemRecipes",
                keyColumns: new[] { "MenuItemId", "RecipeId" },
                keyValues: new object[] { 1, 2 },
                column: "IngredientId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "MenuItemRecipes",
                keyColumns: new[] { "MenuItemId", "RecipeId" },
                keyValues: new object[] { 1, 4 },
                column: "IngredientId",
                value: 6);

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
    }
}
