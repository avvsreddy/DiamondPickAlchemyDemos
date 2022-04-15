using DoctorManager;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Doctor.API.Controllers
{

   

    [Route("api/[controller]")]
    [ApiController]
    public class DoctorsController : ControllerBase
    {
        private readonly DoctorsManager dMgr;

        public DoctorsController(DoctorsManager dMgr)
        {
            this.dMgr = dMgr;
        }

        [HttpGet]
        public IActionResult GetDoctors()
        {
            var doctorsDto = dMgr.GetDoctors();
            if (doctorsDto == null)
                return NotFound();
            return Ok(doctorsDto);
        }
    }
}
