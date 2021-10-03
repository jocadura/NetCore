using Coworking.DataAccess.Contracts.EntitiesBBDD;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coworking.DataAccess.EntityConfig
{
    public class Room2ServiceEntityConfig
    {
        /// <summary>
        /// Define de properties to generate de Entity in datebase
        /// </summary>
        /// <param name="entityBuilder"></param>
        public static void setEntityBuilder(EntityTypeBuilder<Room2ServicesEntity> entityBuilder)
        {
            entityBuilder.ToTable("Room2Services");
            //referencia a room
            entityBuilder.HasOne(x => x.Room).WithMany(x => x.Rooms2Service).HasForeignKey(x => x.IdRoom);
            //referencia a services 
            entityBuilder.HasOne(x => x.Service).WithMany(x => x.Rooms2Service).HasForeignKey(x => x.IdService);


            // una clave primaria de las dos entidades
            entityBuilder.HasKey(x => new { x.IdRoom, x.IdService });
            entityBuilder.Property(x => x.IdRoom).IsRequired();
            entityBuilder.Property(x => x.IdService).IsRequired();
        }
    }
}
