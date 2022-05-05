using System;
using System.Data.Linq.Mapping;

namespace SuperChat.Model
{
    [Table(Name = "SCHOOL_STUDENTS_TBL")]
    public class StudentInformation
    {

        [Column(Name = "ID", IsPrimaryKey = true)]
        public int ID { get; set; }
        [Column(Name = "NAME")]
        public String Name { get; set; }
        [Column(Name = "GENDER")]
        public String Gender { get; set; }
        [Column(Name = "AGE")]
        public int Age { get; set; }
        [Column(Name = "COURSE")]
        public String Course { get; set; }
    }
}
