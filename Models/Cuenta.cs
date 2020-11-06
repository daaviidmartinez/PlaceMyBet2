using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class Cuenta
    {
        public Cuenta()
        {
        }

        public Cuenta(string usuarioId, int tarjeta_Credito, string nombre_Banco, int saldo_Actual)
        {
            UsuarioId = usuarioId;
            Tarjeta_Credito = tarjeta_Credito;
            Nombre_Banco = nombre_Banco;
            Saldo_Actual = saldo_Actual;
        }

        public string UsuarioId { get; set; }
        public int Tarjeta_Credito { get; set; }
        public String Nombre_Banco { get; set; }
        public int Saldo_Actual { get; set; }
        public Usuario Usuario { get; set; }
    }
}