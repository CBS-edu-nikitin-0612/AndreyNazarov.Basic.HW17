namespace Task2
{
    internal class Customer
    {
        public Customer(string model, string name, string phoneNumber)
        {
            Model = model;
            Name = name;
            PhoneNumber = phoneNumber;
        }

        public string Model { get; private set; }
        public string Name { get; private set; }
        public string PhoneNumber { get; private set; }

        public override string ToString()
        {
            return $"Имя: {Name}, Телефоный номер: {PhoneNumber}";
        }
    }
}
