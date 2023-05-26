using lastone.Helpers;
using lastone.models;
using lastone.models.CustomeModels;
using lastone.models.DBModels;
using lastone.repositories.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lastone.repositories.Services
{
    public class TeacherRepository : ITeacherRepository
    {
        public List<Teacher> GetTeachers()
        {
            AP351AteetPrajapatiEntities db = new AP351AteetPrajapatiEntities();
            return db.Teachers.ToList();
        }
        public TeacherModel GetTeacherByID(int id)
        {
            AP351AteetPrajapatiEntities db = new AP351AteetPrajapatiEntities();
            TeacherModel teacherModel = CommonHeplers.BindToTeacher(db.Teachers.Find(id));

            teacherModel.TeacherSubjects = (from ST in db.TeacherSubjects
                                            where ST.TeacherId == id
                                            select ST.SubjectId).ToList();
            return teacherModel;
        }
        public bool AddTeacher(TeacherModel teacherModel)
        {
            AP351AteetPrajapatiEntities db = new AP351AteetPrajapatiEntities();
            try
            {
                Teacher teacher = CommonHeplers.BindToTeacherModel(teacherModel);
                db.Teachers.Add(teacher);
                db.SaveChanges();
                foreach (var tech in teacherModel.TeacherSubjects)
                {
                    db.TeacherSubjects.Add(new TeacherSubject() { TeacherId = teacher.Id, SubjectId = tech });
                }
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }


    }
}
