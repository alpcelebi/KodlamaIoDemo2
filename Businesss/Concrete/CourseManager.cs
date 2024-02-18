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
    public class CourseManager : ICourseManager
    {   
        private readonly ICourseDal _courseDal;

        public CourseManager()
        {
            
        }

        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }
        public void Add(Course course)
        {
            _courseDal.Add(course);

            if (course.CourseId==0)
            {
                Console.WriteLine("İd 0 olamaz");
            }
        }

        public void Delete(int courseId)
        {
            _courseDal.Delete(courseId);

            Console.WriteLine("Kurs silme işlemi gerçekleşti");

        }

        public List<Course> GetAll()
        {
            _courseDal.GetAll();

            return null;

        }

        public Course GetById(int Id)
        {
            _courseDal.GetById(Id);
            if (GetById==null) 
            {
                Console.WriteLine("Geçersiz id girişi");
            }

            return null;
        }

        public void Update(int courseId, Course updatedCourse)
        {
          _courseDal.Update(courseId,updatedCourse);
        }
    }
}
