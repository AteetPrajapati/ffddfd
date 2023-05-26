using lastone.models;
using lastone.models.CustomeModels;
using lastone.models.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lastone.Helpers
{
    public class CommonHeplers
    {
        public static Teacher BindToTeacherModel(TeacherModel teacherModel)
        {
            return new Teacher()
            {
                Id = teacherModel.Id,
                FirstName = teacherModel.FirstName,
                LastName = teacherModel.LastName,
                Email = teacherModel.Email,
                Geneder = teacherModel.Geneder,
                MobileNo = teacherModel.MobileNo,
                Address = teacherModel.Address,
                City = teacherModel.City,
                State = teacherModel.State,
                Country = teacherModel.Country
            };
        }

        public static TeacherModel BindToTeacher(Teacher teacher)
        {
            return new TeacherModel()
            {
                Id = teacher.Id,
                FirstName = teacher.FirstName,
                LastName = teacher.LastName,
                Email = teacher.Email,
                Geneder = teacher.Geneder,
                MobileNo = teacher.MobileNo,
                Address = teacher.Address,
                City = teacher.City,
                State = teacher.State,
                Country = teacher.Country
            };
        }
    }
}
