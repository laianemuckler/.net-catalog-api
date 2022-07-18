using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalog.Migrations
{
    public partial class PopulateCategories : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("Insert into Categories(Name, ImageUrl) Values('Beverages', 'beverages.jpg')");
            mb.Sql("Insert into Categories(Name, ImageUrl) Values('Snacks', 'snacks.jpg')");
            mb.Sql("Insert into Categories(Name, ImageUrl) Values('Desserts', 'desserts.jpg')");
        }

        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from Categories");

        }
    }
}
