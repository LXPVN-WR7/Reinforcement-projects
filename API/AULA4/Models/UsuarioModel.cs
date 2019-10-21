using System;
using System.ComponentModel.DataAnnotations;

namespace AULA4.Models
{
    public class UsuarioModel
    {
        [Key]
        public int usr_id {get; set;}

        public string usr_nome {get; set;}

        public string usr_descricao {get; set;}

        public DateTime usr_data {get; set;}
    }
}