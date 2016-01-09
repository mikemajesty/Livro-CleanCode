namespace ExerciciosDoLivroCleanCode.Chapter_3
{
    public interface Argument_Objects
    {
       
        Circle makeCircle(double x, double y, double radius);
        Circle makeCircle(System.Drawing.Point center, double radius);
    }
}
