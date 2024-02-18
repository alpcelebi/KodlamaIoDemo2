using Data.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Conrete
{
    public class CourseDal : ICourseDal
    {

        List<Course> _courses;

        public CourseDal()
        {
            _courses = new List<Course>();
            
        }
        public void Add(Course course)
        {
            _courses.Add(course);   
        }

        public void Delete(int courseId)
        {
             Course courseToDelete = null;

            foreach (var course in _courses)
            {
                if (course.CourseId==courseId)
                {
                    courseToDelete = course;    
                    break;
                }

                if (courseToDelete != null)
                {
                    _courses.Remove(courseToDelete);

                    Console.WriteLine("Kurs silindi");

                }

                else {
                    
                    Console.WriteLine("Kurs bulunamadı"); }

            }
        }

        public List<Course> GetAll()
        {
            foreach (Course course  in _courses)
            {
                Console.WriteLine("Kurslar listelendi" + "--" + course.CourseName);    
            }
            return _courses;
        }

        public Course GetById(int id)
        {
            foreach (Course course in _courses)
            {
                if (course.CourseId == id)
                {

                    Console.WriteLine(course.CourseName+"--"+ "isimli kurs bulundu");

                    return course;
                }

               
            }

            Console.WriteLine("Kurs Bulunamadı");

            return null;
        }

        public void Update(int courseId, Course updatedCourse)
        {
            foreach (Course course in _courses)
            {
                if (course.CourseId==courseId)
                {
                    course.CourseName = updatedCourse.CourseName;

                    Console.WriteLine("Kurs başarıyla güncellendi");

                    return;
                }
            }

            Console.WriteLine("Kurs bulunamadı");
            
        }
    }
}
