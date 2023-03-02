using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using EF_HW2.Models;

namespace EF_HW2.Configuration;

public class FacultiesConfigure : IEntityTypeConfiguration<Faculties>
{
    public void Configure(EntityTypeBuilder<Faculties> builder)
    {
        builder.Property(x => x.Name)
            .IsRequired()
            .HasMaxLength(50);
    }
}

