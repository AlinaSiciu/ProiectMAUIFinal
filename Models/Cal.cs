using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectMAUIFinal.Models
{
    public class Cal
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [MaxLength(20), Unique]
        public string Nume { get; set; }
        public string Rasa { get; set; }
    }
}
