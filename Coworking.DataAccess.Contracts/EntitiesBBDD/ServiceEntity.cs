using System;
using System.Collections.Generic;
using System.Text;

namespace Coworking.DataAccess.Contracts.EntitiesBBDD
{
    /// <summary>
    /// Entidad que contiene los servicios.
    /// </summary>
    public class ServiceEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public decimal Price { get; set; }

        /// <summary>
        /// Relacion N -> N 
        /// </summary>
        public virtual ICollection<Offices2RoomsEntity> Office2Rooms { get; set; }

        public virtual ICollection<Room2ServicesEntity> Rooms2Service { get; set; }
    }
}
