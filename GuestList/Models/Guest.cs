using System;
using System.Collections.Generic;

namespace GuestList.Models
{
    public class Guest
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public string lastName { get; set; }
        DateTime creationDate { get; set; }
        

        public Guest(string name, string lastName )
        {
            this.id = Guid.NewGuid();
            this.name = name;
            this.lastName = lastName;

            this.creationDate = DateTime.Now;
        }
        public Guest()
        {

        }
    }
}
