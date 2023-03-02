﻿using EF_HW2.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace EF_HW2.Configuration;

public class T_CardsConfigure : IEntityTypeConfiguration<T_Cards>
{
    public void Configure(EntityTypeBuilder<T_Cards> builder)
    {
        
        builder.HasOne<Books>()
            .WithMany()
            .HasForeignKey(x => x.Id_Books);


        builder.HasOne<Teachers>()
            .WithMany()
            .HasForeignKey(x => x.Id_Teacher);


        builder.HasOne<Libs>()
            .WithMany()
            .HasForeignKey(x => x.Id_Lib);

    }
}

