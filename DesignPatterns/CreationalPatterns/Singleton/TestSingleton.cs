using System;

namespace DesignPatterns.CreationalPatterns.Singleton
{
    internal class TestSingleton
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