using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businesss.Abstract
{
    public interface IInstructorManager
    {

        void Add(Instructor ınstructor);

        void Delete(int InstructorId);

        List<Instructor> GetAll();

        Instructor GetById(int InstructorId);

        void Update(int instructorId, Instructor updatedInstructor);
    }
}
