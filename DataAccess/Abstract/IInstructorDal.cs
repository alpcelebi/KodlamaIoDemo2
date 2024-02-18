using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IInstructorDal
    {
        void Add(Instructor instructor);
        void Delete(int instructorId);
        List<Instructor> GetAll();
        Instructor GetById(int id);
        void Update(int instructorId, Instructor updatedInstructor);
    }
}
