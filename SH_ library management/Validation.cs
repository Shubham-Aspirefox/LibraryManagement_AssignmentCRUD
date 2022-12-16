using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment
{
    public class Validation
    {
        public string CheckName(string name)
        {
            string regex = @"^[a-zA-Z]+[a-zA-Z\s]+$";
            Regex re = new Regex(regex);
            if (re.IsMatch(name))
            {
                return name;
            }
            string fname = "";
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter Correct Name: ");
                string tempName = Console.ReadLine();
                if (re.IsMatch(tempName))
                {
                    fname = tempName;
                    flag = false;

                }
            }
            return fname;
        }
        public string CheckEmail(string email)
        {
            string regex = @"^[^_-][a-z0-9.A-Z]+@[a-z]+\.[a-z]{2,5}";
            Regex re = new Regex(regex);


            if (re.IsMatch(email))
            {
                return email;
            }
            string finalEmail = "";
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter Correct Email Again: ");
                string newEmail = Console.ReadLine();
                if (re.IsMatch(newEmail))
                {
                    finalEmail = newEmail;
                    flag = false;
                }
            }
            return finalEmail;
        }

        public String CheckDate(string date)
        {
            bool flag = true;
            string finalDate = "vv";
            while (flag)
            {
                string[] format = { "MM/dd/yyyy" };
                DateTime prevDate;
                DateTime.TryParseExact(date, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out prevDate);

                var today = DateTime.Now;

                var diff = today - prevDate; // gives result in timespan

                int year = diff.Days / 365;

                if (year < 18 || year > 61)
                {
                    Console.WriteLine("Please enter age between 18 and 60 : (MM / dd / yyyy)");
                    date = Console.ReadLine();
                }
                else
                {
                    flag = false;
                    finalDate = prevDate.ToString();
                }

            }
            return finalDate.Substring(0, finalDate.Length - 9);

        }

        public double checkSalary()
        {
            double salary = 0;
            bool flag = true;
            while (flag)
            {
                try
                {
                    Console.WriteLine("\nEnter Salary: ");
                    salary = double.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("\nInvalid Input!");
                }
            }


            return salary;

        }

    }
}
