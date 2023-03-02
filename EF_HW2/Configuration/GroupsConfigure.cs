using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using EF_HW2.Models;

namespace EF_HW2.Configuration;

public class GroupsConfigure : IEntityTypeConfiguration<Groups>
{
    public void Configure(EntityTypeBuilder<Groups> builder)
    {
        builder.Property(x => x.Name)
            .IsRequired()
            .HasMaxLength(50);

        builder.HasOne<Faculties>()
            .WithMany()
            .HasForeignKey(x => x.Id_Facultity);
    }
}

