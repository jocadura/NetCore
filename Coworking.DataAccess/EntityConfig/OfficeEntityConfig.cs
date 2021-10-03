using Coworking.DataAccess.Contracts.EntitiesBBDD;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coworking.DataAccess.EntityConfig
{
    public class OfficeEntityConfig
    {
        /// <summary>
        /// Define de properties to generate de Entity in datebase
        /// </summary>
        /// <param name="entityBuilder"></param>
        public static void setEntityBuilder(EntityTypeBuilder<OfficeEntity> entityBuilder)
        {
            entityBuilder.ToTable("Offices");
            entityBuilder.HasKey(x => x.Id);
            entityBuilder.Property(x => x.Id).IsRequired();

            // configuramos la relacion una oficna un administrador
            entityBuilder.HasOne(x => x.Admin).WithOne(x => x.Office);
            // relacion una reserva una oficina
            entityBuilder.HasOne(x => x.Booking).WithOne(x => x.Office);
        }
    }
}
