using System.Xml.Linq;

namespace Assignment5
{
    interface GovtRules
    {
       public double EmployeePF(double basicSalary);
       public string LeaVeDetails();
       public double gratuityAmount(float serviceCompleted, double basicSalary);
    }
    class TCS : GovtRules
    {
        public TCS(int empid, string name, string dept, string desg, int basic_salary)
        {
        }

        public double EmployeePF(double basicSalary)
        {
            throw new NotImplementedException();
        }

        public double gratuityAmount(float serviceCompleted, double basicSalary)
        {
            throw new NotImplementedException();
        }

        public string LeaVeDetails()
        {
            throw new NotImplementedException();
        }
    }
    class Accenture : GovtRules
    {
        public Accenture(int empid, string name, string dept, string desg, int basic_salary)
            
        {
            int empid, basic_salary;
            string name, dept, desg;

        }

        public double EmployeePF(double basicSalary)
        {
            throw new NotImplementedException();
        }

        public double gratuityAmount(float serviceCompleted, double basicSalary)
        {
            throw new NotImplementedException();
        }

        public string LeaVeDetails()
        {
            throw new NotImplementedException();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the employee Id:");
            int empid=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter name:");
            string name=Console.ReadLine();
            Console.WriteLine("Enter the Department:");
            string dept=Console.ReadLine();
            Console.WriteLine("Enter the designation:");
            string desg=Console.ReadLine();
            Console.WriteLine("Enter Basic Salary:");
            int basic_salary=int.Parse(Console.ReadLine());
            TCS tcs = new TCS(empid, name, dept, desg, basic_salary);
        }
    }
}
