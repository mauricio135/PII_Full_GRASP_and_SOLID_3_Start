using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
    //Added class to comply with the polymorfism principle
    public class FilePrinter: IPrinter
    {
        public void PrintRecipe (Recipe recipe)
        {
            File.WriteAllText("Recipe.txt", recipe.GetTextToPrint());
        }        
    }
}