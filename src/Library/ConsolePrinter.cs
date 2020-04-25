using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
    //Added class to comply with the polymorfism principle
    public class ConsolePrinter: IPrinter
    {
        public void PrintRecipe(Recipe recipe)
        {
            Console.WriteLine(recipe.GetTextToPrint());
        }
    }
}
