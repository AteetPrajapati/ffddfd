//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace lastone.models.DBModels
{
    using System;
    using System.Collections.Generic;
    
    public partial class StudentTeachersSubject
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int TeacherId { get; set; }
        public int TeacherSubjectsId { get; set; }
    
        public virtual Student Student { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
