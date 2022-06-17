using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace GranjaSQLite.Models
{
    public class Animal
    {
        [PrimaryKey,AutoIncrement]
        public int IdAnimal { get; set; }
        [MaxLength (50)]
        public string NameAnimal { get; set; }
        public  int IdTipo { get; set; } 
    }
}
