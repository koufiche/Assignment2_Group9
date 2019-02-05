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
            //Displays the result of the custom method using the given inpu of arrays
            Console.WriteLine("\n\nClosest numbers:");
            int[] arr = { 5, 4, 3, 2 };
            int n = arr.Length;
            closestNumbers(arr, n);
            Console.ReadKey();

            //Displays the result of the custom method using the given inpu of arrays
            Console.WriteLine("\n\nFind the median");
            int[] arr2 = { 0, 1, 2, 4, 6, 5, 3 };
            findMedian(arr2);
            Console.ReadKey();

            //Displays the result of the custom method using the given inpu of arrays
            Console.WriteLine("\n\nDay of Programmer");
            int year = 2017;
            Console.WriteLine(dayOfProgrammer(year));
            Console.ReadKey();

        }//End of Main

        //Custom method for bubble sort the array
        // A function to implement bubble sort 
        private static void bubbleSort(int[] arr)
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

                bubbleSort(items);//Sorting the array using the custom method
                
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
                Console.WriteLine("Exception occured while trying to find the closest number in the array");
                Console.ReadKey();
            }//End of catch block

            return 0;//Its a return method!!
        }//End of findMedian method

        //Custom method to calculate the pair with smallest absolute difference in the array
        static int [] closestNumbers(int[] arr, int n)
        {
            //Using try block to make sure nothing goes wrong!
            try
            {
                if (n <= 1)

                    // Sort array elements using the custom method
                    bubbleSort(arr);

                // Compare differences of adjacent 
                // pairs to find the minimum difference. 
                int minDiff = arr[1] - arr[0];
              
                for (int i = 2; i < n; i++)
                    minDiff = Math.Min(minDiff, arr[i] - arr[i - 1]);

                // Traverse array again and print all pairs 
                // with difference as minDiff. 
                for (int i = 1; i < n; i++)
                {
                    if ((arr[i] - arr[i - 1]) == minDiff)
                    {
                        Console.Write("[" + arr[i - 1] + ", "
                              + arr[i] + "]");

                    }//End of If statement
                }//End of for loop
            }//End of try block
            //Using catch block to display the error message in case of an exception
            catch
            {
                Console.WriteLine("Exception occured while trying to find the closest number in the array");
                Console.ReadKey();
            }//End of catch block

            return new int[] { };//Its a return method!!
        }//End of the closestNumbers method

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
                Console.WriteLine("Exception occured while trying to find the day of teh programmer");
                Console.ReadKey();
            }//End of catch block
            return "";
        }//End of the custom method dayOfProgrammer
    }//End of class 
}//End of namespace
