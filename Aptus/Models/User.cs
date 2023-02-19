using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aptus.Data;
using SQLite;
using System.IO;

namespace Aptus.Models
{
    [Table("users")]
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Username { get; set; }
        [Unique]
        public string Email { get; set; }
        public string Password { get; set; }
    }

}
