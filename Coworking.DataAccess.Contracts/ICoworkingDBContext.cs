using Coworking.DataAccess.Contracts.EntitiesBBDD;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coworking.DataAccess.Contracts
{
    /// <summary>
    /// Inyeccion para el contexto
    /// </summary>
    public interface ICoworkingDBContext
    {
        DbSet<UserEntity> Users { get; set; }
        DbSet<AdminEntity> Admins { get; set; }
        DbSet<BookingEntity> Bookings { get; set; }
        DbSet<OfficeEntity> Offices { get; set; }
        DbSet<RoomEntity> Rooms { get; set; }
        DbSet<Offices2RoomsEntity> Offices2Rooms { get; set; }
        DbSet<Room2ServicesEntity> Room2Services { get; set; }
    }
}
