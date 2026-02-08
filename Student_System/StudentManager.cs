namespace StudentManagementSystem
{

    public class StudentManager
    {
        public List<Student> Students { get; set; } = new List<Student>(); 
        public List<Course> Courses { get; set; } = new List<Course>(); 
        public List<Instructor> Instructors { get; set; } = new List<Instructor>();


        public bool AddStudent(Student student) 
        {
            if (student != null)
            {
                Students.Add(student);
                return true;
            }
            return false;
        }
        public bool AddInstructor(Instructor instructor)
        {
            if (instructor != null)
            {
                Instructors.Add(instructor);
                return true;
            }
            return false;
        }
        public bool AddCourse(Course course)
        {
            if (course != null)
            {
                Courses.Add(course);
                return true;
            }
            return false;
        }
        public Student FindStudentByIdOrName(string input)
        {
            for (int i = 0; i < Students.Count; i++)
            {
                Student student = Students[i];
                if (student.StudentId.ToString() == input || student.Name.ToLower() == input.ToLower())
                {
                    return student;
                }
            }
            return null;
        }

      
        public Course FindCourseByIdOrName(string input)
        {
            for (int i = 0; i < Courses.Count; i++)
            {
                Course c = Courses[i];
                if (c.CourseId.ToString() == input || c.Title.ToLower() == input.ToLower())
                {
                    return c;
                }
            }
            return null;
        }

       
        public Instructor FindInstructor(int id)
        {
            for (int i = 0; i < Instructors.Count; i++)
            {
                Instructor inst = Instructors[i];
                if (inst.InstructorId == id) return inst;
            }
            return null;
        }

        public bool EnrollStudentInCourse(int sId, int cId)
        {
            Student student = FindStudentByIdOrName(sId.ToString());
            Course course = FindCourseByIdOrName(cId.ToString());
            if (student != null && course != null)  return student.Enroll(course); 
           
        return false;
        }
    }
}