

using Businesss.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using Businesss.Abstract;


CategoryManager categoryManager = new CategoryManager(new CategoryDal());
CourseManager courseManager = new CourseManager(new CourseDal());
InstructorManager instructorManager = new InstructorManager(new InstructorDal());

Console.WriteLine("Kategoriye ait işlemler: ");
categoryManager.GetAll();
categoryManager.GetById(1);
categoryManager.GetAll();
Category updatedCategory = new Category(1, "Yeni Programlama Kategorisi");
categoryManager.Update(1, updatedCategory);
Console.WriteLine("Güncellemden sonra Kategori Listesi");
categoryManager.GetAll();
categoryManager.Delete(1);


Console.WriteLine("-----------------------------------------");

Console.WriteLine("Kurslara ait işlemler: ");
courseManager.GetAll();
courseManager.GetById(2);
courseManager.Delete(1);
Course updatedCourse = new Course(3, "Gladyatör C# Kampı");
courseManager.Update(3, updatedCourse);
Console.WriteLine("Silinen ve güncellenen kurslardan sonra güncel liste hali: ");
courseManager.GetAll();

Console.WriteLine("-----------------------------------------");



instructorManager.GetAll();
instructorManager.GetById(1);
Instructor updatedInstructor = new Instructor(2, "Halit Kalaycı");
instructorManager.Update(1, updatedInstructor);
instructorManager.Delete(1);
instructorManager.GetAll();
