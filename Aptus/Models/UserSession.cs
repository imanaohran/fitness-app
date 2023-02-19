using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aptus.Data;
using SQLite;
using System.IO;

namespace Aptus

{
    [Table("usersession")]
    public static class UserSession
    {
        public static string Email { get; set; }
        public static string Username { get; set; }
        public static string Password { get; set; }
    }
}
