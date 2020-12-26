using System;
namespace EspressoAPI.Models
{
    public class Reservation
    {
        public Reservation()
        {
        }

        public int ID { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public int totalPeople { get; set; }

        public DateTime Date { get; set; }

        public string Time { get; set; }

    }
}
