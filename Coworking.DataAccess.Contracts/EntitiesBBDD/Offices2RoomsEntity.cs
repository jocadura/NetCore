using System;
using System.Collections.Generic;
using System.Text;

namespace Coworking.DataAccess.Contracts.EntitiesBBDD
{
    /// <summary>
    /// Entidad intermedia que contiene la relacion entre oficinas y rooms
    /// </summary>
    public class Offices2RoomsEntity
    {
        public Guid OfficeId { get; set; }
        public Guid RoomId { get; set; }

        public virtual OfficeEntity Office { get; set; }
        public virtual RoomEntity Room { get; set; }
    }
}
