using AULA3.Models;
using Microsoft.EntityFrameworkCore;

namespace AULA3.Context
{
    public class AULA3Context : DbContext
    {
        public AULA3Context(){

        }
        public AULA3Context(DbContextOptions<AULA3Context> options):base(options)
        {

        }

        public virtual DbSet<UsuarioModel> TBL_USUARIO{get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-F8MH8D0\SQLEXPRESS; DataBase=AULA_API; Integrated Security=true");
            }
        }
    }
}