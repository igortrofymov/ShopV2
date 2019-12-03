using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopV2.WEB.Migrations
{
    public partial class SeedDataBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert into categories (name, description) values ('car','vehicle')");
            migrationBuilder.Sql("insert into categories (name, description) values ('home','house stuff')");
            migrationBuilder.Sql("insert into categories (name, description) values ('clothes','clothes')");

            migrationBuilder.Sql("insert into products (name, sold, created, CategoryId, Price) values ('Seat Ibiza',0,GetDate(),(Select ID from categories where name = 'car'),20000)");
            migrationBuilder.Sql("insert into products (name, sold, created, CategoryId, Price) values ('Seat Leon',0,GetDate(),(Select ID from categories where name = 'car'),25000)");
            migrationBuilder.Sql("insert into products (name, sold, created, CategoryId, Price) values ('VW Golf',0,GetDate(),(Select ID from categories where name = 'car'),25000)");

            migrationBuilder.Sql("insert into products (name, sold, created, CategoryId, Price) values ('2k apartment',0,GetDate(),(Select ID from categories where name = 'home'), 25000)");
            migrationBuilder.Sql("insert into products (name, sold, created, CategoryId, Price) values ('3k apartment',0,GetDate(),(Select ID from categories where name = 'home'),40000)");
            migrationBuilder.Sql("insert into products (name, sold, created, CategoryId, Price) values ('1k apartment',0,GetDate(),(Select ID from categories where name = 'home'),22000)");

            migrationBuilder.Sql("insert into products (name, sold, created, CategoryId, Price) values ('t-shirt',0,GetDate(),(Select ID from categories where name = 'clothes'),15)");
            migrationBuilder.Sql("insert into products (name, sold, created, CategoryId, Price) values ('pants',0,GetDate(),(Select ID from categories where name = 'clothes'),20)");
            migrationBuilder.Sql("insert into products (name, sold, created, CategoryId, Price) values ('jacket',0,GetDate(),(Select ID from categories where name = 'clothes'),50)");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("delete from Products");
            migrationBuilder.Sql("delete from categories");
            
        }
    }
}
