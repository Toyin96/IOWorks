using System;
using System.Collections.Generic;
using IOWorks.models;

namespace IOWorks
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> students = new Dictionary<string, int>();
            students.Add("toyin", 64);
            students.Add("seun", 20);
            students.Add("bayo", 50);
            students.Add("dan", 23);
            students.Add("gbenga", 65);
            students.Add("joy", 74);
            students.Add("toyib", 81);
            students.Add("amaka", 49);
            students.Add("tosin", 20);
            students.Add("ebuka", 28);
            students.Add("ifeanyi", 15);
            students.Add("lanre", 69);
            students.Add("chidi", 45);
            students.Add("hamdan", 49);
            students.Add("chibuzo", 10);
            students.Add("kunle", 64);
            students.Add("tunde", 46);
            students.Add("chinenye", 31);
            students.Add("chinelo", 39);
            students.Add("ujunwa", 50);

            IOClient ioClient = new IOClient();
            var path = ioClient.ComputeScores(students);
            ioClient.UpgradeScores(path);

            ioClient.LogFile();
        }
    }
}