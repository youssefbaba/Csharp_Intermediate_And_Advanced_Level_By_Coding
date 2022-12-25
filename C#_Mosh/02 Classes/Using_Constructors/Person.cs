namespace Using_Constructors
{
    public struct Person
    {
        // Fields
        public int Id { get; set; }
        public string? Name { get; set; }

        // Constructors
        public Person(int id)
        {
            Id = id;
            Name = default;
        } 
        public Person(int id, string name)
        {
            Id = id;
            Name = name;
        }

    }
}
