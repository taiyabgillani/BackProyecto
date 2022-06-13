using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TeBank.Models
{   [Table("Cuenta")]
    public class Cuenta
    {
        [Key]
        public int Id { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Nombrecuenta { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public decimal Balanceactual { get; set; }
        public Tipocuenta Tipocuenta { get; set; }
        public string Numerocuenta { get; set; }
        public byte[] Pinhash { get; set; }
        public byte Pinsalt { get; set; }
        public DateTime Fechacrear { get; set; }
        public DateTime Fechaactualizar { get; set; }

        Random rand = new Random();

        public Cuenta()
        {
            Numerocuenta = Convert.ToString((long) rand.NextDouble() * 9_000_000_000L + 1_000_000_000L);

            Nombrecuenta = $"{Nombre} {Apellido}";
        }
    }



    public enum Tipocuenta
    {
         Corrientepersonal,
         Ahorropersonal,
         Corrienteempresarial,
         Corrientecorporativa,
         Empresarialdolares,
         Empresarialeuros
    }
}
