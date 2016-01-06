using System.Collections.Generic;
namespace ExerciciosDoLivroCleanCode
{
    public class Use_Intention_Revealing_Names
    {


        /*----------------------bad code-------------------------*/
        int d; // elapsed time in days
        public List<Cell> gameBoard()
        {
            List<Cell> list1 = new List<Cell>();
            foreach (Cell x in getFlaggedCells())
            {
                if (x.cell[0] == 4)
                    list1.Add(x);
            }
            return list1;

        }





        /*----------------------beautiful code-------------------------*/
        int elapsedTimeInDays;
        int daysSinceCreation;
        int daysSinceModification;
        int fileAgeInDays;

        public List<Cell> getFlaggedCells()
        {
            List<Cell> flaggedCells = new List<Cell>();
            foreach (Cell cell in gameBoard())
            {
                if (cell.IsFlaged())
                    flaggedCells.Add(cell);
            }
            return flaggedCells;
        }

    }
}
