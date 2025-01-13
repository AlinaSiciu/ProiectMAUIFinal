using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectMAUIFinal.Models
{
    public class Instructor
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [MaxLength(30), Unique]
        public string Nume { get; set; }
        public string Specializare { get; set; }
    }
}
