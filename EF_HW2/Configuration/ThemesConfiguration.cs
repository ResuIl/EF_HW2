using EF_HW2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_HW2.Configuration;

public class ThemesConfiguration:IEntityTypeConfiguration<Themes>
{
    public void Configure(EntityTypeBuilder<Themes> builder)
    {
        builder.Property(x => x.Name).IsRequired().HasDefaultValue("Name");
    }
}
