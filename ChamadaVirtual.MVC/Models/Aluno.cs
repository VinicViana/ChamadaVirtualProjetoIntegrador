using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ChamadaVirtual.MVC.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo obigatório")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Campo obigatório")]
        public string Matricula { get; set; }
        [Required(ErrorMessage = "Campo obigatório")]
        public int TurmaId { get; set; }
        public int GrupoId { get; set; }
        public Turma oTurma { get; set; }
        public Grupo oGrupo { get; set; }
    }
}