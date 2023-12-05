using System;

namespace LambdaThings
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> names = new List<string>()
            //{
            //    "nika",
            //    "mari",
            //    "giorgi",
            //    "pavle",
            //    "andria"
            //};

            //foreach(string name in names)
            //{
            //    Console.WriteLine(name);
            //}

            //Console.WriteLine("---------------");

            //names.ForEach((string name) => Console.Write(name + " "));

            List<string> cities = new List<string>()
            {
                "D.C",
                "Paris",
                "Kuala-Lumpur",
                "Providence",
                "Tbilisi",
                "Ontario"
            };

            cities.ForEach((string name) => Console.WriteLine(AddHello(name)));

            static string AddHello(string name)
            {
                return $"{name}";
            }
        }
    }
}