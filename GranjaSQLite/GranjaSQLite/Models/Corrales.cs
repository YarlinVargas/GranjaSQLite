using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace GranjaSQLite.Models
{
    public class Corrales
    {
        [PrimaryKey, AutoIncrement]
        public int IdCorral { get; set; }
        [MaxLength(50)]
        public string Tipo { get; set; }

        public float Capacidad { get; set; }

        public int IdAnimal { get; set; }
    }
}
