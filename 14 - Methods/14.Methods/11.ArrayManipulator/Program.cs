using System;
using System.Reflection;


namespace _11.ArrayManipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

            // Console.WriteLine(string.Join(" ",inputArray));


            string command = string.Empty;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] commandArray = command.Split();

                switch (commandArray[0])
                {

                    case "exchange":
                        int index = int.Parse(commandArray[1]);
                        inputArray = ExchangeArray(inputArray, index);
                        break;

                    case "max":
                        string indexMax = (commandArray[1]);
                        MaxCalcolation(inputArray, indexMax);
                        //Console.WriteLine(string.Join(" ", inputArray));
                        break;

                    case "min":
                        string indexMin = (commandArray[1]);
                        MinCalcolation(inputArray, indexMin);
                        break;

                    case "first":
                        int indexCountFirst = int.Parse(commandArray[1]);
                        string evenOrOddFirst = (commandArray[2]);
                        FirstElementsEvenOrOdd(inputArray, indexCountFirst, evenOrOddFirst);

                        break;

                    case "last":
                        int indexCountLast = int.Parse(commandArray[1]);
                        string evenOrOddLast = (commandArray[2]);
                        LastElementsEvenOrOdd(inputArray, indexCountLast, evenOrOddLast);
                        break;



                }
            }

            //Console.Write(string.Join(" ", inputArray));
            string finalArray = string.Empty;
            for (int i = 0; i < inputArray.Length; i++) 
            {
                finalArray = finalArray + inputArray[i] + ", ";
            }


            Console.Write($"[{finalArray.Trim(',', ' ')}]");


        }

        private static int[] ExchangeArray(int[] inputArray, int index)
        {
            int[] middleArray = new int[inputArray.Length];
            if (index <= inputArray.Length)
            {

                int indexCount = 0;
                for (int i = index + 1; i < inputArray.Length; i++)
                {
                    middleArray[indexCount] = inputArray[i];
                    indexCount++;
                }

                for (int j = 0; j <= index; j++)
                {
                    middleArray[indexCount] = inputArray[j];
                    indexCount++;
                }
            }
            else
            {
                middleArray = (int[])inputArray.Clone();
                Console.WriteLine("Invalid index");

            }


            return middleArray;


        }
        private static void MaxCalcolation(int[] inputArray, string indexMax)
        {
            int maxIndex = -1;

            if (indexMax == "even")
            {


                int maxSelectNumberEven = int.MinValue;
                for (int i = 0; i < inputArray.Length; i++)
                {
                    int selectNumberEven = inputArray[i];

                    if (selectNumberEven % 2 == 0 && selectNumberEven >= maxSelectNumberEven)
                    {
                        maxIndex = i;
                        maxSelectNumberEven = selectNumberEven;
                    }

                }

            }

            else if (indexMax == "odd")
            {

                int maxSelectNumberOdd = int.MinValue;
                for (int i = 0; i < inputArray.Length; i++)
                {
                    int selectNumberOdd = inputArray[i];

                    if (selectNumberOdd % 2 != 0 && selectNumberOdd >= maxSelectNumberOdd)
                    {
                        maxIndex = i;
                        maxSelectNumberOdd = selectNumberOdd;
                    }

                }



            }

            if (maxIndex >= 0)
            {
                Console.WriteLine(maxIndex);
            }

            else
            {
                Console.WriteLine("No matches");
            }

        }
        private static void MinCalcolation(int[] inputArray, string indexMin)
        {
            int minIndex = -1;

            if (indexMin == "even")
            {


                int minSelectNumberEven = int.MaxValue;
                for (int i = 0; i < inputArray.Length; i++)
                {
                    int selectNumberEven = inputArray[i];

                    if (selectNumberEven % 2 == 0 && selectNumberEven <= minSelectNumberEven)
                    {
                        minIndex = i;
                        minSelectNumberEven = selectNumberEven;
                    }

                }

            }

            else if (indexMin == "odd")
            {

                int minSelectNumberOdd = int.MaxValue;
                for (int i = 0; i < inputArray.Length; i++)
                {
                    int selectNumberOdd = inputArray[i];

                    if (selectNumberOdd % 2 != 0 && selectNumberOdd <= minSelectNumberOdd)
                    {
                        minIndex = i;
                        minSelectNumberOdd = selectNumberOdd;
                    }

                }

            }

            if (minIndex >= 0)
            {
                Console.WriteLine(minIndex);
            }

            else
            {
                Console.WriteLine("No matches");
            }

        }
        private static void FirstElementsEvenOrOdd(int[] inputArray, int indexCountFirst, string evenOrOdd)
        {
            string selectNumberString = string.Empty;
            if (indexCountFirst <= inputArray.Length)
            {

                if (evenOrOdd == "even")
                {
                    string selectNumberEvenString = string.Empty;
                    int countEven = 0;
                    for (int i = 0; i <= inputArray.Length; i++)
                    {
                        int selectNumberEven = inputArray[i];

                        if (selectNumberEven % 2 == 0)
                        {
                            selectNumberString += selectNumberEven.ToString() + ", ";
                            countEven++;
                        }
                        if (countEven >= indexCountFirst)
                        {
                            break;
                        }
                    }

                }
                else if (evenOrOdd == "odd")
                {


                    int countOdd = 0;
                    for (int i = 0; i < inputArray.Length; i++)
                    {
                        int selectNumberOdd = inputArray[i];

                        if (selectNumberOdd % 2 != 0)
                        {
                            selectNumberString += selectNumberOdd.ToString() + ", ";
                            countOdd++;
                        }
                        if (countOdd >= indexCountFirst)
                        {
                            break;
                        }
                    }
                }

                Console.WriteLine($"[{selectNumberString.Trim(' ', ',')}]");
            }

            else
            {
                Console.WriteLine("Invalid count");
            }

            
        }
        private static void LastElementsEvenOrOdd(int[] inputArray, int indexCountLast, string evenOrOddLast)
        {
            if (indexCountLast <= inputArray.Length)
            {
                string selectNumberString = string.Empty;
                if (evenOrOddLast == "even")
                {
                    string selectNumberEvenString = string.Empty;
                    int countEven = 0;
                    for (int i = inputArray.Length - 1; i <= 0; i--)
                    {
                        int selectNumberEven = inputArray[i];

                        if (selectNumberEven % 2 == 0)
                        {
                            selectNumberString = selectNumberEven.ToString() + ", " + selectNumberString;
                            countEven++;
                        }
                        if (countEven >= indexCountLast)
                        {
                            break;
                        }
                    }

                }

                else if (evenOrOddLast == "odd")
                {


                    int countOdd = 0;
                    for (int i = inputArray.Length - 1; i >= 0; i--)
                    {
                        int selectNumberOdd = inputArray[i];

                        if (selectNumberOdd % 2 != 0)
                        {
                            selectNumberString = selectNumberOdd.ToString() + ", " + selectNumberString;
                            countOdd++;
                        }
                        if (countOdd >= indexCountLast)
                        {
                            break;
                        }
                    }

                }
                Console.WriteLine($"[{selectNumberString.Trim(' ', ',')}]");

            }

            else
            {
                Console.WriteLine("Invalid count");
            }

        }
    }
}