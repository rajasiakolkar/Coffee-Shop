using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EspressoAPI.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EspressoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuController : Controller
    {
        EspressoDbContext _espressoDbContext;

        public MenuController(EspressoDbContext espressoDbContext)
        {
            _espressoDbContext = espressoDbContext;
        }

        [HttpGet]
        public IActionResult GetMenus()
        {
            var menus = _espressoDbContext.Menus.Include("SubMenus");
            return Ok(menus);
        }

        [HttpGet("{id}")]
        public IActionResult GetMenus(int id)
        {
            var _menu = _espressoDbContext.Menus.Include("SubMenus").FirstOrDefault(m => m.ID == id);

            if (_menu == null)
            {
                return NotFound();
            }
               
            return Ok(_menu);
        }
    }
}
