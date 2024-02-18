using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businesss.Abstract
{
    public interface ICourseManager
    {
        void Add(Course course);

        void Delete(int courseId);

        List<Course> GetAll();

        Course GetById(int Id);

        void Update(int courseId, Course updatedCourse);

    }
}
