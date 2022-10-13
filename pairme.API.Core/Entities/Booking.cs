using pairme.API.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pairme.API.Core.Entities
{
    public class Booking
    {
        public Guid Id { get; set; }
        public Guid ProfileId { get; set; }
        public Guid BookedUser { get; set; }
        public Guid BookingUser { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public bool Paid { get; set; }
        public BookingStatus Status { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
