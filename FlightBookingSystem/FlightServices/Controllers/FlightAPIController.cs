using DAL_Reference.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightServices.Controllers
{
    [Route("api/v1.0/flight/flightapi/[controller]")]
    [ApiController]
    public class FlightAPIController : ControllerBase
    {

        FlightBookingApplicationDBContext _flightApplicationDBContext;
        public FlightAPIController(FlightBookingApplicationDBContext flightApplicationDBContext)
        {
            _flightApplicationDBContext = flightApplicationDBContext;
        }

        [HttpGet]
        [Route("GetFlightDetails")]
        public IEnumerable<TblFlightDetail> GetFlightDetails()
        {
            return _flightApplicationDBContext.TblFlightDetails.ToList();
        }


        [HttpPost]
        [Route("PostFlightDetails")]
        public IActionResult PostFlightDetails([FromBody] TblFlightDetail tblFlightDetail)
        {

            _flightApplicationDBContext.TblFlightDetails.Add(tblFlightDetail);
            _flightApplicationDBContext.SaveChanges();
            return new OkResult();
        }


        [HttpPut]
        [Route("PutFlightDetails")]
        public IActionResult PutFlightDetails([FromBody] TblFlightDetail tblFlightDetail)
        {

            _flightApplicationDBContext.Entry(tblFlightDetail).State = EntityState.Modified;
            _flightApplicationDBContext.SaveChanges();
            return new OkResult();
        }


        [HttpDelete]
        [Route("DeleteFlightDetails")]
        public IActionResult DeleteFlightDetails(int FlightId)
        {

            var flightId = _flightApplicationDBContext.TblFlightDetails.Find(FlightId);
            _flightApplicationDBContext.TblFlightDetails.Remove(flightId);
            _flightApplicationDBContext.SaveChanges();
            return new OkResult();
        }
    }
}
