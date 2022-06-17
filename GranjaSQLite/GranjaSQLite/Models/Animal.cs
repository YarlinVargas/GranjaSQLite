using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace GranjaSQLite.Models
{
    public class Animal
    {
        [PrimaryKey,AutoIncrement]
        public int idAnimal { get; set; }
        [MaxLength (50)]
        public string nameAnimal { get; set; }
    }
}
