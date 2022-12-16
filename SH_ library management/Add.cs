using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class AddEmp
    {
        public string getDepartment()
        {
            Console.WriteLine("\nSelect Department\n");
            Console.WriteLine("1.FrontEnd  2.BackEnd  3.FullStack");

            string x = Console.ReadLine();
            int ch = 0;
            if (int.TryParse(x, out ch))
            {
                if (ch == 1)
                    return "FrontEnd";
                else if (ch == 2)
                    return "BackEnd";
                else if (ch == 3)
                    return "FullStack";
                else
                    return "Try Again";
            }
            else
            {
                return "Try Again";
            }



        }
        public Employee addNew()
        {

            Validation validate = new Validation();

            Console.WriteLine("Enter Name: ");
            string name = Console.ReadLine();
            name = validate.CheckName(name);

            Console.WriteLine("\nEnter Email: ");
            string email = Console.ReadLine();
            email = validate.CheckEmail(email);


            Console.WriteLine("\nEnter Date MM/dd/yyyy : ");
            string dob = Console.ReadLine();
            dob = validate.CheckDate(dob);

            string department = "";
            bool departmentFlag = false;
            while (departmentFlag == false)
            {
                department = getDepartment();
                if (department != "Try Again")
                {
                    departmentFlag = true;
                }

            }

            double salary = validate.checkSalary();
            Console.WriteLine("\nEmployee Added! Select view user to see the total list of employee.");

            Console.WriteLine("\n---- Press enter for Main Menu ---- \n");
            Console.ReadLine();

            Employee emp = new Employee(0, name, email, dob, department, salary);
            return emp;

        }
    }
}

