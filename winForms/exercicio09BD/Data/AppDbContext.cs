using exercicio09BD.Models;
using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.EntityFrameworkCore.Proxies;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio09BD.Data
{
    internal class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-Q0NIGH1\\SQLEXPRESS;database=Usuarios;trusted_connection=true;");
        }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
