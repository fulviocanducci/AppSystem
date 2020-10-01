using AppSystem.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AppSystem.Maps
{
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
