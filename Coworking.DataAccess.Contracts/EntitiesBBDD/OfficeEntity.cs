using System;
using System.Collections.Generic;
using System.Text;

namespace Coworking.DataAccess.Contracts.EntitiesBBDD
{
    public class OfficeEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Addres { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public bool Active { get; set; }
        public string IdAdmin { get; set; }
        public bool HasIndividualWorkSpace { get; set; }
        public int NumberWorkSpaces { get; set; }
        public decimal PriceWorkSpaceDaily { get; set; }
        public decimal PriceWorkSpaceMonthly { get; set; }

        /// <summary>
        /// Definimos la relacion 1 a 1 entre la Entidad oficina y la entidad Admin
        /// Propiedad de navegacion.
        /// Si una Oficina tiene varios Admins seria ICollection<AdminEntity>
        /// </summary>
        public virtual AdminEntity Admin { get; set; }
        // referencia a booking
        public virtual BookingEntity Booking { get; set; }
        /// <summary>
        /// Relacion N -> N 
        /// </summary>
        public virtual ICollection<Offices2RoomsEntity> Office2Room { get; set; }
    }
}
