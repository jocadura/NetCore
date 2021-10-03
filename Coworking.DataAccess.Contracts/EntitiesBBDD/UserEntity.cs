using System;
using System.Collections.Generic;
using System.Text;

namespace Coworking.DataAccess.Contracts.EntitiesBBDD
{
    public class UserEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public bool Active { get; set; }
        public DateTime CreateDate { get; set; }

        // referencia a booking
        public virtual BookingEntity Booking { get; set; }
     }
}
