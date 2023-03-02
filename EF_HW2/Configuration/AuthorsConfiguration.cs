using EF_HW2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityFrameWork_Hw2.Configuration;

public class AuthorsConfiguration:IEntityTypeConfiguration<Authors>
{
    public void Configure(EntityTypeBuilder<Authors> builder)
    {
        builder.Property(x => x.FirstName).IsRequired().HasDefaultValue("FirstName");
        builder.Property(x => x.LastName).IsRequired().HasDefaultValue("LastName");
    }
}
