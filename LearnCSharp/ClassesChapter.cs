namespace LearnCSharp
{
    public class ClassesChapter
    {
        public required string Name;

        public void Introduce(string to)
        {
            Console.WriteLine($"Hi {to}, I'm {Name}");
        }

        public static ClassesChapter ParseName(string name)
        {
            var classes = new ClassesChapter
            {
                Name = name
            };

            return classes;
        }
    }
}
