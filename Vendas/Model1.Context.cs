﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Vendas
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MercadinhoSeuFelipeEntities1 : DbContext
    {
        public MercadinhoSeuFelipeEntities1()
            : base("name=MercadinhoSeuFelipeEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Pessoa> Pessoa { get; set; }
        public virtual DbSet<ProdutosEstoque> ProdutosEstoque { get; set; }
        public virtual DbSet<ProdutosLista> ProdutosLista { get; set; }
        public virtual DbSet<Vendas> Vendas { get; set; }
        public virtual DbSet<Vendedor> Vendedor { get; set; }
        public virtual DbSet<Contas> Contas { get; set; }
    }
}
