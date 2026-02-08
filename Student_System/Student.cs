namespace StudentManagementSystem
{
    public class Student
    {
        public int StudentId { get; set; }
        
        public string Name { get; set;}
        
        public int Age { get; set;}
       
        public List<Course> Courses {get; set;} = new List<Course>(); 

        public bool Enroll(Course course)
        {
            if (course != null)
            {
                Courses.Add(course); 
            return true;
            }
            return false;
        }

        public string PrintDetails()
        {
             return "ID: " + StudentId + ", Name: " + Name + ", Age: " + Age + ", Courses: " + Courses.Count; 
        }
    }
}