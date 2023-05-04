namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            for(int i=0; i<10; i++)
            {
                Employee employee = new Employee();
                employee.GetDetails();
                employees.Add(employee);
            }
            Console.WriteLine("Employees with Salary between 10000 and 25000");
            var list1=(from e in employees where e.salary>10000 && e.salary<25000 select e).ToList();
            foreach(Employee emp in list1) 
             emp.DisplayDetails();

            Console.WriteLine("All the records with department HR");
            var list2=(from e in employees where e.dept.Contains("HR") select e).ToList();
            foreach(Employee emp in list2)
                emp.DisplayDetails();

            Console.WriteLine("Displaying all The Records");
            var list3 = (from e in employees select e).ToList();
            foreach(Employee e in list3)
                e.DisplayDetails();

            Console.WriteLine("All the records with salary more than 12000 and in accounts department is ");
            var list5=(from e in employees where e.dept.Contains("Accounts") && e.salary>12000 select e).ToList();
            foreach(Employee e in list5)
                e.DisplayDetails();


        }
    }
}