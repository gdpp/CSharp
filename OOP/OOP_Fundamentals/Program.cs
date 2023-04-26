using System.ComponentModel;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Security.Claims;

namespace OOP_Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            // Core Concepts
            // - Encapsulation
            // - Inheritance
            // - Polimorfism
            // - Composition

            // Object
            // An Object is an instance of a class that is created at runtime.
            // It is a reference type that contains data and behavior specified by its class.
            // The data of the object is represent as ATTRIBUTES
            // The content of that data in some moment is the OBJECT STATE.
            // The behavior of an object represent what the object can do.
            // The behavior are METHODS

            // Access
            // - Public -> Access by outside
            // - Private -> Only the own object can access
            // - Protected -> Only in the inheritance change has access

            // Class
            // Is a blueprint to build an Object
            // Set the attributes and how the method works
            // Many objects can be build by the same class

            // In C#, there are several types of classes, including:
            // Normal Class: A class that defines an object and its properties and methods.
            // Abstract Class: A class that cannot be instantiated, but can be used as a base class for other classes.
            // Sealed Class: A class that cannot be inherited by other classes.
            // Static Class: A class that contains only static members(methods, properties, fields, events) and cannot be instantiated.
            // Partial Class: A class that can be split into multiple files within the same namespace, allowing multiple developers to work on different parts of the class at the same time.
            // Nested Class: A class that is defined inside another class and can access the private members of the outer class.
            // Generic Class: A class that is defined with one or more type parameters, allowing it to work with any data type.
            // Extension Class: A static class that contains extension methods, which allow you to add functionality to existing classes without modifying their source code.
            // Singleton Class: A class that can only have one instance created at a time, ensuring that all requests for that class return the same object.

            // Instance
            // The object is called instance too
            // Create an object from a class is know like Instatiation.

            // Encapsulation
            // Combining attributes and methods inside of an only entity we obtain the encapsulation
            // Only show to the outside the objects that can interact each other.
            // Restrict the access to the attributes is called data hiding.

            // Accessor
            // Allows the access to the intern data of the object
            // Interface functions, Getter, Setter
            // Properties

            // Mutator
            // Allows change the intern state of the object.

            // Create instance
            Calculator calculator = new Calculator();

            // Access attributes to sset the value
            calculator.a = 15;
            calculator.b = 45;

            // Invoke Method & Show result
            calculator.Add();

            Console.WriteLine("------------");
            
            // Create another object
            Calculator calculator1 = new Calculator();

            calculator1.a = 6437;
            calculator1.b = 242;

            calculator1.Add();
        }
    }
}