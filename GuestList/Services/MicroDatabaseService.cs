﻿using GuestList.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GuestList.Services
{
    public class MicroDatabaseService
    {
        public static readonly MicroDatabaseService microDatabaseService = new MicroDatabaseService();
        List<Guest> guests = new List<Guest>();
        List<Party> party = new List<Party>();


        public MicroDatabaseService()
        {
            guests.Add(new Guest("Kacper","Osiadło",24));
            guests.Add(new Guest("Maciej", "Zabłocki", 24));
            party.Add(new Party("Impreza urodzinowa", "Fordon", new System.DateTime().AddDays(2)));
            

        }
        public Guest ReturnGuest(int i)
        {
            return guests[i];
        }
        public List<Guest> ReturnAllGuests()
        {
            return guests;
        }
        public void  AddNewGuest(Guest guest)
        {
            guests.Add(guest);
        }
        public void DeleteGuest(int id)
        {
            guests.RemoveAt(id);
        }


    }
}
