using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SEProje.ToDo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEProje.ToDo.DataAccess.Concrete.EntityFrameworkCore.Mapping
{
    class CalismaMap : IEntityTypeConfiguration<Calisma>
    {
        public void Configure(EntityTypeBuilder<Calisma> builder)
        {
            builder.HasKey(I => I.Id);
            builder.Property(I => I.Id).UseIdentityColumn();

            builder.Property(I => I.Ad).HasMaxLength(200);
            builder.Property(I => I.Aciklama).HasColumnType("ntext");

        }
    }
}
