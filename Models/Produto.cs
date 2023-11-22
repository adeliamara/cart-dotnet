using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_carrinho_dotnet.Models
{
    public class Produto
    {   
       [Display(Name = "Cod do produto")]
       public int Id { get; set; }

       [Display(Name = "Descrição")]
       public string? Descricacao { get; set; }

       [Display(Name = "Caminho da imagem")]
       public string? PathImagem { get; set; }

       [Display(Name = "Preço")]
       public decimal? Preco { get; set; }
       public int? Quantidade { get; set; }

       public virtual ICollection<Carrinho>? CarrinhosProduto {get;set;}

       [ForeignKey("Categoria")]
       public int CategoriaId {get; set;}
       public virtual Categoria? Categoria {get; set;}
    }
}