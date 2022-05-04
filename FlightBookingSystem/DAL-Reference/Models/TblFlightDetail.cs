using System;
using System.Collections.Generic;

#nullable disable

namespace DAL_Reference.Models
{
    public partial class TblFlightDetail
    {
        public int FlightId { get; set; }
        public string AirLineName { get; set; }
        public string FromPlace { get; set; }
        public string ToPlace { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string TicketCost { get; set; }
        public int? BusinessClassSeats { get; set; }
        public int? NonBusinessClassSeats { get; set; }
    }
}
