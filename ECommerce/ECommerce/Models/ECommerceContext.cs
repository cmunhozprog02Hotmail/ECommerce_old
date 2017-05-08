using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace ECommerce.Models
{
    public class ECommerceContext : DbContext
    {
        public ECommerceContext() : base("DefaultConnection")
        {

        }

        public DbSet<ECommerce.Models.Department> Departments { get; set; }

        public DbSet<ECommerce.Models.City> Cities { get; set; }

       
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Não permitir deletar em cascata
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            // Todo campo com Id serão chave primaria
            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());

            // Alterar os campos string nvarchar para varchar
            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            // Padronizar tamanho do campo string
            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

            
            
        }

    }

}