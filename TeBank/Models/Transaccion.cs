using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TeBank.Models
{
    [Table("Transaccion")]
    public class Transaccion
    {
        [Key]
        public int Id { get; set; }

        public string TransaccionUnico { get; set; }

        public decimal Montotransaccion { get; set; }

        public TransStatus TransactionStatus { get; set; }

        public bool IsSuccessful => TransactionStatus.Equals(TransStatus.Exitoso);//Este exitoso funciona gracias a linea 40

        public string Cuentaemisor { get; set; }

        public string Cuentareceptor { get; set; }

        public string Comentariotransaccion { get; set; }

        public Trantipo TipoTransaccion { get; set; }

        public DateTime Fechatransaccion { get; set; }


    }

    public enum TransStatus
    {
        Fallido,
        Exitoso,
        Error
    }
    public enum Trantipo
    {
        Tranferencia
    }
}
