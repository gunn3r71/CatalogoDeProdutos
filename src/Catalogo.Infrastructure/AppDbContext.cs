﻿using Catalogo.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Catalogo.Infrastructure
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        { }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }
    }
}
