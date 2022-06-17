using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using GranjaSQLite.Models;
using System.Threading.Tasks;

namespace GranjaSQLite.Data
{
    public class SQLiteHelper
    {
        SQLiteAsyncConnection db;
        public SQLiteHelper(string dbPath)
        {
            db = new SQLiteAsyncConnection(dbPath);
            db.CreateTableAsync<Animal>().Wait();
        }
        //Preparar tarea para guardar registros
        public Task <int> SaveAnimalAsync (Animal animal)
        {
            if (animal.idAnimal == 0)
            {
                return db.InsertAsync(animal);
            }
            else{
                return null;
            }
        }
        /// <summary>
        /// Recuperar todos los animales
        /// </summary>
        /// <returns></returns>
        public  Task <List<Animal>> getAnimalAsync()
        {
            return db.Table<Animal>().ToListAsync();
        }
        /// <summary>
        /// Recupera animales por id
        /// </summary>
        /// <param name="idAnimal">Id del animal que se requiere</param>
        /// <returns></returns>
        public Task <Animal> GetAnimalByIdAsync( int idAnimal)
        {
            return db.Table<Animal>().Where(a => a.idAnimal == idAnimal).FirstOrDefaultAsync();
        }
    }
}
