using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MinhaPrimeiraAPIDotNet.Migrations
{
    /// <inheritdoc />
    public partial class popularProdutos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("Insert into Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) " +
                "values ('X-Salada', 'Delicioso sanduíche com carne bovina, queijo, alface, tomate e maionese.', 15.90, 'x-salada.png', 50, now(), 1)");

            mb.Sql("Insert into Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) " + 
                "values ('Coca-Cola 600ml', 'Refrigerante de cola gelado para acompanhar sua refeição.', 6.50, 'coca-cola-600ml.png', 100, now(), 2)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete all from Produtos");
        }
    }
}
