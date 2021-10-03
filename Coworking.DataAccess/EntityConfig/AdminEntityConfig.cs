using Coworking.DataAccess.Contracts.EntitiesBBDD;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coworking.DataAccess.EntityConfig
{
    public class AdminrEntityConfig
    {
        /// <summary>
        /// Define de properties to generate de Entity in datebase
        /// </summary>
        /// <param name="entityBuilder"></param>
        public static void setEntityBuilder(EntityTypeBuilder<AdminEntity> entityBuilder)
        {
            entityBuilder.ToTable("Admins");
            entityBuilder.HasKey(x => x.Id);
            entityBuilder.Property(x => x.Id).IsRequired();

            // configuramos la relacion 1 to 1 entre Office y Admin
            entityBuilder.HasOne(x => x.Office).WithOne(x => x.Admin).HasForeignKey<OfficeEntity>(c => c.Id);
        }
    }
}
