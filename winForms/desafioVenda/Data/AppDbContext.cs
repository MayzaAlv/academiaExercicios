    using DesafioDaVenda.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDaVenda.Data
{
    public class AppDbContext : DbContext // Conexão entre Api e o banco de dados
    {
        /// <summary>
        /// Rescrevendo as opções com as configurações do banco
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {                                                                             
            optionsBuilder.UseSqlServer("server=DESKTOP-Q0NIGH1\\SQLEXPRESS;database=vendaDb;trusted_connection=true;");
        }

        /// <summary>
        /// Conjunto de dados do banco 
        /// </summary>
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<ItemVenda> ItensVenda { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Venda> Vendas { get; set; }
    }
}
