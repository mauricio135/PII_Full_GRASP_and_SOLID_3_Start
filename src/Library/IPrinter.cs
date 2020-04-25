using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
    //Interface created to comply with the polymorfism principle
    public interface IPrinter
    {
        public void PrintRecipe(Recipe recipe);
    }
}