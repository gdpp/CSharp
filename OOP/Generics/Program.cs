namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            ObjectWarehouse<string> files = new ObjectWarehouse<string>(90);

            files.Add("Gdpp");
            files.Add("Sally");
            files.Add("Salem");

            string personName = files.GetElement(1);
            Console.WriteLine(personName);

            ObjectWarehouse<Employee> emp = new ObjectWarehouse<Employee>(90);

            emp.Add(new Employee(1500));
            emp.Add(new Employee(1500));
            emp.Add(new Employee(1500));

            Employee employee = emp.GetElement(1);
            Console.WriteLine(employee);
            Console.WriteLine(employee.GetSalary());

        }
    }

    class ObjectWarehouse<T>
    {
        private T[] elementsData;
        private int i = 0;

        public ObjectWarehouse(int z)
        {
            elementsData = new T[z];
        }

        public void Add(T obj)
        {
            elementsData[i] = obj;
            i++;
        }

        public T GetElement(int i)
        {
            return elementsData[i];
        }
    }

    class Employee
    {
        private double salary;

        public Employee(double salary) 
        { 
            this.salary = salary;
        }

        public double GetSalary()
        {
            return salary;
        }
    }
}