namespace final_t
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (Counter counter = new Counter())
            {
                var registry = new AnimalRegistry(counter);
                registry.Open();
            }
        }
    }
}
