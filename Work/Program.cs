


using System;
using Businesss.Concrete;
using Data.Conrete;
using Entities.Concrete;



class Program
{
    static void Main(string[] args)
    {
        // Uygulamanızın başlangıç noktası
        CategoryManager categoryManager = new CategoryManager(new CategoryDal());
        CourseManager courseManager = new CourseManager(new CourseDal());
        InstructorManager instructorManager = new InstructorManager(new InstructorDal());

        categoryManager.GetAll();
        categoryManager.GetById(1);
        categoryManager.GetAll();
        Category updatedCategory = new Category(1, "Yeni Kategori");
        categoryManager.Update(1, updatedCategory);
        categoryManager.GetAll();
        categoryManager.Delete(1);

        Console.WriteLine("-----------------------------------------------------------------");


        Console.WriteLine("Kurslara ait işlemler: ");
        courseManager.GetAll();
        courseManager.GetById(2);
        courseManager.Delete(1);
        Course updatedCourse = new Course(3, " C# Kampı");
        courseManager.Update(3, updatedCourse);
        courseManager.GetAll();

        Console.WriteLine("-----------------------------------------------------------------");


        instructorManager.GetAll();
        instructorManager.GetById(1);
        Instructor updatedInstructor = new Instructor(2, "Halit Kalaycı");
        instructorManager.Update(1, updatedInstructor);
        instructorManager.Delete(1);
        Console.WriteLine("Silinen ve güncellenen eğitmenler sonrası güncel liste hali: ");
        instructorManager.GetAll();
    }
}

