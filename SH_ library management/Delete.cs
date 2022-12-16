using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class DeleteEmp
    {
        List<Employee> delEmp = new List<Employee>();

        public DeleteEmp(List<Employee> delEmp)
        {
            this.delEmp = delEmp;
        }

        public List<Employee> Delete()
        {
            Console.Clear();
            Console.WriteLine("---- Delete Employee ----\n");

            if (delEmp.Count == 0)
            {
                Console.WriteLine("\nThe list is already empty\n");
                Console.WriteLine("Press Enter to return to Main menu");
                Console.ReadLine();
                return delEmp;
            }

            bool loopFlag = true;
            while (loopFlag)
            {
                PrintEmployee print = new PrintEmployee(delEmp);
                print.PrintAllEmployee();
                Console.WriteLine("\nEnter the Employee Id to delete.\n");
                int ID = Convert.ToInt32(Console.ReadLine());

                bool idFlag = false;
                foreach (var item in delEmp)
                {
                    if (item.ID == ID)
                    {
                        idFlag = true;
                        loopFlag = false;
                        delEmp.RemoveAt(ID);
                        Console.WriteLine("\nDeleted\n");
                        Console.WriteLine("Press Enter to Continue");
                        Console.ReadLine();
                        break;
                    }
                }
                if (idFlag == false)
                {
                    Console.WriteLine("\nEmployee Not Found!\n");
                    Console.WriteLine("\nTry Again!!\n");
                }

            }

            return delEmp;
        }
    }
}


