using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EspressoAPI.Data;
using EspressoAPI.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EspressoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : Controller
    {

        EspressoDbContext _espressoDbContext;

        public ReservationController(EspressoDbContext espressoDbContext)
        {
            _espressoDbContext = espressoDbContext;
        }

        [HttpPost]
        public IActionResult Post([FromBody] Reservation reservation)
        {
            _espressoDbContext.Reservations.Add(reservation);
            _espressoDbContext.SaveChanges();

            return Created("Reservation successfully created!", reservation);
        }
    }
}
