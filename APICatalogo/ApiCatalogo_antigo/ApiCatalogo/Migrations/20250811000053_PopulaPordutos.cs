using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiCatalogo.Migrations
{
    /// <inheritdoc />
    public partial class PopulaPordutos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            // Bebidas
            mb.Sql("Insert into Produtos(Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) " +
                "values('Coca-Cola Diet', 'Refrigerante de cola 350 ml', 5.45, 'coca-cola.jpg', 50,now(),1)");

            //Lanches
            mb.Sql("Insert into Produtos(Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) " +
               "values('Lanche de Atum', 'Lanche de Atum com maionese', 8.50, 'atum.jpg', 10,now(),2)");

            // Sobremesas
            mb.Sql("Insert into Produtos(Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) " +
               "values('Pudim 100g', 'Pudim de leite condensado 100g', 6.75, 'pudim.jpg', 20,now(),3)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from Produtos");
        }
    }
}
