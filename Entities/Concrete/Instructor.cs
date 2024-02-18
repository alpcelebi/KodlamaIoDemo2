using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Instructor
    {

        public Instructor(int instructorId, string instructorName)
        {
            InstructorId= instructorId;
            InstructorName= instructorName;
            
        }
        public int InstructorId { get; set; }

        public string InstructorName { get; set; }

    }
}
