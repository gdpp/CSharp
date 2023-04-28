namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Object
            Person person = new Person();

            person.Name = "Gustavo";
            person.Age = 31;
            person.IsAdult = true;

            person.Show();
        }
    }
}