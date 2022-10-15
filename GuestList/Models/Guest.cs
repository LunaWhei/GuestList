using System;
using System.Collections.Generic;

namespace GuestList.Models
{
    public class Guest
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        DateTime creationDate { get; set; }
        

        public Guest(string name, string lastName, int age)
        {
            this.id = Guid.NewGuid();
            this.name = name;
            this.lastName = lastName;
            this.age = age;
            this.creationDate = DateTime.Now;
        }
    }
}
