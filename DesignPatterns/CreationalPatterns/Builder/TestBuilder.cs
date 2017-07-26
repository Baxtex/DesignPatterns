using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.Builder
{
    internal class TestBuilder
    {
   
    public TestBuilder()
        {
            Console.WriteLine("--Test Builder start--");

            NutritionFact nf1 = new NutritionFact.NutritionBuilder(110, 3).Build();
            Console.WriteLine("Built a simple nf::" + nf1.ToString());

            NutritionFact nf2 = new NutritionFact.NutritionBuilder(110, 3).SetCalories(250).SetProteins(1).SetCarbs(100).Build();
            Console.WriteLine("Built a complex nf::" + nf2.ToString());

            Console.WriteLine("--Test Builder end--");
        }

    }
}
