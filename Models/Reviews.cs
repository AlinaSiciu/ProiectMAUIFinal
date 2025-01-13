using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace ProiectMAUIFinal.Models
{
    public class Reviews
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        [MaxLength(500), Unique]
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public int CalID { get; set; }
        public int InstructorID { get; set; }

    }
}
