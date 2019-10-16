using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiDemo.Models;

namespace WebApiDemo.Data
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetAll();
        Student GetStudentById(int Id);
    }
}
