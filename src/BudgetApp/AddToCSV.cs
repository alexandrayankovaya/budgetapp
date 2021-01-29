using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;

namespace BudgetApp
{
    public class AddToCSV
    {
        private const string delimeter = ",";

        public static void WriteLineToFile(string content, string filePath)
        {
            FileStream fileStream;
            if (string.IsNullOrEmpty(filePath))
            {
                filePath = "transactions.txt";
            }
            if (!File.Exists(filePath))
            {
                fileStream = File.Create(filePath);
            }
            else
            {
                fileStream = File.Open(filePath, FileMode.Append, FileAccess.Write);
            }

            StreamWriter fileWriter = new StreamWriter(fileStream);
            fileWriter.WriteLine(content);
            fileWriter.Flush();
            fileWriter.Close();
        }

        public static void CreateUserDataCSV(string content)
        {
            FileStream fileStream = File.Open(USERS, FileMode.Append, FileAccess.Write);
            StreamWriter fileWriter = new StreamWriter(fileStream);
            fileWriter.WriteLine(content);
            fileWriter.Flush();
            fileWriter.Close();
        }

        private const string USERS = @"users.txt";

       public static HashSet<string> ReadUserDataCSV()
        {
            string line;
            HashSet<string> Users = new HashSet<string>();
            // Read the file and display it line by line. 
            if (!File.Exists(USERS))
            {
                File.Create(USERS);
            }
            else
            {
                StreamReader file = new StreamReader(USERS);
                while ((line = file.ReadLine()) != null)
                {
                    Users.Add(line);
                }

                file.Close();
            }
            return Users; 
        }

        public static void UpdateUsersFile(string users)
        {
            File.WriteAllText(USERS, users);
        }

        public static void UpdateTransactionsFile(string file, string transactions)
        {
            File.WriteAllText(file, transactions);
        }
    } 
}