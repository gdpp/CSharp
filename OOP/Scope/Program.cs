namespace Scope
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // This variable just works in Main method
            int a = 5;

            a = a * 5;

            Console.WriteLine("a={0}", a);

            //Instance of MyClass
            MyClass obj = new MyClass();

            obj.Show();
            obj.Multiply();
            obj.Show();
        }
    }
}