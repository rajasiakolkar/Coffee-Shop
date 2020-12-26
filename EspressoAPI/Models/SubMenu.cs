using System;
namespace EspressoAPI.Models
{
    public class SubMenu
    {
        public SubMenu()
        {
        }

        public int ID { get; set; }

        public string Name { get; set; }

        public string Image { get; set; }

        public string Description { get; set; }

        public int Price { get; set; }
    }
}
