﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDoLivroCleanCode.Chapter_2
{
    class Add_Meaningful_Context
    {
        private void printGuessStatistics(char candidate, int count)
        {
            String number;
            String verb;
            String pluralModifier;
            if (count == 0)
            {
                number = "no";
                verb = "are";
                pluralModifier = "s";
            }
            else if (count == 1)
            {
                number = "1";
                verb = "is";
                pluralModifier = "";
            }
            else
            {
                number = (count).ToString();
                verb = "are";
                pluralModifier = "s";
            }
            String guessMessage = String.Format(
              "There %s %s %s%s", verb, number, candidate, pluralModifier
            );
            Console.WriteLine(guessMessage);
        }
    }
    public class GuessStatisticsMessage
    {
        private String number;
        private String verb;
        private String pluralModifier;
        public String make(char candidate, int count)
        {
            createPluralDependentMessageParts(count);
            return String.Format(
              "There %s %s %s%s",
               verb, number, candidate, pluralModifier);
        }
        private void createPluralDependentMessageParts(int count)
        {
            if (count == 0)
            {
                thereAreNoLetters();
            }
            else if (count == 1)
            {
                thereIsOneLetter();
            }
            else
            {
                thereAreManyLetters(count);
            }
        }
        private void thereAreManyLetters(int count)
        {
            number = (count).ToString();
            verb = "are";
            pluralModifier = "s";
        }
        private void thereIsOneLetter()
        {
            number = "1";
            verb = "is";
            pluralModifier = "";
        }
        private void thereAreNoLetters()
        {
            number = "no";
            verb = "are";
            pluralModifier = "s";
        }
    }
}
