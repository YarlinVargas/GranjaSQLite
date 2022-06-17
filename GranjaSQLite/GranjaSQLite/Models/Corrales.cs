using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace GranjaSQLite.Models
{
    public class Corrales
    {
        [PrimaryKey, AutoIncrement]
        public int idCorral { get; set; }
        [MaxLength(50)]
        public string tipo { get; set; }

        public float capacidad { get; set; }
    }
}
