using Coworking.DataAccess.Contracts.EntitiesBBDD;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coworking.DataAccess.EntityConfig
{
    public class BookingEntityConfig
    {
        /// <summary>
        /// Define de properties to generate de Entity in datebase
        /// </summary>
        /// <param name="entityBuilder"></param>
        public static void setEntityBuilder(EntityTypeBuilder<BookingEntity> entityBuilder)
        {
            entityBuilder.ToTable("Bookings");
            entityBuilder.HasKey(x => x.Id);
            entityBuilder.Property(x => x.Id).IsRequired();

            // configuramos la relacion 1 to 1 entre Office y Booking
            entityBuilder.HasOne(x => x.Office).WithOne(x => x.Booking);
            //un user tiene un booking
            entityBuilder.HasOne(x => x.User).WithOne(x => x.Booking);
        }
    }
}
