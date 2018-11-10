using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigLatin
{
    class PigLatin
    {
        static void Main(string[] args)
        {
            string outputString = "Please enter a word to be converted to pig Latin. Type \"exit\" to leave the program.";
            string userInput;
            bool run = true;

            WriteLine(outputString);

            while (run)
            {
                userInput = ReadLine();
                if (userInput == "exit")
                {
                    run = false;
                }
                else
                {
                    char[] inputAsChar = userInput.ToArray();
                    ConvertStringToPigLatin(inputAsChar);
                }
            }
        }

        public static void ConvertStringToPigLatin(char[] inputArray)
        {
            char temp;
            temp = inputArray[0];

            if (temp != 'a' && temp != 'e' && temp != 'i' && temp != 'o' && temp != 'u' && temp != 'y')
            {
                for (int i = 0; i < inputArray.Length; i++)
                {
                    if (i + 1 != inputArray.Length)
                    {
                        inputArray[i] = inputArray[i + 1];
                    }
                }
                inputArray[inputArray.Length - 1] = temp;
            }

            Array.Resize(ref inputArray, inputArray.Length + 2);
            inputArray[inputArray.Length - 2] = 'a';
            inputArray[inputArray.Length - 1] = 'y';

            WriteLine("Result: ");
            foreach (char letter in inputArray)
            {
                Write(letter);
            }
            WriteLine("\n");
        }
    }
}
