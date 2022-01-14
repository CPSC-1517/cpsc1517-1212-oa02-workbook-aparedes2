// See https://aka.ms/new-console-template for more information
using OOPDemo01;
using static System.Console; // Allows you to 


// Create new Course Object
Course cpsc1517Course = new Course("CPSC1517", "Introduction to Application Development");
//var cpsc1517Course = new Course("CPSC1517", "Introduction to Application Development");
//Course cpsc1517Course = new ("CPSC1517", "Introduction to Application Development");
WriteLine($"CourseNo: {cpsc1517Course.CourseNo}");
WriteLine($"CourseName: {cpsc1517Course.CourseName}");

// add some students to the course
//cpsc1517Course.AddStudent("Aaron Fong");
//cpsc1517Course.AddStudent("David L. Mckinley");
//cpsc1517Course.AddStudent("Hamza Said");
//cpsc1517Course.AddStudent("Haseeb Memon");
//cpsc1517Course.AddStudent("Allaine Paredes");
cpsc1517Course.LoadFromFile(@"C:\Users\Admin\Desktop\CPSC1517/Students.txt");

// Display all the student in the course
foreach (var currentStudent in cpsc1517Course.Students)
{
    WriteLine(currentStudent);
}

// Remove 2 student from the course
cpsc1517Course.RemoveStudent("Hamza Said");
cpsc1517Course.RemoveStudent("Haseeb Memon");

// Display the number of students
WriteLine($"There are now {cpsc1517Course.StudentCount} students.");