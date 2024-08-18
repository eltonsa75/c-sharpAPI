﻿namespace ApiCatalogo.Models;

public class Categoria
{
    public int CategoriaId { get; set; }
    public string? Nome { get; set; }
    public string? ImagemUrl { get; set; }

    // Relacionamento um para muitos
    public ICollection<Produto> Produtos { get; set; }
}
