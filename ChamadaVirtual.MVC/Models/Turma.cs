using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ChamadaVirtual.MVC.Models
{
    public class Turma
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo obigatório")]
        public string Descricao { get; set; }
        public List<Aluno> ListAlunos  { get; set; }
    }
}