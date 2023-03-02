using EF_HW2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_HW2.Configuration;

public class PressConfigure:IEntityTypeConfiguration<Press>
{
    public void Configure(EntityTypeBuilder<Press> builder)
    {
        builder.Property(x => x.Name).IsRequired().HasDefaultValue("Name");
    }
}
