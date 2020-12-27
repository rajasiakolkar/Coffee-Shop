using System;
using System.ComponentModel.DataAnnotations;

namespace EspressoAPI.Models
{
    public class Reservation
    {
        public Reservation()
        {
        }

        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Email in not valid")]
        public string Email { get; set; }

        [Required]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Invalid Phone Number")]
        public string Phone { get; set; }

        [Required]
        public int totalPeople { get; set; }

        [Required]
        public string Date { get; set; }

        [Required]
        //[DataType(DataType.DateTime)]
        public string Time { get; set; }

    }
}
