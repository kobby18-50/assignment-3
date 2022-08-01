
using System;

namespace Assignment
{
    class Program
    {
        public static void Main(string[] args){
          maxNumber();
          minNumber();
          meanNumber();
          medianNumber();
          strCounter();
          secondLargest();
          monthName();
        }

        public static void binaryConvertor(){
        //     int decVal;
        //  int val;
        //  string a = "";
        //  decVal = 34;
        //  Console.WriteLine("Decimal: {0}", decVal);
        //  while (decVal >= 1) {
        //     val = decVal / 2;
        //     a += (decVal % 2).ToString();
        //     decVal = val;
        //  }
        //  string binValue = "";
        //  for (int i = a.Length - 1; i >= 0; i--) {
        //     binValue = binValue + a[i];
        //  }
        //  Console.WriteLine("Binary: {0}", binValue);
        //  Console.Read();
        }

        public static void monthName(){
            string[] months = {"January", "February", "March", "April", "May", "June", "July",
                                "August", "September", "October", "November", "December"}; 

            System.Console.WriteLine("Enter the number to print the month");
            var index = Convert.ToInt32(Console.ReadLine());

            var value = index - 1;

            System.Console.WriteLine(months[value]);
        }

        public static void secondLargest(){
            System.Console.WriteLine("Enter 5 numbers to find the second largest number");
            int [] nums = new int[5];

            for(int i = 0; i < 5; i++){

                nums[i] = Convert.ToInt32(Console.ReadLine());

            }

            Array.Sort(nums);

            System.Console.WriteLine("The second largest number is {0} ",nums[3]);
        }

        public static void strCounter(){
            int counter = 0, theWord = 1;

            System.Console.WriteLine("Enter your sentence here: ");
            string str = Console.ReadLine();

            while (counter <= str.Length -1){
                if(str[counter] == ' ' || str[counter] == '\n' || str[counter] == '\t' ){
                    theWord++;
                }
                counter++;
            }

            System.Console.WriteLine("The number of words in your string = "+ theWord);
        }

        public static void medianNumber(){
            System.Console.WriteLine("Enter 5 numbers to find the median number");
            int [] nums = new int[5];

            for(int i = 0; i < 5; i++){

                nums[i] = Convert.ToInt32(Console.ReadLine());

            }

            System.Console.WriteLine("The median is "+ nums[2]);
        }

        public static void meanNumber(){
             System.Console.WriteLine("Enter 5 numbers to find the mean number");
            int [] nums = new int[5];
            var total = 0;

            for(int i = 0; i < 5; i++){

                nums[i] = Convert.ToInt32(Console.ReadLine());

                total = total + nums[i];
            }

            System.Console.WriteLine("The mean of the values you entered is  " + total/5);
        }


        public static void maxNumber(){

            System.Console.WriteLine("Enter 5 numbers to find the maximum");
            int [] nums = new int[5];

            for(int i = 0; i < 5; i++){

                nums[i] = Convert.ToInt32(Console.ReadLine());
            }

            int max = nums[0];

            for(int i = 0; i < 5; i++){
                if(nums[i] > max){
                    max = nums[i];
                }
            }

            System.Console.WriteLine("Largest number is {0} ", max);

        }

        public static void minNumber(){

            System.Console.WriteLine("Enter 5 numbers to find the minimum");
            int [] nums = new int[5];

            for(int i = 0; i < 5; i++){

                nums[i] = Convert.ToInt32(Console.ReadLine());
            }

            int min = nums[0];

            for(int i = 0; i < 5; i++){
                if(nums[i] < min){
                    min = nums[i];
                }
            }

            System.Console.WriteLine("Smallest number is {0} ", min);
        }
    }
}