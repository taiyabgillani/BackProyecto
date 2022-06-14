using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeBank.Models;

namespace TeBank.DAL
{
    public class TuBankingDbContext : DbContext
    {
        public TuBankingDbContext(DbContextOptions<TuBankingDbContext> options) : base(options)
        {

        }

        public DbSet<Cuenta> Cuentas  { get; set; }
        public DbSet<Transaccion> Transacciones { get; set; }
    }
}
