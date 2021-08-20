using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
        internal class CountSpaces : IActionFunction
        {
            public void FunctionAction()
            {
               string userInput;
              int countSpaces = 0;
                Console.WriteLine("Please enter a string");
                userInput = Console.ReadLine();
            //string empty;
              countSpaces = countSpacesFunc(userInput);
                Console.WriteLine(string.Format("The number of spaces in the string is : {0} ", countSpaces));
            }
        private int countSpacesFunc(string i_UserInput)
        {
            int countSpaces = 0;
            foreach (char element in i_UserInput)
            {
                if(element==' ')
                {
                    countSpaces++;
                }
            }
            return countSpaces;
        }
        }
}
