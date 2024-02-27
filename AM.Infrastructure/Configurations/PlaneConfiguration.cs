using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure.Configurations
{
    public class PlaneConfiguration : IEntityTypeConfiguration<Plane>
    {
        public void Configure(EntityTypeBuilder<Plane> builder)
        {
            builder.HasKey(p => p.PlaneId);
            //nom de la table s'il existe il la nomme sinon il l ajoute avec ce nom 
            builder.ToTable("MyPlanes");
            //nom dela colonne
            builder.Property(p => p.Capacity).HasColumnName("PlaneCapacity");
        }
    }
}
