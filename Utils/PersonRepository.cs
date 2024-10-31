using jdiazS5B.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jdiazS5B.Utils
{
    public class PersonRepository
    {
        string dbPath;
        private SQLiteConnection conn;
        public string status { get; set; }

        public PersonRepository(string path) { 
        dbPath = path;
        }

        public void Init()
        {
            if (conn == null) 
                return;
            conn = new (dbPath);
            conn.CreateTable<Persona>();
        }

        public void AddNewPerson(string name)
        {
            int result = 0;
            try
            {
                Init();
                if (string.IsNullOrEmpty(name))
                    throw new Exception("El nombre es requerido");

                Persona person = new() { Name = name };
                result = conn.Insert(person);
                status = string.Format("Dato ingresado");
            }
            catch (Exception)
            {

                status = string.Format("Error al ingresar");
            }
        }

        public List<Persona> GetALLPeople()
        {
            try
            {
                Init();
                return conn.Table<Persona>().ToList();
            }
            catch (Exception ex)
            {

                status = string.Format("Error al listar");

            }
            return new List<Persona>();
        }
    }
}
