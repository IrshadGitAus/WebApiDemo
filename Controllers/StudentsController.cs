using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiDemo.Data;
using WebApiDemo.Models;

namespace WebApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private IStudentRepository _respository = new StudentRepository();

        public StudentsController()
        {
           
        }


        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return _respository.GetAll();
            
        }

    }

   
}