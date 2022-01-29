using Microsoft.EntityFrameworkCore.Migrations;

namespace InternetShop.Data.EF.Migrations
{
    public partial class FullTextSearch : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("CREATE FULLTEXT CATALOG InternetShopFullTextCatalog AS DEFAULT", suppressTransaction: true);
            migrationBuilder.Sql("CREATE FULLTEXT INDEX ON BOOKS(Author, Title) KEY INDEX PK_Books WITH STOPLIST = SYSTEM", suppressTransaction: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP FULLTEXT INDEX ON Books", suppressTransaction: true);
            migrationBuilder.Sql("DROP FULLTEXT CATALOG InternetShopFullTextCatalog", suppressTransaction: true);
        }
    }
}
