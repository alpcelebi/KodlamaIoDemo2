using Businesss.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businesss.Concrete
{
    public class InstructorManager : IInstructorManager
    {   

        private readonly IInstructorDal _instructors;

        public InstructorManager()
        {
            
        }

        public InstructorManager(IInstructorDal instructorDal)
        {
             _instructors = instructorDal;
        }



        public void Add(Instructor ınstructor)
        {
            _instructors.Add(ınstructor);


        }

        public void Delete(int InstructorId)
        {
            _instructors.Delete(InstructorId);
          
        }

        public List<Instructor> GetAll()
        {
            _instructors.GetAll();

            return null;
        }

        public Instructor GetById(int InstructorId)
        {
            _instructors.GetById(InstructorId);

            if (GetById ==null )
            {
                Console.WriteLine("Belirtilen Id bulunamadı");
            }

            return null;
        }

        public void Update(int instructorId, Instructor updatedInstructor)
        {

            _instructors.Update(instructorId, updatedInstructor);
        }
    }
}
