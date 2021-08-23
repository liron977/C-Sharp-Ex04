using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    internal class CountSpaces : IActionFunction
    {
        public void FunctionAction()
        {
            int countSpaces=0;
            string userInput=string.Empty;

            Console.WriteLine("Please enter a string");
            userInput = Console.ReadLine();
            countSpaces = countSpacesFunc(userInput);
            Console.WriteLine(string.Format("The number of spaces in the string is : {0} ", countSpaces));
        }

        private int countSpacesFunc(string i_UserInput)
        {
            int countSpaces = 0;

            foreach(char element in i_UserInput)
            {
                if(element == ' ')
                {
                    countSpaces++;
                }
            }

            return countSpaces;
        }
    }
}