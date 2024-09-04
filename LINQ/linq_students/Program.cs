// 1.Filter the list to only include students who scored more than 80.
// 2.Order the filtered list by the students' grades in descending order.
// 3.Select only the names of the students.
// 4.Return the name of the student with the highest grade.
using linq_students;
List<Student> students = new List<Student>
{
    new Student { Name = "Alice", Grade = 85 },
    new Student { Name = "Bob", Grade = 75 },
    new Student { Name = "Charlie", Grade = 95 },
    new Student { Name = "David", Grade = 70 },
    new Student { Name = "Eve", Grade = 90 }
};

//Solution:
var topStudent = students
    .Where(s => s.Grade > 80) //Step 1
    .OrderByDescending(s => s.Grade) //Step 2
    .Select(s => s.Name) //Step 3
    .First(); //Step 4

Console.WriteLine($"Top student is {topStudent}");    