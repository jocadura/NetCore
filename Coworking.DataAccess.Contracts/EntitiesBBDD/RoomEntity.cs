using System;
using System.Collections.Generic;
using System.Text;

namespace Coworking.DataAccess.Contracts.EntitiesBBDD
{
    public class RoomEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Capacity { get; set; }

             /// <summary>
        /// Relacion N -> N 
        /// </summary>
        public virtual ICollection<Offices2RoomsEntity> Office2Rooms { get; set; }

        public virtual ICollection<Room2ServicesEntity> Rooms2Service { get; set; }
    }
}
