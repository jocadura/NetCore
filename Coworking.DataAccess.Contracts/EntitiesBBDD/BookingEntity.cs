using System;
using System.Collections.Generic;
using System.Text;

namespace Coworking.DataAccess.Contracts.EntitiesBBDD
{
    /// <summary>
    /// Entidad de reserva de coworking
    /// </summary>
    public class BookingEntity
    {
        public Guid Id { get; set; }
        public Guid  UserId { get; set; }
        public bool Active { get; set; }
        public DateTime BookingDate { get; set; }
        public DateTime CreateDate { get; set; }
        public Guid OfficeId { get; set; }
        public bool RentWorkSpace { get; set; }
        public Guid? RoomId { get; set; }

        //referencias propiedades de navegacion con:
        public virtual UserEntity User { get; set; }
        public virtual OfficeEntity Office { get; set; }

    }
}
