using AspMongo.Models;
using AspMongo.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AspMongo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]    
    public class StudentController : ControllerBase
    {
        private readonly DBServices _dBServices;
        public StudentController(DBServices dBServices)
        {
            _dBServices = dBServices;

        }
        [HttpGet]
        public ActionResult<List<Student>> Get() =>
            _dBServices.Get();

        [HttpPost]
        public ActionResult<Student> Create(Student stu)
        {
            _dBServices.Create(stu);
            return stu;
        }
    }
}