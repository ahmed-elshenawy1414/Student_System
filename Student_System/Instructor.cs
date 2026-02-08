namespace StudentManagementSystem
{

    public class Instructor
    {
        public int InstructorId { get; set; }

        public string Name { get; set; }

        public string Specialization { get; set; }


        public string PrintDetails()
        {

            return "ID: " + InstructorId + ", Name: " + Name + ", Spec: " + Specialization;

        }
    }
}