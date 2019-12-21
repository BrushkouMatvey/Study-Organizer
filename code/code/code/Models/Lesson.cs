using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace code.Models
{
    public class Lesson
    {
        [PrimaryKey, AutoIncrement]
        public int Class { get; set; }
        public string TeacherName { get; set; }
        public int ID { get; set; }
    }
}
