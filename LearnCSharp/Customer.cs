namespace LearnCSharp
{
    public class Customer
    {
        public int Id;
        public string Name;
        public readonly List<Order> Orders = [];

        public Customer(int id)
        {
            Id = id;
        }
        public Customer(int id, string name): this(id)
        {
            Name = name;
        }
    }
}
