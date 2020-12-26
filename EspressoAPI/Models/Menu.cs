using System;
using System.Collections.Generic;

namespace EspressoAPI.Models
{
    public class Menu
    {
        public Menu()
        {
        }

        public int ID { get; set; }

        public string Type { get; set; }

        public string Image { get; set; }

        public ICollection<SubMenu> SubMenus { get; set; }
    }
}
