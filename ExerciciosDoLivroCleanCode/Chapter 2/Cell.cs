using System.Linq;

namespace ExerciciosDoLivroCleanCode
{
    public class Cell
    {
        public int[] cell { get; set; }
        public bool IsFlaged()
        {
            return cell.FirstOrDefault() == 4;
        }
    }
}