using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class PrintEmployee
    {
        List<Employee> empList = new List<Employee>();
        public PrintEmployee(List<Employee> empList)
        {
            this.empList = empList;
        }

        public void PrintAllEmployee()
        {
            Console.WriteLine($" ID    Name          Email              DOB          Department    Salary     \n");
            int i = 0;
            foreach (var emp in empList)
            {
                emp.ID = i++;
                Console.WriteLine($" {emp.ID} |   {emp.Name} |  {emp.Email} |   {emp.DOB} |   {emp.Department}  |  {emp.Salary} ");
            }
            
        }


    }
}