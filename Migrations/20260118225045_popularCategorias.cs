using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MinhaPrimeiraAPIDotNet.Migrations
{
    /// <inheritdoc />
    public partial class popularCategorias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("Insert into Categorias (Nome, ImagemUrl) values ('Lanches', 'lanches.png')");
            mb.Sql("Insert into Categorias (Nome, ImagemUrl) values ('Bebidas', 'bebidas.png')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete all from Categorias");
        }
    }
}
