using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalog.Migrations
{
    public partial class PopulateProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert into Products(Name,Description,Price,ImageUrl,Inventory,RegistrationDate,CategoryId)" +
            "Values('Coca-Cola Diet','Soda 350 ml',5.45,'cocacola.jpg',50,now(),1)");

            migrationBuilder.Sql("Insert into Products(Name,Description,Price,ImageUrl,Inventory,RegistrationDate,CategoryId)" +
             "Values('Tuna Sandwich','Sandwich with tuna, mayo and eggs',8.50,'tuna.jpg',10,now(),2)");

            migrationBuilder.Sql("Insert into Products(Name,Description,Price,ImageUrl,Inventory,RegistrationDate,CategoryId)" +
            "Values('Brownie 100 g','Sicilian lemon and white chocolate 100g',6.75,'brownie.jpg',20,now(),3)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from Products");

        }
    }
}
