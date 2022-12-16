using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class EditUser
    {
        List<Employee> empEdit;
        public EditUser(List<Employee> empEdit)
        {
            this.empEdit = empEdit;
        }

        public List<Employee> Edit()
        {
            Validation validate = new Validation();
            AddEmp add = new AddEmp();
            PrintEmployee print = new PrintEmployee(empEdit);


            Console.Clear();
            Console.WriteLine("---- Edit Details ----\n\n");

            bool loopFlag = true;

            print.PrintAllEmployee();
            while (loopFlag)
            {

                Console.WriteLine("Enter the Employee ID you want to edit: ");

                int ID = Convert.ToInt32(Console.ReadLine());
                bool idFlag = false;
                foreach (var item in empEdit)
                {
                    if (item.ID == ID)
                    {
                        idFlag = true;
                        loopFlag = false;
                        Console.WriteLine($"\nInput the details of Employee with ID: {ID}\n");

                        Console.WriteLine("Update the Name");
                        item.Name = Console.ReadLine(); //Updated

                        Console.WriteLine("Update the Email");
                        string email = Console.ReadLine();
                        item.Email = validate.CheckEmail(email);//Updated

                        Console.WriteLine("\nUpdate Date MM/dd/yyyy : ");
                        string dob = Console.ReadLine();
                        item.DOB = validate.CheckDate(dob);//Updated

                        Console.WriteLine("\nUpdate Department: ");
                        string department = "";
                        bool departmentFlag = false;
                        while (departmentFlag == false)
                        {
                            department = add.getDepartment();
                            if (department != "Try Again")
                            {
                                departmentFlag = true;
                            }

                        }
                        item.Department = department;//Updated


                        Console.WriteLine("\nUpdate Salary: ");
                        item.Salary = Convert.ToDouble(Console.ReadLine());


                        //Console.WriteLine("\nUpdate Hobbies (Max:3)");
                        //item.Hobbies = add.GetHobbies();
                    }
                }

                if (idFlag == false)
                {
                    Console.WriteLine("\nEmployee Not Found!\n");
                    Console.WriteLine("\nTry Again!!\n");

                }

            }

            return empEdit;
        }


    }
}
