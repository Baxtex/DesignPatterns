using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.Builder
{
    class NutritionFact
    {

        private readonly int servingSize;
        private readonly int servings;
        private readonly int calories;
        private readonly int fat;
        private readonly int carbs;
        private readonly int proteins;

        public class NutritionBuilder
        {
            //Requried params.
            private readonly int servingSize;
            private readonly int servings;

            //Optional params.
            private  int calories = 0;
            private  int fat = 0;
            private  int carbs = 0;
            private  int proteins = 0;

            public int ServingSize { get { return servingSize; } }
            public int Servings { get { return servings; } }
            public int Calories { get { return calories; } }
            public int Fat { get { return fat; } }
            public int Carbs { get { return carbs; } }
            public int Proteins { get { return proteins; } }

            public  NutritionBuilder(int servingSize, int servings)
            {
                this.servingSize = servingSize;
                this.servings = servings;
            }
            public NutritionBuilder SetCalories(int val)
            {
                calories = val;
                return this;
            }

            public NutritionBuilder SetFat(int val)
            {
                fat = val;
                return this;
            }

            public NutritionBuilder SetCarbs(int val)
            {
                carbs = val;
                return this;
            }

            public NutritionBuilder SetProteins(int val)
            {
                proteins = val;
                return this;
            }

            public NutritionFact Build()
            {
                return new NutritionFact(this);
            }
        }
        private NutritionFact(NutritionBuilder builder)
        {
            servingSize = builder.ServingSize;
            servings = builder.Servings;
            calories = builder.Calories;
            fat = builder.Fat;
            carbs = builder.Carbs;
            proteins = builder.Proteins;
        }

        public override string ToString()
        {
            return "servingSize: " + servingSize + ", servings: " + servings + ", calories: " + calories + ", fat: " + fat + ", carbs: " + carbs + ", proteins: " + proteins;
        }
    }
}
