using Data.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Conrete
{
    public class InstructorDal : IInstructorDal
    {
        List<Instructor> _instructors;

        public InstructorDal()
        {
            _instructors = new List<Instructor>();  
        }

        public void Add(Instructor instructor)
        {
            _instructors.Add(instructor);
        }

        public void Delete(int instructorId)
        {
            Instructor instructorToDelete = null;

            foreach (var instructor in _instructors)
            {
                if (instructor.InstructorId==instructorId)
                {
                    _instructors.Remove(instructor);

                    Console.WriteLine("Eğitmen Silindi");

                    break;
                }

                if (instructorToDelete!=null)
                {
                    _instructors.Remove(instructorToDelete);

                    Console.WriteLine("Eğitmen Silindi");

                }

                else
                {
                    Console.WriteLine("İşlem basarısız");

                }

            }
        }

        public List<Instructor> GetAll()
        {
            foreach ( Instructor instructor in _instructors)
            {
                Console.WriteLine("Eğitmenler listelendi" + "--" + instructor.InstructorName);
            }

            return _instructors;
        }

        public Instructor GetById(int id)
        {
            foreach (Instructor instructor in _instructors)
            {
                if (instructor.InstructorId==id)
                {
                    Console.WriteLine(instructor.InstructorName);

                    return instructor;
                }
            }

            Console.WriteLine("Eğitmen bulunamadı");
            return null ;
        }

        public void Update(int instructorId, Instructor updatedInstructor)
        {
            foreach (Instructor instructor  in _instructors)
            {
                if (instructor.InstructorId == instructorId)
                {
                   instructor.InstructorName = updatedInstructor.InstructorName;

                    Console.WriteLine("Eğitmen güncellendi");

                    return;
                }
                
            }

            Console.WriteLine("Eğitmen Bulunamadı");
           
        }
    }
}
