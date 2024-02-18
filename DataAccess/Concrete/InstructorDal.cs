using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class InstructorDal : IInstructorDal
    {
        List<Instructor> instructors;
        public InstructorDal()
        {
            instructors = new List<Instructor>();

            instructors.Add(new Instructor(1, "Engin Demiroğ"));
            instructors.Add(new Instructor(2, "Halit Enes Kalaycı"));
        }

        public void Add(Instructor instructor)
        {
            instructors.Add(instructor);
        }

        public void Delete(int instructorId)
        {
            Instructor instructorToDelete = null;
            foreach (Instructor instructor in instructors)
            {
                if (instructor.InstructorId == instructorId)
                {
                    instructorToDelete = instructor;
                    break; 
                }
            }

            if (instructorToDelete != null)
            {
                instructors.Remove(instructorToDelete);
                Console.WriteLine("Eğitmen başarıyla silindi.");
            }
            else
            {
                Console.WriteLine("Belirtilen ID'ye sahip bir eğitmen bulunamadı.");
            }
        }
        public List<Instructor> GetAll()
        {
            foreach (Instructor instructor in instructors)
            {
                Console.WriteLine("Eğitmenler listelendi: " + instructor.InstructorName);
            }
            return instructors;
        }

        public Instructor GetById(int id)
        {
            foreach (Instructor instructor in instructors)
            {
                if (instructor.InstructorId == id)
                {
                    Console.WriteLine(instructor.InstructorName + " isimli eğitmen bulundu");

                }
            }
            return null;
        }

        public void Update(int instructorId, Instructor updatedInstructor)
        {
            foreach (Instructor instructor in instructors)
            {
                if (instructor.InstructorId == instructorId)
                {
                    instructor.InstructorName = updatedInstructor.InstructorName;
                    Console.WriteLine("Eğitmen başarıyla güncellendi.");
                    return;
                }
            }
            Console.WriteLine("Belirtilen ID'ye sahip bir eğitmen bulunamadı.");
        }
    }
}
