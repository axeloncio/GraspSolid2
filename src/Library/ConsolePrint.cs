/*
Nuevamente, se aplica el principio SRP de SOLID, sencillamente creamos otra clase para que imprima
la receta.  
*/

using System;
using Full_GRASP_And_SOLID.Library;

namespace Full_GRASP_And_SOLID{
    public class ConsolePrinter{
        public void PrintRecipe(Recipe recipe){
            Console.WriteLine($"Receta de {recipe.FinalProduct.Description}:");
            foreach (Step step in recipe.Steps)
            {
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
            }
        }
    }
}