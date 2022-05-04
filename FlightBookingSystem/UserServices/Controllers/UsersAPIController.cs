using DAL_Reference.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace UserServices.Controllers
{

    [Route("api/v1.0/flight/Users/[controller]")]
    [ApiController]
    public class UsersAPIController : ControllerBase
    {
        FlightBookingApplicationDBContext _flightApplicationDBContext;
        public UsersAPIController(FlightBookingApplicationDBContext flightApplicationDBContext)
        {
            _flightApplicationDBContext = flightApplicationDBContext;

            
        }

        [HttpGet]
        [Route("GetUserDetails")]
        public IEnumerable<TblUserDataDetail> GetUserDetails()
        {
            return _flightApplicationDBContext.TblUserDataDetails.ToList();
        }

        //[HttpGet]
        //[Route("GetUserByIDDetails/{UserID}")]
        //public IEnumerable<TblUserDataDetail> GetUserDetails([FromBody] string UserID)
        //{
        //    return _flightApplicationDBContext.TblUserDataDetails.ToList();
        //}


        [HttpPost]
        [Route("PostUserDetails")]
        public IActionResult PostUserDetails([FromBody] TblUserDataDetail tblUserDetail)
        {

            _flightApplicationDBContext.TblUserDataDetails.Add(tblUserDetail);
            _flightApplicationDBContext.SaveChanges();
            return new OkResult();
        }


        [HttpPut]
        [Route("PutUserDetails")]
        public IActionResult PutUserDetails([FromBody] TblUserDataDetail tblUserDetail)
        {

            _flightApplicationDBContext.Entry(tblUserDetail).State = EntityState.Modified;
            _flightApplicationDBContext.SaveChanges();
            return new OkResult();
        }


        [HttpDelete]
        [Route("DeleteUserDetails")]
        public IActionResult DeleteUserDetails(int UserId)
        {

            var userId = _flightApplicationDBContext.TblUserDataDetails.Find(UserId);
            _flightApplicationDBContext.TblUserDataDetails.Remove(userId);
            _flightApplicationDBContext.SaveChanges();
            return new OkResult();
        }


    }
}
