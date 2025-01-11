using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopassig3
{
    internal class Employee
    {
        
        public int ID { get; set; }
        public string Name { get; set; }
        private char gender;
        public char Gender
        {
            get { return gender; }
            set
            {
                if (value == 'M' || value == 'F')
                    gender = value;
                else
                    throw new ArgumentException("Gender must be 'M' or 'F'.");
            }
        }
        public decimal Salary { get; set; }
        public HiringDate HireDate { get; set; }
        public SecurityPrivilege SecurityLevel { get; set; }

        
        public Employee() { }

        public Employee(int id, string name, char gender, decimal salary, HiringDate hireDate, SecurityPrivilege securityLevel)
        {
            ID = id;
            Name = name;
            Gender = gender; 
            Salary = salary;
            HireDate = hireDate;
            SecurityLevel = securityLevel;
        }

        
        public override string ToString()
        {
            return string.Format("ID: {0}, Name: {1}, Gender: {2}, Salary: {3}, Hire Date: {4}, Security Level: {5}",
                ID, Name, Gender, Salary.ToString("C", CultureInfo.CurrentCulture), HireDate, SecurityLevel);
        }
    }
}

