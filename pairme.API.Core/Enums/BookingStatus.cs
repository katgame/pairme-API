using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pairme.API.Core
{
    public enum BookingStatus
    {
        [Display(Name= "#4ccb19, Green")]
        Booked,
        [Display(Name = "#B11a03, Red")]
        Cancelled,
        [Display(Name = "#Cb4419, Orange")]
        PendingPayment,
        [Display(Name = "#F4f707, Yellow")]
        Reserved
    }

}
