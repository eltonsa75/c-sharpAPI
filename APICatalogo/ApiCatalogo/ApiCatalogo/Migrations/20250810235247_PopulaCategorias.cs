using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiCatalogo.Migrations
{
    /// <inheritdoc />
    public partial class PopulaCategorias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("Insert into Categorias(nome, ImagemUrl) values('Bebidas', 'bebidas.jpg')");
            mb.Sql("Insert into Categorias(nome, ImagemUrl) values('Lanches', 'lanches.jpg')");
            mb.Sql("Insert into Categorias(nome, ImagemUrl) values('Sobremesas', 'sobremesa.jpg')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from Categorias");
        }
    }
}
