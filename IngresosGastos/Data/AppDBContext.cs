using IngresosGastos.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace IngresosGastos.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext() : base("DefaultConnection")
        {

        }

        public DbSet<IngresosGastosFASS> IngesosGastos { get; set; }
    }
}