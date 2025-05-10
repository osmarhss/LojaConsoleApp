using Marketplace___ConsoleApp.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Marketplace___ConsoleApp.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {          
        }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
    }
}
