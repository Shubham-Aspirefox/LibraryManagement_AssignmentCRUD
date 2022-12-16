namespace Assignment
{
    public class Employee
    {
        public int ID { get; set; } //Rename this to EmployeeId
        public string Name { get; set; }
        public string Email { get; set; }
        public string DOB { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }
        //Add a company name property
        public Employee(int iD, string name, string email, string dob, string department, double salary)
        {
            ID = iD;
            Name = name;
            Email = email;
            DOB = dob;
            Department = department;
            Salary = salary;
        }


    }
}