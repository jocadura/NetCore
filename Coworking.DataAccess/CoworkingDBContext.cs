using Coworking.DataAccess.Contracts;
using Coworking.DataAccess.Contracts.EntitiesBBDD;
using Coworking.DataAccess.EntityConfig;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coworking.DataAccess
{
    public class CoworkingDBContext : DbContext,ICoworkingDBContext
    {

        public DbSet<UserEntity> Users { get; set; }
        public DbSet<AdminEntity> Admins { get; set; }
        public DbSet<BookingEntity> Bookings { get; set; }
        public DbSet<OfficeEntity> Offices { get; set; }
        public DbSet<RoomEntity> Rooms { get; set; }
        public DbSet<Offices2RoomsEntity> Offices2Rooms { get; set; }
        public DbSet<Room2ServicesEntity> Room2Services { get; set; }

        public CoworkingDBContext(DbContextOptions options) : base(options) { }
        public CoworkingDBContext() {  }
        /// <summary>
        /// Sobrecarga sobre el contexto para configurar las entidades en base de datos.
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void  OnModelCreating (ModelBuilder modelBuilder)
        {
            AdminrEntityConfig.setEntityBuilder(modelBuilder.Entity<AdminEntity>());
            BookingEntityConfig.setEntityBuilder(modelBuilder.Entity<BookingEntity>());
            Office2RoomEntityConfig.setEntityBuilder(modelBuilder.Entity<Offices2RoomsEntity>());
            OfficeEntityConfig.setEntityBuilder(modelBuilder.Entity<OfficeEntity>());
            Room2ServiceEntityConfig.setEntityBuilder(modelBuilder.Entity<Room2ServicesEntity>());
            RoomEntityConfig.setEntityBuilder(modelBuilder.Entity<RoomEntity>());
            ServiceEntityConfig.setEntityBuilder(modelBuilder.Entity<ServiceEntity>());
            UserEntityConfig.setEntityBuilder(modelBuilder.Entity<UserEntity>());

            base.OnModelCreating(modelBuilder);
        }

}
}
