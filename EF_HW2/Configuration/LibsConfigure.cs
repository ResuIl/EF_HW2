using EF_HW2.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace EF_HW2.Configuration;

public class LibsConfigure : IEntityTypeConfiguration<Libs>
{
    public void Configure(EntityTypeBuilder<Libs> builder)
    {
        builder.Property(x => x.FirstName)
            .IsRequired()
            .HasMaxLength(50);


        builder.Property(x => x.LastName)
            .IsRequired()
            .HasMaxLength(50);

    }
}