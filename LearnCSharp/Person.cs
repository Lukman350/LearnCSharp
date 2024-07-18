namespace LearnCSharp
{
    public class Person
    {
        private DateTime _birthDate;
        private int _age;

        public DateTime BirthDate
        {
            get => _birthDate;
            set => _birthDate = value;
        }

        public int Age
        {
            get
            {
                var now = DateTime.Now;
                return now.Year - _birthDate.Year;
            }

            set => _age = value;
        }
    }
}
