namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // In C#, an interface is a contract or a blueprint for a class
            // that specifies a set of members (methods, properties, events, and indexers)
            // that the class must implement.

            Add sum = new Add();

            sum.Calculate(6.3f, 8.7f);
            sum.ShowResult();
            sum.Calculate(3.2f, 5.0f);
            sum.ShowResult();
            sum.Calculate(6.3f, 8.7f);
            sum.ShowResult();
            sum.Calculate(3.2f, 5.0f);
            sum.ShowResult();
            sum.Calculate(6.3f, 8.7f);
            sum.ShowResult();

            sum.Show();

            Subtract sub = new Subtract();

            sub.Calculate(7.2f, 3.0f);
            sub.ShowResult();
        }
    }
}