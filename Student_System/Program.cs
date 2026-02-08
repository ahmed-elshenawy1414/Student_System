
using StudentManagementSystem;

class Program
{
    static StudentManager school = new StudentManager();

    static void Main(string[] args)
    {
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("\n--- School Management Menu ---");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Add Instructor");
            Console.WriteLine("3. Add Course");
            Console.WriteLine("4. Enroll Student in Course");
            Console.WriteLine("5. Show All Students");
            Console.WriteLine("6. Show All Courses");
            Console.WriteLine("7. Show All Instructors");
            Console.WriteLine("8. Find Student By ID Or Name");
            Console.WriteLine("9. Find Course By ID Or Name"); 
            Console.WriteLine("10. Find Instructor by ID"); 
            Console.WriteLine("11. Exit");
            Console.Write("Choice: ");

            int  choice = Convert.ToInt32(Console.ReadLine());

            switch (choice) 
            {
                case 1:
                    Console.Write("ID: ");
                    int sId = int.Parse(Console.ReadLine());
                    Console.Write("Name: ");
                    string sName = Console.ReadLine();
                    Console.Write("Age: ");
                    int sAge = int.Parse(Console.ReadLine());
                    school.AddStudent(new Student { StudentId = sId, Name = sName, Age = sAge });
                    Console.WriteLine("Student added!");
                    break;

                case 2:
                    Console.Write("ID: ");
                    int iId = int.Parse(Console.ReadLine());
                    Console.Write("Name: ");
                    string iName = Console.ReadLine();
                    Console.Write("Spec: ");
                    string spec = Console.ReadLine();
                    school.AddInstructor(new Instructor { InstructorId = iId, Name = iName, Specialization = spec });
                    Console.WriteLine("Instructor added!");
                    break;

                case 3:
                    Console.Write("Course ID: ");
                    int cId = int.Parse(Console.ReadLine());
                    Console.Write("Title: ");
                    string title = Console.ReadLine();
                    Console.Write("Instructor ID: ");
                    int instId = int.Parse(Console.ReadLine());

                    Instructor inst = school.FindInstructor(instId);  
                    if (inst != null)
                    {
                        school.AddCourse(new Course { CourseId = cId, Title = title, Instructor = inst });
                        Console.WriteLine("Course added!");
                    }
                    else
                    {
                        Console.WriteLine("Error: Instructor not found!");
                    }
                    break;

                case 4:
                    Console.Write("Student ID: ");
                    int studId = int.Parse(Console.ReadLine());
                    Console.Write("Course ID: ");
                    int courId = int.Parse(Console.ReadLine());

                    bool success = school.EnrollStudentInCourse(studId, courId); 
                    if (success) Console.WriteLine("Enrolled successfully!");
                    else Console.WriteLine("Enrollment failed!");
                    break;

                case 5: 
                    for (int i = 0; i < school.Students.Count; i++)
                    {
                         Console.WriteLine(school.Students[i].PrintDetails()); 
                    }
                    break;

                case 6:
                    for (int i = 0; i < school.Courses.Count; i++)
                    {
                        Course c = school.Courses[i];
                        Console.WriteLine(c.PrintDetails());
                    }
                    break;

                case 7:
                    for (int i = 0; i < school.Instructors.Count; i++)
                    {
                        Instructor t = school.Instructors[i];
                        Console.WriteLine(t.PrintDetails());
                    }
                    break;

                case 8:
                    Console.Write("Enter Student ID or Name: ");
                    string sInput = Console.ReadLine();
                    Student sFound = school.FindStudentByIdOrName(sInput); 
                    if (sFound != null) Console.WriteLine(sFound.PrintDetails());
                    break;

                case 9:
                    Console.Write("Enter Course ID or Name: ");
                    string cInput = Console.ReadLine();
                    Course cFound = school.FindCourseByIdOrName(cInput); 
                    if (cFound != null) Console.WriteLine(cFound.PrintDetails());
                    break;

                case 10:
                    Console.Write("Enter Instructor ID to find: ");
                    
                    int searchId = Convert.ToInt32(Console.ReadLine());                   
                    Instructor foundTeacher = school.FindInstructor(searchId);

                    if (foundTeacher != null)
                    {
                        Console.WriteLine("Instructor Found: " + foundTeacher.PrintDetails());
                    }
                    else
                    {
                        Console.WriteLine("Error: Instructor with ID " + searchId + " not found.");
                    }
                    break;

                case 11:
                     exit = true;
                    break;

                default:
                    Console.WriteLine("Invalid choice, try again.");
                    break;
            }
        }
    }
}