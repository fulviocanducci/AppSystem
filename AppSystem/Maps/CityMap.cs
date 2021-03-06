﻿using AppSystem.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AppSystem.Maps
{
    public class CityMap : EntityTypeConfiguration<City>
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
}
