//Next Prime Number – Have the program find prime numbers until the user chooses to stop the asking for the next one.
using System;
using System.Collections.Generic;
using Utlity;

namespace NextPrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> primeNumList = new List<int>();

            Console.Write("How many prime numbers would you like:");
            int input = UserInput.GetUserNumericInput();

            int amountOfNums = input;
            int currentPrimeNums = 0;


            int numToCheck = 2;
            while (currentPrimeNums < amountOfNums)
            {
                bool isNumPrime = true;
                float halfValue = (float)numToCheck / 2.0f;
                for (int i = 2; i <= halfValue; i++)
                {
                    int remainder = numToCheck % i;
                    if (remainder == 0)
                    {
                        isNumPrime = false;
                        break;
                    }
                }
                if (isNumPrime)
                {
                    currentPrimeNums++;
                    primeNumList.Add(numToCheck);
                }
                numToCheck++;
            }

            int index = 0;
            foreach (int num in primeNumList)
            {
                Console.WriteLine((index + 1) + ": " + num);
                index++;
            }
        }
    }
}
