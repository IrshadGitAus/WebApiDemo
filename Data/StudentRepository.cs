using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiDemo.Models;

namespace WebApiDemo.Data
{
    public class StudentRepository : IStudentRepository
    {
        public IEnumerable<Student> GetAll()
        {
            return GetStudentsFromDB();
        }

        public Student GetStudentById(int Id)
        {
            Student _student;

            _student =  GetStudentsFromDB().FirstOrDefault(s => s.Id == Id);

            return _student;
           
        }


        private IEnumerable<Student> GetStudentsFromDB()
        {
            List<Student> students = new List<Student>()
            {
                new Student
                {
                    Id=1,
                    FullName="John Smith",
                    GPA=3.5
                },
                new Student
                {
                    Id=2,
                    FullName="Jimmy Wright",
                    GPA=3.9
                }
            };

            return students;

        }

    }
}
