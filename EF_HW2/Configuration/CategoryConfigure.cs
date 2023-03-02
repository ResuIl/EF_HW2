using EF_HW2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_HW2.Configuration;

public class CategoryConfigure:IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> Builder)
    {
        Builder.Property(x => x.Name).IsRequired().HasDefaultValue("name");
    }
}
