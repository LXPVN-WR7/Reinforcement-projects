using System.ComponentModel.DataAnnotations;

namespace AULA3.Models
{
    public class UsuarioModel
    {
        [Key]
        public int Usr_Id {get; set;}

        public string Usr_Nome {get; set;}

        public string Usr_Email {get; set;}

        public string Usr_Senha {get; set;}
    }
}