using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    
    public class Usuario
    {
        public Usuario()
        {
        }

        public Usuario(int usuarioId, string email, string nombre, string apellido, int edad)
        {
            UsuarioId = usuarioId;
            Email = email;
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
        }

        public int UsuarioId { get; set; }
        [System.ComponentModel.DataAnnotations.Key]
        public string Email { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        

    }
}