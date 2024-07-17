namespace LearnCSharp
{
    public class DebuggingCSharp
    {
        public List<int> numbers = [1, 2, 3, 4, 5, 6, 7, 8];
        public int count = 1;

        public static List<int> Numbers
        {
            get
            {
                var debug = new DebuggingCSharp();

                return debug.numbers;
            }
        }

        public static void Start(int? count = null)
        {
            var debug = new DebuggingCSharp
            {
                count = count ?? Numbers.Count
            };

            var smallests = debug.getSmallests(null, debug.count);

            foreach (var number in smallests)
            {
                Console.WriteLine(number);
            }
        }

        public List<int> getSmallests(List<int>? numbers, int count)
        {
            if (numbers == null)
                throw new ArgumentNullException(nameof(numbers));

            if (count > numbers.Count || count <= 0)
                throw new ArgumentOutOfRangeException(nameof(count), $"Count cannot be greater than {numbers.Count} or less than 1.");

            var buffer = new List<int>(numbers);
            var smallests = new List<int>();

            while (smallests.Count < count)
            {
                var min = getSmallest(buffer);
                smallests.Add(min);
                buffer.Remove(min);
            }

            return smallests;
        }

        public static int getSmallest(List<int> numbers)
        {
            var min = numbers[0];

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] < min)
                    min = numbers[i];
            }

            return min;
        }
    }
}
