using lastone.models;
using lastone.models.CustomeModels;
using lastone.models.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lastone.repositories.Repos
{
    public interface ITeacherRepository
    {
        List<Teacher> GetTeachers();
        bool AddTeacher(TeacherModel teacherModel);
        TeacherModel GetTeacherByID(int id);
    }
}
