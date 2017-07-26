﻿using System;
using DesignPatterns.Factory;

namespace DesignPatterns
{
    class Program
    {
        /// <summary>
        /// I like to think about classes as "people" and the patterns are
        /// diffent ways that these people talk to each other.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
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
        */
            new TestFactory();

            Console.ReadKey();
        }
    }
}