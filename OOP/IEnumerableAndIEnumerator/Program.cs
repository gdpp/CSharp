namespace IEnumerableAndIEnumerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create store object
            Store store = new Store();

            // Iterate each element of structure

            foreach(Car myCar in store)
            {
                myCar.CalculateTax(0.05);
                myCar.ShowInfo();
            }
        }
    }
}