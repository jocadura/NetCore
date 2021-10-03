using System;
using System.Collections.Generic;
using System.Text;

namespace Coworking.DataAccess.Contracts.EntitiesBBDD
{
    /// <summary>
    /// Entidad intermedia que refleja los servicios que dispone una room
    /// </summary>
    public class Room2ServicesEntity
    {
        public Guid IdRoom { get; set; }
        public Guid IdService { get; set; }

        /// <summary>
        /// Referencias a las entidades que forman la entidad intermedia
        /// </summary>
        public virtual RoomEntity Room { get; set; }
        public virtual ServiceEntity Service { get; set; }
    }
}
