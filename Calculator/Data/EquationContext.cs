using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Data
{
    internal class EquationContext : DbContext
    {
        public DbSet<EquationModel> Equations { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Data Source = MCHOJNA;
                Initial Catalog=CalculatorDB;
                Integrated Security=True;
                Encrypt=True;
                Trust Server Certificate=True"
            );
        }

    }
}
