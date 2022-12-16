using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class SearchEmp
    {
        List<Employee> searchEmp = new List<Employee>();

        public SearchEmp(List<Employee> searchEmp)
        {
            this.searchEmp = searchEmp;
        }


        public void searchEmail()
        {

            Console.WriteLine("Enter the Email: ");
            string email = Console.ReadLine();
            Validation v = new Validation();
            email = v.CheckEmail(email);
            bool mailFlag = false;

            List<Employee> temp = new List<Employee>();

            foreach (var item in searchEmp)
            {
                string currName = (item.Name).ToLower();
                email = email.ToLower();
                if (currName.Contains(email))
                {
                    mailFlag = true;

                    temp.Add(item);

                }
            }
            if (mailFlag == false)
            {
                Console.WriteLine("No Records !\n");
                Console.WriteLine("Press Enter to retrun to Main Menu");
            }
            else
            {
                Console.WriteLine("\nEmployee Found !");
                Console.WriteLine("Press Enter to Display Record !");
                Console.ReadLine();

                PrintEmployee print = new PrintEmployee(temp);
                print.PrintAllEmployee();
            }
        }

        public void Search()
        {
            Console.Clear();
            Console.WriteLine("---- Search Employee ----\n");
            Console.WriteLine("-- Search By Name --\n");

            searchEmail();
            Console.WriteLine("\nPress Enter To return to Main Menu!\n");
            Console.ReadLine();



        }

    }
}
