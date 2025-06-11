using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace MinimalAPITest
{
    public static class StudentCollection
    {
        public static List<Student> Students { get; } = new List<Student>();

        public static void Init()
        {
            var swedishCulture = new CultureInfo("sv-SE");

            Students.Add(new Student(1) { Name = "Andreas", DateOfBirth = DateTime.Parse("1984-03-28", swedishCulture), Course = "Computer Science", Points = 85 });
            Students.Add(new Student(2) { Name = "Erik", DateOfBirth = DateTime.Parse("1985-04-28", swedishCulture), Course = "Mathematics", Points = 90 });
            Students.Add(new Student(3) { Name = "John", DateOfBirth = DateTime.Parse("1986-05-28", swedishCulture), Course = "Physics", Points = 78 });
            Students.Add(new Student(4) { Name = "Peter", DateOfBirth = DateTime.Parse("1987-06-28", swedishCulture), Course = "Chemistry", Points = 92 });
            Students.Add(new Student(5) { Name = "Eva", DateOfBirth = DateTime.Parse("1988-07-28", swedishCulture), Course = "Biology", Points = 88 });
            Students.Add(new Student(6) { Name = "Kalle", DateOfBirth = DateTime.Parse("1989-08-28", swedishCulture), Course = "Engineering", Points = 80 });
        }

        public static void UpdateStudent(Student student)
        {
            var studentToUpdtate = Students.FirstOrDefault(s => s.Id == student.Id);
            if (studentToUpdtate != null)
            {
                studentToUpdtate.Name = student.Name;
                studentToUpdtate.DateOfBirth = student.DateOfBirth;
                studentToUpdtate.Course = student.Course;
                studentToUpdtate.Points = student.Points;
            }
            else
            {
                throw new Exception("Student not found.");

            }
        }

        public static void AddNewStudent(Student student)
        {
            if (Students.Count > 0)
            {
                var latestId = Students.Max(s => s.Id);
                Students.Add(new Student(latestId + 1)
                {
                    Name = student.Name,
                    DateOfBirth = student.DateOfBirth,
                    Course = student.Course,
                    Points = student.Points
                });
            }
            else
            {
                Students.Add(new Student(1)
                {
                    Name = student.Name,
                    DateOfBirth = student.DateOfBirth,
                    Course = student.Course,
                    Points = student.Points
                });
            }
        }
    }
}