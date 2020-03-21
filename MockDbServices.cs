using Cw3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cw3.Controllers.Services
{
    public class MockDbServices : IdbServices
    {
        public static IEnumerable<Student> _students = new List<Student>
        {
            new Student{IdStudent=1, FirstName="Jan", LastName="Kowalski", IndexNumber="s1234"},
            new Student{IdStudent=2, FirstName="Jan", LastName="Nowak", IndexNumber="s567"},
            new Student{IdStudent=3, FirstName="Jan", LastName="XXX", IndexNumber="s3455"}
        };

        public IEnumerable<Student> GetStudents()
        {
            return _students;
        }

        
    }
}
