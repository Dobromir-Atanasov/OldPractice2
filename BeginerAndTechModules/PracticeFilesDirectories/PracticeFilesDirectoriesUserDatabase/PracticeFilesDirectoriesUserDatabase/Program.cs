using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PracticeFilesDirectoriesUserDatabase
{
    class Program
    {
        public static Dictionary<string, string> loginInfo = new Dictionary<string,string>();
        public static Dictionary<string, string> logedUsers = new Dictionary<string,string>();
        static void Main(string[] args)
        {
            InputDataFromConsole();
            AddUsersToLogFile();
        }
        static void AddUsersToLogFile()
        {
            List<string> outputData = new List<string>();
            foreach (var user in logedUsers)
            {
                outputData.Add("user: " + user.Key + " <=> pass: " + user.Value);
            }
            File.AppendAllLines("users.txt", outputData);
        }
        static void InputDataFromConsole()
        {
            string input = Console.ReadLine();
            while (input != "exit")
            {
                string[] tokens = input.Split(' ').ToArray();
                switch (tokens[0])
                {
                    case "register":
                        Register(tokens);
                        break;
                    case "login":
                        Login(tokens);
                        break;
                    case "logout":
                        Logout();
                        break;
                    default:
                        break;
                }
                input = Console.ReadLine();
            }
        }
        static void Logout()
        {
            if (logedUsers.Count>0)
            {
                logedUsers.Clear();
            }
            else
            {
                Console.WriteLine("There is no currently logged in user.");
            }
        }
        static void Login(string[] tokens)
        {
            string userName = tokens[1];
            string userPass = tokens[2];
            if (logedUsers.ContainsKey(userName))
            {
                Console.WriteLine("There is already a logged in user.");
            }
            else if (!loginInfo.ContainsKey(userName))
            {
                Console.WriteLine("There is no user with the given username.");
            }
            else if (loginInfo[userName]!=userPass)
            {
                Console.WriteLine("The password you entered is incorrect.");
            }
            else
            {
                logedUsers.Add(userName, userPass);
            }
        }
        static void Register(string[] tokens)
        {
            string userName = tokens[1];
            string userPass = tokens[2];
            string confirmPass = tokens[3];
            if (loginInfo.ContainsKey(userName))
            {
                Console.WriteLine("The given username already exists.");
            }
            else if (userPass!=confirmPass)
            {
                Console.WriteLine("The two passwords must match.");
            }
            else
            {
                loginInfo.Add(userName, userPass);
            }
        }
    }
}
