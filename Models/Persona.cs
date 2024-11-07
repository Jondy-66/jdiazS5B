using System;
using SQLite;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jdiazS5B.Models
{
    [Table("persona")]
    public class Persona
    {
        [PrimaryKey, AutoIncrement]
        public int Id {  get; set; } //1,2,3,4
        [MaxLength(25)]

        public string Name { get; set; }
    }
}
