using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDoLivroCleanCode.Chapter_5
{
    class Horizontal_Openness_and_Density
    {
        private int lineCount;
        private int totalChars;

        private void measureLine(String line)
        {
            lineCount++;
            int lineSize = line.Length;
            totalChars += lineSize;
            lineWidthHistogram.addLine(lineSize, lineCount);
            recordWidestLine(lineSize);
        }

        private void recordWidestLine(int lineSize)
        {
            throw new NotImplementedException();
        }
    }
}
