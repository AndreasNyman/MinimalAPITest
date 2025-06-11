namespace MinimalAPITest
{
    public class Student
    {
        private int _id;

        public int Id { get => _id; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Course { get; set; }
        public int Points { get; set; }

        public Student(int id)
        {
            _id = id;
        }
    }
}
