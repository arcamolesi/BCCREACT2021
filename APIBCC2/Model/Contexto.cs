﻿using APIBCC2.Model.Dominio;
using APIBCC2.Model.Mapeamento;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIBCC2.Model
{
    public class Contexto: DbContext 
    {
        public Contexto(DbContextOptions<Contexto> options): base(options) { }

        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ProdutoMap()); 
        }
    }
}
