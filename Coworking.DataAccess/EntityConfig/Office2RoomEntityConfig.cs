using Coworking.DataAccess.Contracts.EntitiesBBDD;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coworking.DataAccess.EntityConfig
{
    public class Office2RoomEntityConfig
    {
        /// <summary>
        /// Define de properties to generate de Entity in datebase
        /// </summary>
        /// <param name="entityBuilder"></param>
        public static void setEntityBuilder(EntityTypeBuilder<Offices2RoomsEntity> entityBuilder)
        {
            entityBuilder.ToTable("Office2Room");
            // Una ofinicia tiene varias ofice2Room y como clave foranea OfficeId
            entityBuilder.HasOne(x => x.Office).WithMany(x => x.Office2Room).HasForeignKey(x => x.OfficeId);
            // Un room que tiene varios office2Romm y como clave foranea roomId
            entityBuilder.HasOne(x => x.Room).WithMany(x => x.Office2Rooms).HasForeignKey(x => x.RoomId);

            // una clave primaria de las dos entidades
            entityBuilder.HasKey(x => new { x.OfficeId, x.RoomId });
            entityBuilder.Property(x => x.OfficeId).IsRequired();
            entityBuilder.Property(x => x.RoomId).IsRequired();
        }
    }
}
