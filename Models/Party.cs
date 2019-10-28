using System;

namespace Lab7.Models
{

    public class Party
    {
        public int PartyId { get; set; }
        public string PartyName  { get; set; }
        public DateTime PartyDate { get; set; }
        public int ExpectedNumberOfGuests { get; set; }
        public string Location { get; set; }

    }


}