using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace IOWorks.models
{
    public class IOClient
    {
        #region updateStudentsScores
        public void UpgradeScores(string path)
        {
            var newPath = "updatedlist.txt";

            if (!File.Exists(newPath))
            {
                File.Create(newPath);
            }

            foreach (var student in File.ReadAllLines(path))
            {
                string[] eachStudent = student.Split("-");
                int score = int.Parse(eachStudent[1]);

                if (score > 50)
                {
                    score += 5;
                }
                else
                {
                    score += 10;
                }

                var finalStudent = $"{eachStudent[0]} -     {score}";

                File.AppendAllLines(newPath, new string[] { finalStudent });
            }
            Console.WriteLine("Students scores has ben successfully updated");
        }

        public string ComputeScores(Dictionary<string, int> studentsInfo)
        {
            var path = "studentgrades.txt";

            if (!File.Exists(path))
            {
                File.Create(path);
            }

            string[] studentsGrades = new string[20];
            var studentCatalog = "";

            foreach (var student in studentsInfo)
            {
                studentCatalog = $"{student.Key.ToUpper()}-{student.Value}";
                File.AppendAllLines(path, new string[] { studentCatalog });
            }

            return path;
        }
        #endregion

        #region TimeUpdate

        public void LogFile()
        {
            var path = "timelog.txt";
            var myStack = new Stack<string>();

            //if (!File.Exists(path))
            //{
            //    File.Create(path);
            //}

            var counter = 0;
            while (counter < 10)
            {
                Thread.Sleep(10000);

                var time = DateTime.UtcNow;
                myStack.Push($"The time is {time.ToString()}");

                counter++;
            }

            try
            {
                addToFile(myStack, path);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public void addToFile(Stack<string> arg, string path)
        {
            while (arg.Count > 0)
            {
                File.AppendAllLines(path, new string[] { arg.Pop().ToString() });
            }

            Console.WriteLine("Finished logging the time data");
        }
        #endregion
    }
}