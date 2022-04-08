using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NewCursoMVC.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "O campo Descrição é obrigatório")]
        public string Descricao { get; set; }

    }
}
