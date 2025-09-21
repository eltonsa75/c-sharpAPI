﻿using ApiCatalogo.Validations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;


namespace ApiCatalogo.Models;

[Table("Produtos")]
public class Produto
{
    [Key]
    public int ProdutoId { get; set; }


    [Required(ErrorMessage = "O nome é obrigatorio")]
    [StringLength(20, ErrorMessage = "O nome deve ter nom máximo {1} e no mínimo {2} caracteres", MinimumLength = 5)]
    [PrimeiraLetraMaiusculaAttibute]
    public string Nome { get; set; }


    [Required]
    [StringLength(20, ErrorMessage = "A descrição deve ter no máximo {2} caracteres")]
    public string Descricao { get; set; }

    [Required]
    [Range(1, 10000, ErrorMessage = "O preço deve estar entre {1} e {2}")]
    [Column(TypeName ="decimal(10,2)")]
    public decimal Preco { get; set; }

    [Required]
    [StringLength(300, MinimumLength = 10)]
    public string? ImagemUrl { get; set; }

    public float Estoque { get; set; }

    public DateTime DataCadastro { get; set; }

    public int CategoriaId { get; set; }

    [JsonIgnore]
    public Categoria? Categoria { get; set; }

}
