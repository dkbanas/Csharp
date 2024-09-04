// 1.Filter the list to only include employees who are older than 30.
// 2.Group the filtered employees by their department.
// 3.Order each group by the employees' age in ascending order.
// 4.Select the youngest employee's name from each department.
// 5.Order the departments alphabetically and return the result as a list of strings in the format: "{Department}: {EmployeeName}".

using linq_employee;

List<Employee> employees = new List<Employee>
{
    new Employee { Name = "John", Age = 45, Department = "HR" },
    new Employee { Name = "Jane", Age = 32, Department = "IT" },
    new Employee { Name = "Anna", Age = 28, Department = "IT" },
    new Employee { Name = "Mike", Age = 40, Department = "Finance" },
    new Employee { Name = "Laura", Age = 35, Department = "HR" },
    new Employee { Name = "Tom", Age = 50, Department = "Finance" },
    new Employee { Name = "Sarah", Age = 29, Department = "HR" }
};
//Solution
var solution = employees
    .Where(e => e.Age > 30) //1
    .GroupBy(e => e.Department) //2
    .Select(g => new //3 and 4
    {
        Department = g.Key,
        EmployeeName = g.OrderBy(e => e.Age).First().Name
    })
    .OrderBy(x => x.Department)  //5 part 1                      
    .Select(x => $"{x.Department}: {x.EmployeeName}")  //5 part 2
    .ToList();
    
solution.ForEach(Console.WriteLine);