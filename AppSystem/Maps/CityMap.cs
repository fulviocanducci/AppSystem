using AppSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AppSystem.Maps
{
    public class CityMap: EntityTypeConfiguration<City>
    {
        public CityMap()
        {
            ToTable("City");
            HasIndex(x => x.Id);
            Property(x => x.Id)
                .HasColumnName("Id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(100);
            Property(x => x.UfId)
                .IsRequired();
            HasRequired(x => x.Uf)
                .WithMany(x => x.Cities)
                .HasForeignKey(x => x.UfId);                
        }
    }
    public class UfMap : EntityTypeConfiguration<Uf>
    {
        public UfMap()
        {
            ToTable("Uf");
            HasIndex(x => x.Id);
            Property(x => x.Id)
                .HasColumnName("Id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(2);
            HasIndex(x => x.Name)
                .IsUnique();
            HasMany(x => x.Cities)
                .WithRequired(x => x.Uf)
                .HasForeignKey(x => x.UfId);
        }
    }
}
