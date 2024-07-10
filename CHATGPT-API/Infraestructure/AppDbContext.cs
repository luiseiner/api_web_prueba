using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Microsoft.EntityFrameworkCore;


namespace Infraestructure
{
    public class ContextFactura : DbContext
    {

        public ContextFactura(DbContextOptions options) : base(options)
        {
        }

        public ContextFactura() : base() { }

        public DbSet<Prueba> Pruebas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {


            //var connectionString = Convert.ToString( Configuration.GetSection("ConnectionStrings")["Conexion"]);

            var connectionString = "Data Source=DESKTOP-F970KVM;Initial Catalog=FacturaDB;User ID=usrFactura;Password=123456;";

            if (!optionsBuilder.IsConfigured)
            {
                //optionsBuilder.UseSqlServer(connectionString, sqlServerOptions => sqlServerOptions.CommandTimeout(config.SecondsTimeOutBD));
                optionsBuilder.UseSqlServer(connectionString, sqlServerOptions => sqlServerOptions.CommandTimeout(120));
            }
        }

    }

}
