using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp;
            int[] myArray;
            myArray = new int[] { 6, 5, -10, -5, 99 };
            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = 0; j < myArray.Length - 1; j++)
                {
                    if (myArray[j] > myArray[j + 1])
                    {
                        temp = myArray[j];
                        myArray[j] = myArray[j + 1];
                        myArray[j + 1] = temp;
                    }
                }
            }

            //Array.Sort(myArray);
            string line = ""; //without this it just displaces the compared numbers

            for (int i = 0; i < myArray.Length; i++)
            {
                line += myArray[i].ToString() + " ";  //Console.WriteLine(myArray[i]); instead of the two lines
                Console.WriteLine(line);
            }
            Console.ReadLine();
        }
    }
}
