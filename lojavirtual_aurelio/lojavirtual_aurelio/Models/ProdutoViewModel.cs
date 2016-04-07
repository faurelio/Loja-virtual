using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace lojavirtual_aurelio.Models
{
    public class ProdutoViewModel
    {
       public Guid? Id { get; set; }

        [Required(ErrorMessage = "Nome e obrigatorio.")]
        public string Nome { get; set; }

        public string Categoria { get; set; }
    }
}