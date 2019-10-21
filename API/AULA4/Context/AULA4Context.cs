using AULA4.Models;
using Microsoft.EntityFrameworkCore;

namespace AULA4.Context
{
    public class AULA4Context : DbContext
    {

        public AULA4Context()
        {

        }

        public AULA4Context(DbContextOptions<AULA4Context> options):base(options)
        {

        }

        public virtual DbSet<UsuarioModel> USUARIO{get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=DESKTOP-F8MH8D0\SQLEXPRESS; DataBase=ATIVIDADE; Integrated Security=true");
            }
        }

    }
}