using System;
using System.Collections.Generic;
namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();


            AddEmp add = new AddEmp();

            bool flag = true;
            while (flag)
            {
                Console.Clear();
                Console.WriteLine("---------------Staff Management System-------------\n\n");
                Console.WriteLine("Select an options:\n\n1.Add new employee\n2.Edit an existing employee\n3.View employee\n4.Delete a employee\n5.Search a employee\n6.Quit\n\nEnter your selections");

                string ch = Console.ReadLine();
                switch (ch)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("----- Add New Employee ------\n");
                        var emp = add.addNew();
                        employees.Add(emp);
                        break;
                    case "2":
                        EditUser edit = new EditUser(employees);
                        employees = edit.Edit();
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine(" ---- All Staffs ---- \n");

                        PrintEmployee print = new PrintEmployee(employees);
                        print.PrintAllEmployee();

                        Console.WriteLine($"\n\nTotal Number of Staffs: {employees.Count}\n");
                        Console.WriteLine("Press 1 to copy the details in files.     Press any key to  Return to Main Menu");
                        
                        string choice = Console.ReadLine();
                        if (choice == "1")
                        {
                            //Call the multithreading part here.
                        }


                        break;

                    case "4":
                        DeleteEmp del = new DeleteEmp(employees);
                        employees = del.Delete();
                        break;
                    case "5":
                        SearchEmp search = new SearchEmp(employees);
                        search.Search();
                        break;
                    case "6":
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("\nInvalid Input\n");
                        Console.WriteLine("Press Enter to try again!");
                        Console.ReadLine();
                        break;

                }
            }
        }
    }
}
