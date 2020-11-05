using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Q1 
            /* int[] arr1 = new int[3];
             int sum1 = 0;
             Console.WriteLine("Enter 3 numbers :");
             for(int i=0; i<arr1.Length; i++)
             {
                 arr1[i] = int.Parse(Console.ReadLine());
                 if(arr1[i] < 0)
                 {
                     sum1 = sum1 + arr1[i];
                 }
             }
             Console.WriteLine(" Sum  = {0}", sum1);*/
            //----------------------------------------------------------------------------------------------
            //Q2
            /*    String[] animalsArr = { "Dog", "Cat", "Fox", "Elephant" };
                String[] copyAnimalsArr = new string[3];
                for(int i=0; i< animalsArr.Length; i++)
                {
                    copyAnimalsArr[i] = animalsArr[i];
                }*/
            //----------------------------------------------------------------------------------------------
            //Q3
            /* int[] numbersArr = new int[5];
             int[] oddsArr = new int[5];
             int[] evenArr = new int[5];

             Console.WriteLine(" Enter 5 integer numbers  ");
             for(int i=0; i<numbersArr.Length; i++)
             {
                 numbersArr[i] = int.Parse(Console.ReadLine());
                 if (numbersArr[i] % 2 == 0)
                 {
                     evenArr[i] = numbersArr[i];
                 }
                 else
                 {
                     oddsArr[i] = numbersArr[i];
                 }
             }
             Console.WriteLine(" Even numbers : ");
             for (int i = 0; i < evenArr.Length; i++)
             {
                 if (evenArr[i] != 0)
                 {
                     Console.WriteLine(evenArr[i]);
                 }
             }
             Console.WriteLine(" Odd numbers : ");
             for (int i = 0; i < oddsArr.Length; i++)
             {
                 if (oddsArr[i] != 0)
                 {
                     Console.WriteLine(oddsArr[i]);
                 }
             }
            */
            //----------------------------------------------------------------------------------------------
            //Q4
            /*  int[] arr4 = { 2, 3, 4, 5, 6 };
              for(int i = 0; i<arr4.Length; i++)
              {
                  arr4[i] = 2 * arr4[i];
              }
              Console.WriteLine("The duplicate array : ");
              for (int i = 0; i < arr4.Length; i++)
              {
                  Console.Write(arr4[i] + " ");
              }*/
            //----------------------------------------------------------------------------------------------
            //Q5
            /*  int[] arr5 = { 2, 3, 4, 5, 6 };
              for (int i = 0; i < arr5.Length; i++)
              {
                  arr5[i] = 2 * arr5[i];
              }
              Console.WriteLine("The reverse duplicate array : ");
              for (int i = arr5.Length-1; i >= 0 ; i--)
              {
                  Console.Write(arr5[i] + " ");
              }*/
            //----------------------------------------------------------------------------------------------
            //Q6
            /*  int[] arr6 = { 2, 3, 4, 5, 6 };
              int max6 = arr6[0];
              int min6 = arr6[0];
              //هون مندور على اكبر قيمة
              for (int i = 1; i < arr6.Length; i++)
              {
                if(arr6[i] > max6)
                  {
                      max6 = arr6[i];
                  }
              }
              //هون مندور على اصغر قيمة
              for (int i = 1; i < arr6.Length; i++)
              {
                  if (arr6[i] < min6)
                  {
                      min6 = arr6[i];
                  }
              }
              Console.WriteLine("Max number = {0}, Min number = {1} ", max6, min6);*/
            //----------------------------------------------------------------------------------------------
            //Q7
            /* int[] arr7 = { 2, 3, 4, 5, 6 };
             int sum = 0;
             for (int i = 0; i < arr7.Length; i++)
             {
                 sum = sum +arr7[i];
             }
             Console.WriteLine("Sum = " + sum + " The avg = " + (double)sum / arr7.Length);*/
            //----------------------------------------------------------------------------------------------
            //Q8
            /* int[] arr8 = new int[5];
             int[] reverseArr8 = new int[5];
             for (int i=0; i<arr8.Length; i++)
             {
                 arr8[i] = int.Parse(Console.ReadLine());
             }
             for (int i = 0 , j=arr8.Length -1; i < arr8.Length; i++ , j--)
             {
                 reverseArr8[i] = arr8[j];
             }
             for (int i = 0; i < arr8.Length; i++)
             {
                 Console.WriteLine(arr8[i] + " , " + reverseArr8[i]);
             }*/
            //----------------------------------------------------------------------------------------------
            //Q9
             int[] arr9 = new int[5];
            for (int i = 0; i < arr9.Length; i++)
            {
                arr9[i] = int.Parse(Console.ReadLine());
            }
            int temp = arr9[0];
            for (int i = 0; i < arr9.Length-1; i++)
            {
                arr9[i] = arr9[i + 1];
            }
            arr9[arr9.Length - 1] = temp;
            Console.WriteLine("Shifted array :");
            for (int i = 0; i < arr9.Length; i++)
            {
                Console.WriteLine(arr9[i]);
            }
        }
    }
}
