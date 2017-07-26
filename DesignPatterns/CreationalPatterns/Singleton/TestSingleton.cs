using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.Singleton
{
    class TestSingleton
    {
        public TestSingleton()
        {
            Console.WriteLine("--TestSingleton start--");
            EarthSingleton earth = EarthSingleton.GetInstance();
            earth.Spin();
            Console.WriteLine("--TestSingleton end--");
        }
    }
}
