using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics.Eventing.Reader;
using System.Dynamic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Program_with_Arrays
{
    class Program
    {
        public void MaxNumUnsortedArray(long[] array, long length)
        {
            long len = length;

            // "length" is stored in "len" 

            long maximum = -9223372036854775808;

            // "maximum" is initialised to the lowest value
            // of long datatype to compare with other elements in array and find the maximum out of them.

            for (long i = 0; i < len; i++)
            {
                if ( maximum < array[i] )
                {
                    // if  maximum id less then array[i] then we change the value of "maximum" to array[i]

                    maximum = array[i];
                }

               
            }
            
            // maximum is printed

            Console.WriteLine("The Maximum value of the array is : " + maximum);

        }

        public void MinNumUnsortedArray(long[] array, long length)
        {
            long len = length;

            // "length" is stored in "len" 

            long minimum = 9223372036854775807;

            // "maximum" is initialised to the highes value
            // of long datatype to compare with other elements in array and find the "minimum" out of them. 

            for (long i = 0; i < len; i++)
            {
                if (minimum > array[i])
                {
                    // if  "minimum" is greater then array[i] then we change the value of "minimum" to array[i]

                    minimum = array[i];
                }

               
            }

            // minimum is printed

            Console.WriteLine("The Minimum value of the array is : " + minimum);

        }

        public void SearchNumUnsortedArray(long[] array, long length, long number)
        {
            // "length" is stored in "len" 
            // "number" is stored in "num" 

            long len = length;
            long num = number;

            // flag is initialised to 0 

            long flag = 0;

            for (long i = 0; i < len; i++)
            {
                if (num == array[i])
                {

                    // the index number of the found "num" is printed

                    Console.WriteLine("Number " + num +  " is found at index : " + i);
                    
                    // value of flag is changed

                    flag = 1;

                    // loop is broken

                    break;
                }
            }
            if ( flag ==0)
            {
                // if value of flag has not changed then it means that the "num" not present in the array

                Console.WriteLine("Number " + num + " is not found ");
            }

        }

        public void SortArray(long[] array, long length)
        {
            // "length" is stored in "len" 
            // "temp" is declared to store value before changing 

            long len = length;
            long temp;

            // traverse 0 to array length 

            for (long i = 0; i < len - 1; i++)

                // traverse i+1 to array length 

                for (long j = i + 1; j < len; j++)

                    // compare array element with  
                    // all next element 

                    if (array[i] > array[j])
                    {

                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }

            // print all element of array 
            foreach (long value in array)
            {
                Console.Write(value + " ");
            }

        }

        public void FindDuplicateElements(long[] array, long length)
        {
            // "length" is stored in "len" 

            long len = length;

            // create a visited array of size length
           
            bool [] visited = new bool[len];

            // set every value in the array to false.

            for ( long i = 0; i<len; i++)
            {
                visited[i] = false;
            }    
           
            // for each element of the array mark it as visited and
            // print the element if it is seen before
            for (int i = 0; i < len; i++)
            {
                // if element is seen before

                if (visited[array[i]]) // print the value
                    Console.Write(array[i] + " ");

                // mark element as visited

                visited[array[i]] = true;
            }

          

        }

        public void MissingNum(long[] array, long length)
        {
            // "length" is stored in "len" 
            // "sum" is initialised to the sum of natural numbers from
            // 1 to "len"

            long len = length;
            long sum = ((len + 1) * (len + 1 + 1)) / 2;

            // traverse the array from 0 to "len"

            for ( long i = 0; i < len; i++)
            {
                // subtract every element of array from sum

                sum -= array[i]; 
            }

            // print the sum and that will be the missing number

            Console.WriteLine(sum);



        }

        public void ReverseArray(long[] array, long length)
        {
            // "length" is stored in "len"

            long len = length;
            
            // now start the loop from front with iterator "i"
            // and from back with iterator "j"

            for (long i = 0, j = len-1; i<len/2; i++, j--)
            {
                // initalise temp to array[i] because we are
                // changing it's value to array[j]

                long temp = array[i]; 
                array[i] = array[j];
                array[j] = temp;
                
            }
            for (long i = 0; i < len; i++)
            {
                // print the reversed array

                Console.Write(array[i] + " ");
            }



        }


        static void Main(string[] args)
        {
            // initalise bool cont so that we can ask the user
            // whether he wants to continue using the functions
            // or wants to exit the program

            bool cont = true;

            while (cont)
            {
                // Create a switch case to access all functions accordingly.

                Console.WriteLine("Input the Following numbers for their corresponding Functions : ");
                Console.WriteLine("1 for Program to find max number from an unsorted array ");
                Console.WriteLine("2 for Program to find Min number from an unsorted array");
                Console.WriteLine("3 for Program to Search a number from an array");
                Console.WriteLine("4 for Program to Sort an array");
                Console.WriteLine("5 for Program to find duplicate numbers of an array");
                Console.WriteLine("6 for Program to find Missing number in a sequential array");
                Console.WriteLine("7 for Program to Reverse an array");

                // input option from user to select the function he wants to use

                long option = long.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Input length of an unsorted array");
                        long length = long.Parse(Console.ReadLine()); // input the length of the array from user
                        Console.WriteLine("Input an unsorted array");
                        long[] array = new long[length]; // declare array of size "length"
                        for (long i = 0; i < length; i++) // input the array from user
                        {
                            array[i] = long.Parse(Console.ReadLine());
                        }
                        Program Sol1 = new Program(); // create object 
                        Sol1.MaxNumUnsortedArray(array, length); // call function with passing parameters
                        //Console.ReadLine();
                        break;

                    case 2:
                        Console.WriteLine("Input length of an unsorted array");
                        length = long.Parse(Console.ReadLine());
                        Console.WriteLine("Input an unsorted array");
                        array = new long[length]; // declare array of size "length"
                        for (long i = 0; i < length; i++) // input the array from user
                        {
                            array[i] = long.Parse(Console.ReadLine());
                        }
                        Program Sol2 = new Program(); // create object
                        Sol2.MinNumUnsortedArray(array, length); // call function with passing parameters
                       //Console.ReadLine();
                        break;

                    case 3:
                        Console.WriteLine("Input length of an unsorted array");
                        length = long.Parse(Console.ReadLine());
                        Console.WriteLine("Input an unsorted array");
                        array = new long[length]; // declare array of size "length"
                        for (long i = 0; i < length; i++) // input the array from user
                        {
                            array[i] = long.Parse(Console.ReadLine());
                        }
                        Console.WriteLine("Input the number you want to Search in the array ");
                        long num = long.Parse(Console.ReadLine());
                        Program Sol3 = new Program(); // create object 
                        Sol3.SearchNumUnsortedArray(array, length, num); // call function with passing parameters
                        //Console.ReadLine();
                        break;

                    case 4:
                        Console.WriteLine("Input length of an unsorted array");
                        length = long.Parse(Console.ReadLine());
                        Console.WriteLine("Input an unsorted array");
                        array = new long[length]; // declare array of size "length"
                        for (long i = 0; i < length; i++) // input the array from user
                        {
                            array[i] = long.Parse(Console.ReadLine());
                        }
                        Program Sol4 = new Program(); // create object 
                        Sol4.SortArray(array, length); // call function with passing parameters
                        //Console.ReadLine();
                        break;

                    case 5:
                        Console.WriteLine("Input length of an array");
                        length = long.Parse(Console.ReadLine());
                        Console.WriteLine("Input an array");
                        array = new long[length]; // declare array of size "length"
                        for (long i = 0; i < length; i++) // input the array from user
                        {
                            array[i] = long.Parse(Console.ReadLine());
                        }
                        Program Sol5 = new Program(); // create object 
                        Sol5.FindDuplicateElements(array, length); // call function with passing parameters
                        //Console.ReadLine();
                        break;

                    case 6:
                        Console.WriteLine("Input length of an array");
                        length = long.Parse(Console.ReadLine());
                        Console.WriteLine("Input an array");
                        array = new long[length]; // declare array of size "length"
                        for (long i = 0; i < length; i++) // input the array from user
                        {
                            array[i] = long.Parse(Console.ReadLine());
                        }
                        Program Sol6 = new Program(); // create object 
                        Sol6.MissingNum(array, length); // call function with passing parameters
                        //Console.ReadLine();
                        break;

                    case 7:
                        Console.WriteLine("Input length of an array");
                        length = long.Parse(Console.ReadLine());
                        Console.WriteLine("Input an array to reverse it");
                        array = new long[length]; // declare array of size "length"
                        for (long i = 0; i < length; i++) // input the array from user
                        {
                            array[i] = long.Parse(Console.ReadLine());
                        }
                        Program Sol7 = new Program(); // create object 
                        Sol7.ReverseArray(array, length); // call function with passing parameters
                        //Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine("Please enter a correct Option");
                        //Console.ReadLine();
                        break;



                }


                Console.WriteLine("Do you want to Continue (y/n)");

                // input "answer" from user 

                Char answer = Char.Parse(Console.ReadLine());
                
                if (answer == 'n' )
                {
                    // the program will stop

                    cont = false;
                }
                else 
                { 
                    // the program will continue

                    cont = true;
                    
                    // the console is cleared

                    Console.Clear();
                    
                }

            }
  
        }
    }
}
