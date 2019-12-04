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

            migrationBuilder.Sql("insert into products (name, sold, created, CategoryId, Price, description) values ('Seat Ibiza',0,GetDate(),(Select ID from categories where name = 'car'),20000, 'small car')");
            migrationBuilder.Sql("insert into products (name, sold, created, CategoryId, Price, description) values ('Seat Leon',0,GetDate(),(Select ID from categories where name = 'car'),25000, 'middle size car')");
            migrationBuilder.Sql("insert into products (name, sold, created, CategoryId, Price, description) values ('VW Golf',0,GetDate(),(Select ID from categories where name = 'car'),25000, 'good car')");

            migrationBuilder.Sql("insert into products (name, sold, created, CategoryId, Price, description) values ('2k apartment',0,GetDate(),(Select ID from categories where name = 'home'), 25000, 'for small family')");
            migrationBuilder.Sql("insert into products (name, sold, created, CategoryId, Price, description) values ('3k apartment',0,GetDate(),(Select ID from categories where name = 'home'),40000, 'for big family')");
            migrationBuilder.Sql("insert into products (name, sold, created, CategoryId, Price, description) values ('1k apartment',0,GetDate(),(Select ID from categories where name = 'home'),22000,'forever alone')");

            migrationBuilder.Sql("insert into products (name, sold, created, CategoryId, Price, description) values ('t-shirt',0,GetDate(),(Select ID from categories where name = 'clothes'),15, 'tShort')");
            migrationBuilder.Sql("insert into products (name, sold, created, CategoryId, Price, description) values ('pants',0,GetDate(),(Select ID from categories where name = 'clothes'),20, 'pants')");
            migrationBuilder.Sql("insert into products (name, sold, created, CategoryId, Price, description) values ('jacket',0,GetDate(),(Select ID from categories where name = 'clothes'),50,'jacket')");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("delete from Products");
            migrationBuilder.Sql("delete from categories");
            
        }
    }
}
