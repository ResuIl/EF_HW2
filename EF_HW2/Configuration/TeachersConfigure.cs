using EF_HW2.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
namespace EF_HW2.Configuration;

public class TeachersConfigure : IEntityTypeConfiguration<Teachers>
{
    public void Configure(EntityTypeBuilder<Teachers> builder)
    {        
        builder.HasOne<Departments>()
            .WithMany()
            .HasForeignKey(x => x.Id_Dep);
    }

}
