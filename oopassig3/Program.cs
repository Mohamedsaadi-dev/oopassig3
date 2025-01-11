namespace oopassig3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            try
            {
                Employee emp = new Employee(5, "Mohamed Saad", 'M', 55000.75m, new DateTime(2002, 5, 5), SecurityPrivilege.Developer);
                Console.WriteLine(emp.ToString());
               
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            #endregion
            #region Q2
            
                try
                {
                    HiringDate hireDate = new HiringDate(15, 1, 2020);
                    Employee emp = new Employee(1, "Mohamed Saad", 'M', 55000.75m, hireDate, SecurityPrivilege.Developer);
                    Console.WriteLine(emp.ToString());

                   
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            #endregion
            #region Q3
            try
            {
                
                Employee[] EmpArr = new Employee[3];

                
                EmpArr[0] = new Employee(1, "mohamed saad", 'm', 70000m, new HiringDate(5, 5, 2002), SecurityPrivilege.DBA);
                EmpArr[1] = new Employee(2, "bebi", 'M', 45000m, new HiringDate(1, 3, 2000), SecurityPrivilege.Guest);
                EmpArr[2] = new Employee(3, "zeko", 'M', 90000m, new HiringDate(20, 11, 2019), SecurityPrivilege.SecurityOfficer);

               
                foreach (var emp in EmpArr)
                {
                    Console.WriteLine(emp.ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }


            #endregion
            #region Q4

            try
            {
                
                Employee[] EmpArr = new Employee[3];

                
                EmpArr[0] = new Employee(1, "mohamed saad", 'm', 70000m, new HiringDate(1, 6, 2015), SecurityPrivilege.DBA);
                EmpArr[1] = new Employee(2, "bebo", 'M', 45000m, new HiringDate(15, 3, 2021), SecurityPrivilege.Guest);
                EmpArr[2] = new Employee(3, "zeko", 'M', 90000m, new HiringDate(20, 11, 2018), SecurityPrivilege.SecurityOfficer);

                
                int boxingCount = 0; 
                int unboxingCount = 0; 

                
                var sortedEmployees = EmpArr.OrderBy(emp => { boxingCount++; return emp.HireDate; }).ToArray();

                
                Console.WriteLine("Sorted Employees by Hire Date:");
                foreach (var emp in sortedEmployees)
                {
                    Console.WriteLine(emp.ToString());
                }

               
                Console.WriteLine($"Boxing operations: {boxingCount}");
                Console.WriteLine($"Unboxing operations: {unboxingCount}"); 
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            #endregion



        }
    }
}
