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
    }
}
