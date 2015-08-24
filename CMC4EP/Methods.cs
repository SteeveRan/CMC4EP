using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Xml;

namespace CMC4EP
{
    class Methods
    {
        //public static Users SetAutoRise (string url, string request)
        //{
        //    HttpWebRequest setprequest = (HttpWebRequest)WebRequest.Create(url); //url - Адрес
        //    setprequest.ContentType = @"text/xml;charset=""utf-8""";
        //    setprequest.ServicePoint.Expect100Continue = false;
        //    setprequest.Method = "POST";
        //    setprequest.KeepAlive = true;

        //    byte[] data = Encoding.UTF8.GetBytes(request); //request - сообщение
        //    Stream requestStream = setprequest.GetRequestStream();
        //    requestStream.Write(data, 0, data.Length);
        //    requestStream.Close();
        //    HttpWebResponse response = (HttpWebResponse)setprequest.GetResponse();
        //    StreamReader sr = new StreamReader(response.GetResponseStream());
        //    WebHeaderCollection header = response.Headers; //нужны заголовки ответ

        //    String answerBody = sr.ReadToEnd();

        //    XmlDocument doc = new XmlDocument();
        //    doc.LoadXml(answerBody);

        //    string name = doc.GetElementsByTagName("name")[0].InnerText;
        //    int id = Int32.Parse(doc.GetElementsByTagName("id")[0].InnerText);
        //    User.Auth = getHeaderValueByName("Auth", response.Headers.ToString());

        //    Users user = new Users (name, id);

        //    return user;
        //}

        //public static string [] parser ()
        //{
            
        //}

        public static void SetAutoRise(string url, string request)
        {
            try
            {
                HttpWebRequest setprequest = (HttpWebRequest)WebRequest.Create(url); //url - Адрес
                setprequest.ContentType = @"text/xml;charset=""utf-8""";
                setprequest.ServicePoint.Expect100Continue = false;
                setprequest.Method = "POST";
                setprequest.KeepAlive = true;

                byte[] data = Encoding.UTF8.GetBytes(request); //request - сообщение
                Stream requestStream = setprequest.GetRequestStream();
                requestStream.Write(data, 0, data.Length);
                requestStream.Close();
                HttpWebResponse response = (HttpWebResponse)setprequest.GetResponse();
                StreamReader sr = new StreamReader(response.GetResponseStream());
                WebHeaderCollection header = response.Headers; //нужны заголовки ответ

                String answerBody = sr.ReadToEnd();

                XmlDocument doc = new XmlDocument();
                doc.LoadXml(answerBody);
                doc.Save("test.xml");
                string pp = "<response></response>";
                XmlDocument Res = new XmlDocument();
                Res.LoadXml(pp);

                if (Res != doc)
                {
                    User.Name = doc.GetElementsByTagName("name")[0].InnerText;
                    User.Id = Int32.Parse(doc.GetElementsByTagName("id")[0].InnerText);
                    User.Auth = getHeaderValueByName("Auth", response.Headers.ToString());
                }
                else
                {
                    MessageBox.Show("User not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static List<Users> GetUsers (string url, string request)
        {
            String answerBody = Pattern(url, request, true);

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(answerBody);
            List<Users> UserList = new List<Users>();

            XmlNodeList xnList = doc.SelectNodes("/response/user");
            foreach (XmlNode xn in xnList)
            {
                string name = xn["name"].InnerText;
                int id = Int32.Parse( xn["id"].InnerText);
                Users finduser = new Users (name,id );
                UserList.Add(finduser);
            }
            return UserList;
        }

        public static String Pattern(string url, string request, bool setmessage)
        {
            HttpWebRequest setprequest = (HttpWebRequest)WebRequest.Create(url); //url - Адрес
            setprequest.ContentType = @"text/xml;charset=""utf-8""";
            setprequest.ServicePoint.Expect100Continue = false;
            setprequest.Method = "POST";
            setprequest.Headers.Add("Auth: " + User.Auth);
            setprequest.KeepAlive = true;

            if (setmessage == true)
            {
                byte[] data = Encoding.UTF8.GetBytes(request); //message - сообщение
                Stream requestStream = setprequest.GetRequestStream();
                requestStream.Write(data, 0, data.Length);
                requestStream.Close();
            }

            HttpWebResponse response = (HttpWebResponse)setprequest.GetResponse();
            StreamReader sr = new StreamReader(response.GetResponseStream());

            String answerBody = sr.ReadToEnd();

            return answerBody;
        }

        public static List<Users> SearchUserList(string url)
        {
            String answerBody = Pattern(url, null, false);

            if (answerBody != "<response>\r\n</response>")
            {
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(answerBody);

                List<Users> UserList = new List<Users>();

                XmlNodeList xnList = doc.SelectNodes("/response/user");
                foreach (XmlNode xn in xnList)
                {
                    string name = xn["name"].InnerText;
                    int id = Int32.Parse(xn["id"].InnerText);
                    Users requestuser = new Users(name, id);
                    UserList.Add(requestuser);
                }
                return UserList;
            }
            else
            {
                return null;
            }
        }

        public static void AddAndDeleteFriends (string url,string request)
        {
            try
            {
                String answerBody = Pattern(url, request, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static int FindUserId(string url, string request)
        {
            try
            {
                String answerBody = Pattern(url, request, true);

                XmlDocument doc = new XmlDocument();
                doc.LoadXml(answerBody);

                int id = Int32.Parse(doc.GetElementsByTagName("id")[0].InnerText);
                return id;
            }
            catch (WebException e) { MessageBox.Show(e.Status.ToString()); }
            catch (Exception e) { MessageBox.Show(e.Message); }
            return 0;
        }

        public static List<Messages> GetMessage(string url, string request)
        {
            String answerBody = Pattern(url, request, true);

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(answerBody);
            List<Messages> messageslist = new List<Messages>();
            XmlNodeList xnList = doc.SelectNodes("/response/message");

            foreach (XmlNode xn in xnList)
            {
                string data = xn["text"].InnerText;
                int id = Int32.Parse( xn["from"].InnerText);
                Messages message = new Messages ( data,id);
                messageslist.Add(message);
            }

            return messageslist;
        }

        public static string SendMessage(string url, string request)
        {
            try
            {
                String answerBody = Pattern(url, request, true);

                XmlDocument doc = new XmlDocument();
                doc.LoadXml(answerBody);

                string s = doc.GetElementsByTagName("message")[0].InnerText;
                return s;

            }
            catch (WebException e) { MessageBox.Show(e.Status.ToString()); }
            catch (Exception e) { MessageBox.Show(e.Message); }
            return null;
        }

        public static string getHeaderValueByName(String headerName, String headers)
        {
            /* Praise the Void ! */

            String[] headerList = Regex.Split(headers, Environment.NewLine);

            Boolean found = false;
            String f = "";

            foreach (String s in headerList)
            {
                if (s.StartsWith(headerName + ": "))
                {
                    found = true;
                    f = Regex.Split(s, ": ")[1];
                }
            }

            if (found) { return f; } else { return string.Empty; };
        }
    }
}
