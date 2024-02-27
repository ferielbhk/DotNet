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
    public class FlightConfiguration : IEntityTypeConfiguration<Flight>
    {
        public void Configure(EntityTypeBuilder<Flight> builder)
        {
            //configurer la relation *-*
            builder.HasMany(f => f.Passengers)
                .WithMany(f => f.Flights)
                //t=tabled associations
                .UsingEntity(t => t.ToTable("Reservations"));
            //configurer relation 1-*
            builder.HasOne(f => f.Plane)
                .WithMany(p => p.Flights)
                .HasForeignKey(f => f.PlaneFK)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
