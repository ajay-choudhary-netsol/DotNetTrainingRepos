using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace NS.SMS.Data.Entities
{
    [Table("Students")]
    public class Student
    {
        
        [Key]
        public int StudentId { get; set; }

        [Column("StudentName",TypeName ="varchar(20)")]
        
        public string Name { get; set; }

        [NotMapped]
        public int Age { get; set; }

        public int CourseId { get; set; }

        [ForeignKey("CourseId")]
        public virtual Course Course { get; set; }
    }
}
