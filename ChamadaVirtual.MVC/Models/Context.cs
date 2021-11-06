using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChamadaVirtual.MVC.Models
{
    public class Context : DbContext
    {
        public DbSet<Aluno> aluno { get; set; }
        public DbSet<Turma> turma { get; set; }
        public DbSet<ControlePresenca> controlePresenca { get; set; }
        public DbSet<Grupo> grupo { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString:@"Data Source = localhost\sql2014; Initial Catalog = ChamadaVirtualPI; Integrated Security = True");
        }
    }
}