using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMC4EP
{
    public class User
    {
        public static string Name { get; set; }
        public static int Id { get; set; }
        public static string Auth { get; set; }
    }

    public class Users
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public static string Auth { get; set; }
        public Users(string name, int id)
        {
            Name = name;
            Id = id;
        }
    }

    public class Messages
    {
        public string Data { get; set; }
        public int Id { get; set; }
        public Messages(string data, int id)
        {
            Data = data;
            Id = id;
        }
    }

    public class Buffer
    {
        public static int Id { get; set; }
    }
}
