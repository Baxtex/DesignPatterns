﻿using System;

namespace DesignPatterns.CreationalPatterns.Singleton
{
    internal class EarthSingleton
    {
        private static EarthSingleton singleInstance = new EarthSingleton();

        private EarthSingleton()
        {
        }

        public static EarthSingleton GetInstance()
        {
            return singleInstance;
        }

        public void Spin()
        {
            Console.WriteLine("Earth spinning");
        }
    }
}