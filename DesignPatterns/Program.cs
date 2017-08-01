using DesignPatterns.CreationalPatterns.AbstractFactory;
using DesignPatterns.CreationalPatterns.Builder;
using DesignPatterns.CreationalPatterns.Singleton;
using DesignPatterns.Factory;
using DesignPatterns.Others.MVC;
using System;

namespace DesignPatterns
{
    internal class Program
    {
        /// <summary>
        /// I like to think about classes as "people" and the patterns are
        /// diffent ways that these people talk to each other.
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            /*
            * Factory pattern is a creational pattern. It works by creating objects
            * while hiding the logic to the client.
            * The TestFactory in this case doesn't know how to
            * create any shapes, it uses the ShapeFactory for this.
            * the factory pattern is like a hiring agency.
            * You've got someone that will need a variable number of workers.
            * This person may know some info they need in the people they hire, but that's it.
            * So, when they need a new employee, they call the hiring agency and
            * tell them what they need. Now, to actually hire someone,
            * you need to know a lot of stuff - benefits, eligibility verification, etc.
            * But the person hiring doesn't need to know any of this - the hiring agency handles all of that.
            * The factory produces ISomething implementations.
            */
            new TestFactory();

            /*
            *Works a lot like factory pattern. But this pattern first creates factories which then creates products.
            * It decouples the client and the object creation even more.
            * This can be useful if you need to change the type of factory during runtime.
            * For example differnt factories depending on the OS.
            * The factory produces IFactories that produces ISomething
            */
            new TestAbstractFactory();

            /*
             * Singleton pattern is useful where you only need one single instance of some class to be used.
             * SIngletons aren't considered that good,difficult to test, tightly coupled code.
             * One example where a singleton could be considered is a log file. Globals should be avoided for more
             * encapsulated code.
             */
            new TestSingleton();

            /*
             *The Builder pattern is great when you need a object that has optional properties. In this example
             * I am building a Nutrition facts label for a food item. It's easer to write, read and use instead for, for example
             * many different constructors. The object is immutable.
             */
            new TestBuilder();

            /*
             * Model View Controller or MVC for short is a common design and/or architectural pattern most used for GUI interfaces.
             * It works by dividing and decoupling different tasks between different modules. Model is the data, say a Person objec.t
             * View is the actual thing that the user sees and Controller is what, Controls it all. A user uses the Controller which manipulates
             * the Model which updates the View that the User sees.
             */
            new TestModelViewController();

            Console.ReadKey();
        }
    }
}