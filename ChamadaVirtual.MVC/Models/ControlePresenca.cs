using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChamadaVirtual.MVC.Models
{
    public class ControlePresenca
    {
        public int Id { get; set; }
        public DateTime DataPresenca { get; set; }
        public int AlunoId { get; set; }
        public Aluno oAluno { get; set; }
    }
}
