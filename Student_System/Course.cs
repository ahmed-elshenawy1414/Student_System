namespace StudentManagementSystem
{
    public class Course
    {
        public int CourseId { get; set; }
      
        public string Title { get; set; }
        
        public Instructor Instructor { get; set; }
     

        public string PrintDetails()
        {
            string teacherName = "";
            if (Instructor != null)  teacherName = Instructor.Name; 
             return "ID: " + CourseId + ", Title: " + Title + ", Teacher: " + teacherName; 
        }
    }
}