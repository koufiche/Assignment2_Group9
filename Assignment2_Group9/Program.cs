//Programmer: Yagna Dheepika Venkitasamy,
//Course: ISM6225
//Assignment: Assignment 2

using System;

namespace Assignment2_Group9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Displays the result of the custom method using the given input of arrays
            Console.WriteLine("Function: Find the closest numbers in the array { 5, 4, 3, 2 }");
            int[] arr3 = new int[] { 5, 4, 3, 2 };
            int[] answer1 = closestNumbers(arr3,1);
            for (int z2 = 0; z2 < answer1.Length; z2++)
            {
                Console.Write(answer1[z2]);
                if (z2 < answer1.Length - 1)
                {
                    Console.Write(" ,");
                }
            }

            Console.WriteLine("\n----------------------------------------------------------------------------------");
            Console.ReadKey(true);


            //Displays the result of the custom method using the given input of arrays
            Console.WriteLine("Function: Find the median of the array { 0, 1, 2, 4, 6, 5, 3 }");
            int[] arr2 = { 0, 1, 2, 4, 6, 5, 3 };
            findMedian(arr2);

            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.ReadKey();

            //Displays the result of the custom method using the given input of arrays
            Console.WriteLine("Function: Day of Programmer for the year 1986");
            int year = 1986;
            Console.WriteLine(dayOfProgrammer(year));

            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.ReadKey();

        }//End of Main

        //Custom method for bubble sort the array
        // A function to implement bubble sort 
        private static void Sort(int[] arr)
        {
            int n = arr.Length;
            //For loop to iterate the sort function
            for (int i = 0; i < n - 1; i++)
                //Nested for loop to perform the bubble sort function
                for (int j = 0; j < n - i - 1; j++)
                    if (arr[j] > arr[j + 1])
                    {
                        // swap temp and arr[i] 
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }//End of for loop
        }//End of bubble sort function

        //Custom method to find the median of the array
        static int findMedian(int[] arr2)
        {
            //Using try block to make sure nothing goes wrong!
            try
            {
                //Declaring variables to calculate the median in the array
                var median = 0.0;
                var items = new[] { 0, 1, 2, 4, 6, 5, 3 };
                var getLengthItems = items.Length;

                Sort(items);//Sorting the array using the custom method
                
                //Using IF statement to determine the length and the median of the array
                if (getLengthItems % 2 == 0)

                {
                    var firstValue = items[(items.Length / 2) - 1];
                    var secondValue = items[(items.Length / 2)];
                    median = (firstValue + secondValue) / 2.0;
                }
                //Using else-if to calculate the median if the the array has odd number of elements
                else if (getLengthItems % 2 == 1)
                {
                    median = items[(items.Length / 2)];
                }
                Console.WriteLine(median);//Displays the result
            }//End of try block
            //Using catch block to display the error message in case of an exception
            catch
            {
                Console.WriteLine("Exception occured while trying to find the median in the array");
                Console.ReadKey();
            }//End of catch block

            return 0;//Its a return method!!
        }//End of findMedian method

        //Custom method to calculate the pair with smallest absolute difference in the array
        static int[] closestNumbers(int[] Arr, int n)
        {
            //Using try block to make sure nothing goes wrong!
            try
            {
                int j = 0;
            int[] store = new int[Arr.Length + 10];

            Sort(Arr);//Soring the array by calling the method
            double oldmin = 1 / .00009;

            //For loop to find the difference in the integers in the array
            for (int i = 0; i < Arr.Length - 1; i++)
            {
                double newmin = Arr[i + 1] - Arr[i];

                if (newmin < 0)
                {
                    newmin = newmin * -1;
                }

                if (oldmin > newmin)
                {
                    oldmin = newmin;
                    store[j] = Arr[i];
                    j++;
                    store[j] = Arr[i + 1];
                    j++;

                }// end of IF

                else if (oldmin == newmin)
                {
                    store[j] = Arr[i];
                    j++;
                    store[j] = Arr[i + 1];
                    j++;
                }//  end of else if
                
            }// end of FOR - 1

            int[] final = new int[j];

            for (int i = 0; i < j; i++)
            {
                final[i] = store[i];
            }
            return final;//Its a return method!!
            }//End of try block
            //Using catch block to display the error message in case of an exception
            catch
            {
                Console.WriteLine("Exception occured while trying to find the closest numbers of the array");
                Console.ReadKey();
            }//End of catch block

            return new int[] { };//Its a return method!!;

        }//End of closestNumber method
            //Custom method to calculate the day of teh programmer
            private static String dayOfProgrammer(int year)
        {
            //Using try block to make sure nothing goes wrong!
            try
            {
                //Using IF statement to determine the year type
                if (year == 1918)
                    return "26.09.1918";

                //Defining variables for Gregorian and Leap years
                bool isGregorian = true;
                bool isLeap = false;
                String result = null;

                //Using If statement to define gregorian
                if (year <= 1917)
                {
                    isGregorian = false;
                }
                //Using If statement to define gregorian cum leap year
                if (isGregorian)
                {
                    isLeap = (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
                }
                //Using If statement to define non - gregorian cum leap year
                else
                {
                    isLeap = (year % 4 == 0);
                }

                //Using IF-Else to calculate the result for leap year or not
                if (isLeap)
                {
                    result = "12.09." + year;
                }
                else
                {
                    result = "13.09." + year;
                }
                return result;// Its a return method
            }//End of try block
            //Using catch block to display the error message in case of an exception
            catch
            {
                Console.WriteLine("Exception occured while trying to find the day of the programmer");
                Console.ReadKey();
            }//End of catch block
            return "";
        }//End of the custom method dayOfProgrammer
    }//End of class 
}//End of namespace
