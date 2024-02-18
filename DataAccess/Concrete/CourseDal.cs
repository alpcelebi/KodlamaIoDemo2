using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class CourseDal : ICourseDal
    {
        List<Course> courses;

        public CourseDal()
        {
            courses = new List<Course>();

            courses.Add(new Course(1, "Senior Yazılım Geliştirme Kampı"));
            courses.Add(new Course(2, "C# Yazılım Geliştirici Geliştirme Kampı"));
            courses.Add(new Course(3, "Python Yazılım Geliştirici Geliştirme Kampı"));
            courses.Add(new Course(4, "Java Yazılım Geliştirici Geliştirme Kampı"));
            courses.Add(new Course(5, "JavaScript Yazılım Geliştirici Geliştirme Kampı"));
        }

        public void Add(Course course)
        {
            courses.Add(course);
        }

        public void Delete(int courseId)
        {
            Course courseToDelete = null;
            foreach (Course course in courses)
            {
                if (course.CourseId == courseId)
                {
                    courseToDelete = course;
                    break; 
                }
            }

            if (courseToDelete != null)
            {
                courses.Remove(courseToDelete);
                Console.WriteLine("Kurs başarıyla silindi.");
            }
            else
            {
                Console.WriteLine("Belirtilen ID'ye sahip bir kurs bulunamadı.");
            }
        }

        public List<Course> GetAll()
        {
            foreach (Course course in courses)
            {
                Console.WriteLine("Kurslar listelendi: " + course.CourseName);
            }
            return courses;
        }

        public Course GetById(int id)
        {
            foreach (Course course in courses)
            {
                if (course.CourseId == id)
                {
                    Console.WriteLine(course.CourseName + "isimli kurs bulundu.");
                }
            }
            return null;
        }


        public void Update(int courseId, Course updatedCourse)
        {
            foreach (Course course in courses)
            {
                if (course.CourseId == updatedCourse.CourseId)
                {
                    course.CourseName = updatedCourse.CourseName;
                    Console.WriteLine("Kurs başarıyla güncellendi.");
                    return;
                }
            }
            Console.WriteLine("Belirtilen ID'ye sahip bir kurs bulunamadı.");
        }
    }
}
