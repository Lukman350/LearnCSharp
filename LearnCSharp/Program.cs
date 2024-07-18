namespace LearnCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //debuggingcsharp.start(count: 9);

            //var classes = classeschapter.parsename(name: "lukman");
            //classes.introduce(to: "john doe");

            //customer customer = new(1);
            //var result = int.tryparse("412421", out int number);
            //Console.WriteLine(result ? number : "Conversion failed.");

            //Person person = new()
            //{
            //    BirthDate = new DateTime(1961, 01, 19)
            //};

            //Console.WriteLine(person.BirthDate);
            //Console.WriteLine($"Age of this person is {person.Age} years old");

            //Nullable<int> number = new();

            //Console.WriteLine($"Has Value ? {number.HasValue}");
            //Console.WriteLine($"Value : {number.GetValueOrDefault()}");

            Video video = new()
            {
                Title = "How to become programmer",
                Author = "Lukman"
            };

            VideoEncoder encoder = new(); // publisher
            MailService mailService = new(); // subscriber
            MessageService messageService = new(); // subscriber

            encoder.VideoEncoded += mailService.OnVideoEncoded;
            encoder.VideoEncoded += messageService.OnVideoEncoded;

            encoder.Encode(video);

            Console.WriteLine($"Video {video.Title} has been encoded");
        }

        static void UseCalculator()
        {
            Calculator calculator = new();
            Console.WriteLine(calculator.Add(1, 2, 3, 4));
            Console.WriteLine(calculator.Add(1, 2, 3));
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1));
        }

        static void UsePoints()
        {
            try
            {
                Point point = new(20, 50);
                point.Move(null);
                Console.WriteLine($"Point is at {point.X} and {point.Y}");
                point.Move(100, 150);
                Console.WriteLine($"Point is at {point.X} and {point.Y}");
            }
            catch (Exception)
            {
                Console.WriteLine("An unexpected error occured.");
            }
        }
    }
}
