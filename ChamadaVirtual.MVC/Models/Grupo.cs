using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChamadaVirtual.MVC.Models
{
    public class Grupo
    {
        public int Id { get; set; }
        public string NomeGrupo { get; set; }
        public List<Aluno> ListAlunos { get; set; }
    }
}