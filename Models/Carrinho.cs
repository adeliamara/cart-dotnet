using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_carrinho_dotnet.Models
{
    public class Carrinho
    {       
    public int Id {get;set;}

    public virtual ICollection<Produto>? Produtos {get;set;}
    [ForeignKey("Usuario")]
    public virtual int UsuarioId {get; set;}

    public virtual Usuario? Usuario {get; set;}
    }

}