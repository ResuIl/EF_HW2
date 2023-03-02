using EF_HW2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_HW2.Configuration;

public class BooksConfigure:IEntityTypeConfiguration<Books>
{
    public void Configure(EntityTypeBuilder<Books> builder)
    {
        builder.HasOne<Themes>()
            .WithMany()
            .HasForeignKey(x => x.Id_Themes);

        builder.HasOne<Press>()
            .WithMany()
            .HasForeignKey(x=>x.Id_Press);

        builder.HasOne<Authors>()
            .WithMany()
            .HasForeignKey(x => x.Id_Author);

        builder.HasOne<Category>()
            .WithMany()
            .HasForeignKey(x => x.Id_Category);
    }
}
