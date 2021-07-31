using System;

namespace EmployeeApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            int employeeId = 0;
            string firstname = string.Empty;
            string lastName = string.Empty;
            decimal annualSalary = 0;
            char gender = '\0';
            bool isManager = false;

            Console.WriteLine("Please enter a unique Id for this employee: ");

            employeeId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the employee's first name: ");
            firstname = Console.ReadLine();

            Console.WriteLine("Please enter the employee's last name: ");
            lastName = Console.ReadLine();

            Console.WriteLine("Please enter the employee's annual salary: ");
            annualSalary = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Please enter the employee's gender: ('f' = female. 'm' = male)");
            gender = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("The employee is a manager (true/false)");
            isManager = Convert.ToBoolean(Console.ReadLine());

            string genderTerm = (gender == 'f') ? "female" : "male";

            string managerNarrative = (isManager) ? "part of management team" : "currently not a part of management team";

            string narrative = $"Employee with Id of {employeeId}";
            narrative += $" whose full name is {firstname} {lastName}{Environment.NewLine}";
            narrative += $"is a {genderTerm} employee who is {managerNarrative}.{Environment.NewLine}";
            narrative += $"This employee earns an annual salary of {annualSalary} dollars.";

            Console.Clear();

            Console.WriteLine(narrative);

            Console.ReadKey();
        }
    }
}
