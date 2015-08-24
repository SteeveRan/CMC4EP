using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CMC4EP
{
    class HttpQuery
    {
        public static string url = "http://doomstal.com/zel/";

        public static void AutoRize (string login, string password)
        {
            string request = "<request><login>" + login + "</login><password>" + password + "</password></request>";
            Methods.SetAutoRise(url + "login", request);
        }

        public static void DeleteFriend (int id)
        {
            string request = "<request><id>" + id + "</id></request>";
            Methods.AddAndDeleteFriends(url + "deletefriend", request);
        }

        public static void AddFriend(int id)
        {
            string request = "<request><id>" + id + "</id></request>";
            Methods.AddAndDeleteFriends(url + "addfriend", request);
        }

        public static List<Users> GetUsers(string name)
        {
            string request = "<request><name>" + name + "</name></request>";
            List <Users> ret = Methods.GetUsers(url + "finduser", request);
            return ret;
        }

        public static int finduserid(string name)
        {
            string request = "<request><name>" + name + "</name></request>";
            return Methods.FindUserId(url + "userid", request);
        }

        public static List<Messages> GetMessage(int id)
        {
            string request = "<request><with>" + id + "</with></request>";
            return Methods.GetMessage(url + "getmessages", request);
        }

        public static string SendMessage(int id, string data)
        {
            string request = "<request><id>" + id + "</id><text>" + data + "</text></request>";

            return Methods.SendMessage(url + "sendmessage", request);
        }
    }
}
