using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Security.Policy;

namespace GuestList.Models
{
    public class Party
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public string localization { get; set;}
        public DateTime creationDate { get; set; }
        public DateTime partyDate { get; set; }
        public List<Guest> guestList { get; set; }

        public Party(string name, string localization, DateTime partyDate)
        {
            this.id = Guid.NewGuid();
            this.name = name;
            this.localization = localization;
            this.creationDate = DateTime.Now;
            this.partyDate = partyDate;
         
        }
        public void AddNewGuest(Guest guest)
        {
            guestList.Add(guest);
        }

    }
}
