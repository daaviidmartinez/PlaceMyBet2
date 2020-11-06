using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class Apuesta
    {
        public Apuesta()
        {
        }

        public Apuesta(int apuestaId, DateTime fecha, int dinero_Apostado, string tipo_Apuesta, double cuota, string usuarioId, int mercadoId)
        {
            this.ApuestaId = apuestaId;
            this.fecha = fecha;
            this.dinero_Apostado = dinero_Apostado;
            this.tipo_Apuesta = tipo_Apuesta;
            this.cuota = cuota;
            UsuarioId = usuarioId;
            MercadoId = mercadoId;
        }

        public int ApuestaId { get; set; }
        public DateTime fecha { get; set; }
        public int dinero_Apostado { get; set; }
        public string tipo_Apuesta { get; set; }
        public double cuota { get; set; }
        public string UsuarioId { get; set; }
        public int MercadoId { get; set; }
        public Usuario usuario { get; set; }
        public Mercado mercado { get; set; }
    }
    public class ApuestaDTO
    {
        public ApuestaDTO(int dinero_Apostado, string tipo_Apuesta, double cuota, int id_Mercado)
        {
            this.dinero_Apostado = dinero_Apostado;
            this.tipo_Apuesta = tipo_Apuesta;
            this.cuota = cuota;
            this.id_Mercado = id_Mercado;
        }

        public int dinero_Apostado { get; set; }
        public string tipo_Apuesta { get; set; }
        public double cuota { get; set; }
        public int id_Mercado { get; set; }
    }
}