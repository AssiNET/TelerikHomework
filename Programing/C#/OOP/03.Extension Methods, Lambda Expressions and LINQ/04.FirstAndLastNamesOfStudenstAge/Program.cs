﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.


namespace _04.FirstAndLastNamesOfStudenstAge
{
    class Program
    {
        static void Main(string[] args)
        {
            students Kiro = new students("Kiril", "Daskalov", 6);
            students Go6o = new students("Go6ko", "Petrov", 18);
            students Rami = new students("Rami", "Popov", 24);

            List<students> all = new List<students>();

            all.Add(Kiro);
            all.Add(Go6o);
            all.Add(Rami);

            var newList = from names in all where names.Age > 17 && names.Age < 25 select names;

            foreach (var item in newList)
            {
                Console.WriteLine(item.FirstName);
            }
        }
    }
}
